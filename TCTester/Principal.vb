Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports System.IO
Imports System.Net
Imports System.ComponentModel

Public Class Principal

    Enum EstadoRcv
        Inicio
        RecebeVersao
        RecebeAssincrono
        RecebeLive
        RecebeComando
    End Enum

    Public Const TCPCMD_COMMAND_CHECKLIVE As String = "#checklive"
    Public Const TCPCMD_COMMAND_ALWAYSLIVE As String = "#alwayslive"
    Public Const TCPCMD_COMMAND_RESTARTSOFT As String = "#restartsoft"

    Public Const TCPCMD_COMMAND_CONFIG As String = "#config"
    Public Const TCPCMD_COMMAND_CONFIG02 As String = "#config02"
    Public Const TCPCMD_COMMAND_EXTCONFIG As String = "#extconfig"
    Public Const TCPCMD_COMMAND_PARAMCONFIG As String = "#paramconfig"
    Public Const TCPCMD_COMMAND_UPDCONFIG As String = "#updconfig"
    Public Const TCPCMD_COMMAND_RCONF As String = "#rconf"
    Public Const TCPCMD_COMMAND_RCONF02 As String = "#reconf02"
    Public Const TCPCMD_COMMAND_REXTCONF As String = "#rextconf"
    Public Const TCPCMD_COMMAND_RPARAMCONFIG As String = "#rparamconfig"
    Public Const TCPCMD_COMMAND_RUPDCONFIG As String = "#rupdconfig"

    Public Const TCPCMD_COMMAND_MESG As String = "#mesg"
    Public Const TCPCMD_COMMAND_GIF As String = "#gif"
    Public Const TCPCMD_COMMAND_AUDIO As String = "#playaudiowithmessage"

    Public Const TCPCMD_COMMAND_MACADDR As String = "#macaddr"

    Public Const TCPCMD_COMMAND_WLANCONFIG As String = "#wlanconfig"
    Public Const TCPCMD_COMMAND_RWLANCONFIG As String = "#rwlanconfig"
    Public Const TCPCMD_COMMAND_SLEEP As String = "#sleep"
    Public Const TCPCMD_COMMAND_WAKE As String = "#wake"
    Public Const TCPCMD_COMMAND_STATUS As String = "#status"
    Public Const TCPCMD_COMMAND_UPDFIRMWARE As String = "#m3up"
    Public Const TCPCMD_COMMAND_UPDFIRMWARE_CODE_0X0A_0X5F As String = "#\12\137"
    Public Const TCPCMD_COMMAND_LOGWORD As String = "#\165\204\197\55"

    Public Const TCPCMD_COMMAND_LIVRE = "#"

    Const LinhaDivisao As String = "= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = ="
    Const TIMEOUT_TCP = 6000

    Const TAMANHO_MAXIMO_PACOTE_A_ENVIAR As Integer = 10000

    Const NUM_MAX_LINHAS = 400
    Dim Conta_linhas As Integer

    Dim listener As TcpListener
    Dim tcpClient As TcpClient
    Dim networkStream As NetworkStream
    Dim ThreadConexao As Threading.Thread
    Dim Conectado As Boolean = False

    Dim DeuTickTimerRecebe As Boolean
    Dim UltimoComandoEnviado As String

    Dim ME_RCV As EstadoRcv

    Dim DadosRcv As String


    Public Delegate Sub MensagemDelegate(ByVal Texto As String)

    Public Sub MaquinaEstadosRcv(ByVal Texto As String)

        Mensagem("<=== " & Texto)
        Mensagem("<--- " & ConverteStringParaHexa(Texto))

        If (Texto.IndexOf("#live") = 0) Then
            ME_RCV = EstadoRcv.RecebeAssincrono
            Exit Sub
        End If

        Select Case ME_RCV
            Case EstadoRcv.RecebeVersao
                TextBoxInfoCliente.Text += vbCrLf + "Versão: " + Texto
                ME_RCV = EstadoRcv.RecebeAssincrono

            'Case EstadoRcv.RecebeAssincrono
            '    RetornaBarCode(Texto)

            Case EstadoRcv.RecebeComando
                Select Case UltimoComandoEnviado
                    Case TCPCMD_COMMAND_MACADDR
                        TextBoxGetMAC.Text = Texto.Substring(TCPCMD_COMMAND_MACADDR.Length + 2)

                    Case TCPCMD_COMMAND_RESTARTSOFT
                        Mensagem("Cliente vai desconectar!")

                    Case Else
                        ParserComandoConfig(Texto)
                End Select

                ME_RCV = EstadoRcv.RecebeAssincrono
                TimerComando.Enabled = False

            Case Else
                RetornaBarCode(Texto)
        End Select

    End Sub

    Private Sub RetornaBarCode(ByVal Codigo As String)
        Dim Resposta As String
        Dim Descricao As String
        Dim Preco As String
        Dim EnviarAudio As String

        Mensagem("Recebeu BarCode: " + Codigo)

        Descricao = ""
        Preco = ""
        EnviarAudio = ""

        Codigo = Codigo.Substring(1, Codigo.Length - 1)

        If (DataGridView1.Rows.Count > 0) Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells.Item("Column1").Value = Codigo Then
                    'Resposta = "#" + row.Cells("Column2").Value.ToString() + "|" + row.Cells("Column3").Value.ToString()
                    Descricao = row.Cells("Column2").Value.ToString()
                    Preco = row.Cells("Column3").Value.ToString()
                    EnviarAudio = row.Cells("Column4").Value.ToString()
                    Exit For
                End If
            Next
        End If

        If (EnviarAudio = "1") Then
            EnviaAudio(Descricao, Preco)
        Else
            If (Descricao.Length > 0) Then
                Resposta = "#" + Descricao + "|" + Preco
            Else
                Resposta = "#nfound"
            End If

            Envia(Resposta)
        End If

    End Sub

    Private Sub ParserComandoConfig(ByVal Texto As String)
        LimpaInfoClientes()

        Select Case UltimoComandoEnviado
            Case TCPCMD_COMMAND_CONFIG
                Dim tam As Integer

                'retirar o comando
                Texto = Texto.Substring(TCPCMD_COMMAND_CONFIG.Length)

                'pegar Server IP
                tam = ConverteIntStringParaInteiro(Texto.Substring(0, 1))
                TextBoxGetServerIP.Text = Texto.Substring(1, tam)
                Texto = Texto.Substring(tam + 1, Texto.Length - tam - 1)

                'pegar IP do terminal
                tam = ConverteIntStringParaInteiro(Texto.Substring(0, 1))
                TextBoxGetTerminalIP.Text = Texto.Substring(1, tam)
                Texto = Texto.Substring(tam + 1, Texto.Length - tam - 1)

                'pegar máscara
                tam = ConverteIntStringParaInteiro(Texto.Substring(0, 1))
                TextBoxGetMask.Text = Texto.Substring(1, tam)
                Texto = Texto.Substring(tam + 1, Texto.Length - tam - 1)

                'pegar linha1
                tam = ConverteIntStringParaInteiro(Texto.Substring(0, 1))
                TextBoxGetLinha1.Text = Texto.Substring(1, tam)
                Texto = Texto.Substring(tam + 1, Texto.Length - tam - 1)

                'pegar linha2
                tam = ConverteIntStringParaInteiro(Texto.Substring(0, 1))
                TextBoxGetLinha2.Text = Texto.Substring(1, tam)
                Texto = Texto.Substring(tam + 1, Texto.Length - tam - 1)

                'pegar tempo de exibicao
                TextBoxGetTempoExibicao.Text = Texto


            Case TCPCMD_COMMAND_CONFIG02
                Dim tam As Integer

                'retirar o comando
                Texto = Texto.Substring(TCPCMD_COMMAND_CONFIG02.Length)

                'pegar Server IP
                tam = ConverteIntStringParaInteiro(Texto.Substring(0, 1))
                TextBoxGetServerIP.Text = Texto.Substring(1, tam)
                Texto = Texto.Substring(tam + 1, Texto.Length - tam - 1)

                'pegar IP do terminal
                tam = ConverteIntStringParaInteiro(Texto.Substring(0, 1))
                TextBoxGetTerminalIP.Text = Texto.Substring(1, tam)
                Texto = Texto.Substring(tam + 1, Texto.Length - tam - 1)

                'pegar máscara
                tam = ConverteIntStringParaInteiro(Texto.Substring(0, 1))
                TextBoxGetMask.Text = Texto.Substring(1, tam)
                Texto = Texto.Substring(tam + 1, Texto.Length - tam - 1)

                'pegar linha1
                tam = ConverteIntStringParaInteiro(Texto.Substring(0, 1))
                TextBoxGetLinha1.Text = Texto.Substring(1, tam)
                Texto = Texto.Substring(tam + 1, Texto.Length - tam - 1)

                'pegar linha2
                tam = ConverteIntStringParaInteiro(Texto.Substring(0, 1))
                TextBoxGetLinha2.Text = Texto.Substring(1, tam)
                Texto = Texto.Substring(tam + 1, Texto.Length - tam - 1)

                'pegar linha3
                tam = ConverteIntStringParaInteiro(Texto.Substring(0, 1))
                TextBoxGetLinha3.Text = Texto.Substring(1, tam)
                Texto = Texto.Substring(tam + 1, Texto.Length - tam - 1)

                'pegar linha4
                tam = ConverteIntStringParaInteiro(Texto.Substring(0, 1))
                TextBoxGetLinha4.Text = Texto.Substring(1, tam)
                Texto = Texto.Substring(tam + 1, Texto.Length - tam - 1)

                'pegar tempo de exibicao
                TextBoxGetTempoExibicao.Text = Texto



            Case TCPCMD_COMMAND_EXTCONFIG
                Dim tam As Integer

                'retirar o comando
                Texto = Texto.Substring(TCPCMD_COMMAND_EXTCONFIG.Length)

                'pegar Server IP
                tam = ConverteIntStringParaInteiro(Texto.Substring(0, 1))
                TextBoxGetServerIP.Text = Texto.Substring(1, tam)
                Texto = Texto.Substring(tam + 1, Texto.Length - tam - 1)

                'pegar IP do terminal
                tam = ConverteIntStringParaInteiro(Texto.Substring(0, 1))
                TextBoxGetTerminalIP.Text = Texto.Substring(1, tam)
                Texto = Texto.Substring(tam + 1, Texto.Length - tam - 1)

                'pegar máscara
                tam = ConverteIntStringParaInteiro(Texto.Substring(0, 1))
                TextBoxGetMask.Text = Texto.Substring(1, tam)
                Texto = Texto.Substring(tam + 1, Texto.Length - tam - 1)

                'pegar gateway
                tam = ConverteIntStringParaInteiro(Texto.Substring(0, 1))
                TextBoxGetGateway.Text = Texto.Substring(1, tam)
                Texto = Texto.Substring(tam + 1, Texto.Length - tam - 1)

                'sem suporte
                Texto = Texto.Substring(12, Texto.Length - 12)

                'pegar nome do terminal
                tam = ConverteIntStringParaInteiro(Texto.Substring(0, 1))
                TextBoxGetNomeTerminal.Text = Texto.Substring(1, tam)
                Texto = Texto.Substring(tam + 1, Texto.Length - tam - 1)

                'pegar linha1
                tam = ConverteIntStringParaInteiro(Texto.Substring(0, 1))
                TextBoxGetLinha1.Text = Texto.Substring(1, tam)
                Texto = Texto.Substring(tam + 1, Texto.Length - tam - 1)

                'pegar linha2
                tam = ConverteIntStringParaInteiro(Texto.Substring(0, 1))
                TextBoxGetLinha2.Text = Texto.Substring(1, tam)
                Texto = Texto.Substring(tam + 1, Texto.Length - tam - 1)

                'sem suporte
                Texto = Texto.Substring(12, Texto.Length - 12)

                'sem suporte
                Texto = Texto.Substring(12, Texto.Length - 12)

                'sem suporte
                Texto = Texto.Substring(12, Texto.Length - 12)

                'pegar tempo de exibicao
                TextBoxGetTempoExibicao.Text = Texto.Substring(0, 1)
                Texto = Texto.Substring(1, Texto.Length - 1)

                'pegar tipo IP
                If (Texto.Substring(0, 1) = "0") Then
                    RadioButtonGetFixo.Checked = True
                ElseIf (Texto.Substring(0, 1) = "1") Then
                    RadioButtonGetDinamico.Checked = True
                End If

                'vem mais um byte de bobo?



            Case TCPCMD_COMMAND_PARAMCONFIG
                'retirar o comando
                Texto = Texto.Substring(TCPCMD_COMMAND_PARAMCONFIG.Length)

                'pegar tipo IP
                If (Texto.Substring(0, 1) = "0") Then
                    RadioButtonGetFixo.Checked = True
                ElseIf (Texto.Substring(0, 1) = "1") Then
                    RadioButtonGetDinamico.Checked = True
                End If
                Texto = Texto.Substring(1, Texto.Length - 1)


            Case TCPCMD_COMMAND_UPDCONFIG
                Dim tam As Integer

                'retirar o comando
                Texto = Texto.Substring(TCPCMD_COMMAND_UPDCONFIG.Length)

                'pegar gateway
                tam = ConverteIntStringParaInteiro(Texto.Substring(0, 1))
                TextBoxGetGateway.Text = Texto.Substring(1, tam)
                Texto = Texto.Substring(tam + 1, Texto.Length - tam - 1)

                'sem suporte
                Texto = Texto.Substring(12, Texto.Length - 12)

                'pegar nome do terminal
                tam = ConverteIntStringParaInteiro(Texto.Substring(0, 1))
                TextBoxGetNomeTerminal.Text = Texto.Substring(1, tam)
                Texto = Texto.Substring(tam + 1, Texto.Length - tam - 1)



        End Select
    End Sub

    Private Sub LimpaInfoClientes()
        TextBoxGetServerIP.Text = ""
        TextBoxGetTerminalIP.Text = ""
        TextBoxGetMask.Text = ""
        TextBoxGetLinha2.Text = ""
        TextBoxGetLinha1.Text = ""
        TextBoxGetLinha3.Text = ""
        TextBoxGetLinha4.Text = ""
        TextBoxGetGateway.Text = ""
        TextBoxGetTempoExibicao.Text = ""
        TextBoxGetNomeTerminal.Text = ""
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = Application.ProductName & " - V" & Application.ProductVersion.ToString
        TextBoxServerIP.Text = My.Settings.ServerIP


        DeuTickTimerRecebe = False
        ComboBoxSetConfig.Items.Add("rconf")
        ComboBoxSetConfig.Items.Add("reconf02")
        ComboBoxSetConfig.Items.Add("rextconf")
        ComboBoxSetConfig.Items.Add("rparamconfig")
        ComboBoxSetConfig.Items.Add("rupdconfig")
        ComboBoxSetConfig.Items.Add("rwlanconfig")
        HideAllSetConfig()

        ComboBoxGetConfig.Items.Add("config")
        ComboBoxGetConfig.Items.Add("config02")
        ComboBoxGetConfig.Items.Add("extconfig")
        ComboBoxGetConfig.Items.Add("paramconfig")
        ComboBoxGetConfig.Items.Add("updconfig")
        ComboBoxGetConfig.Items.Add("wlanconfig")
        HideAllGetConfig()

        TextBoxBarCodeFile.Text = My.Settings.BarCodeFile
        TextBoxBarCodeSeparador.Text = My.Settings.BarCodeSeparador
        TextBoxAudioFileName.Text = My.Settings.BarCodeAudio

        CarregaArquivoCSV()


        'DesabilitaComandos()
    End Sub

    Private Sub ButtonConectar_Click(sender As Object, e As EventArgs) Handles ButtonConectar.Click
        If (Conectado = False) Then
            Conectar()
        Else
            Desconectar()
        End If
    End Sub

    Private Sub Conectar()
        UltimoComandoEnviado = ""
        Conectado = True
        ButtonConectar.Text = "Parar"
        TextBoxPorta.Enabled = False
        TextBoxServerIP.Enabled = False
        ThreadConexao = New Thread(AddressOf IniciaConexao)
        ThreadConexao.IsBackground = True
        ThreadConexao.Start()
    End Sub

    Private Sub Desconectar()
        'fecha TcpListener e TcpClient.
        TimerLive.Enabled = False

        Try
            tcpClient.Close()
        Catch ex As Exception

        End Try

        TimerClientConnected.Enabled = False

        listener.Stop()
        Mensagem("Servidor parado.")

        Conectado = False
        ButtonConectar.Text = "Iniciar"
        TextBoxPorta.Enabled = True
        TextBoxServerIP.Enabled = True
        ThreadConexao.Abort()
        listener.Stop()
        DesabilitaComandos()

    End Sub

    Private Sub HabilitaComandos()
        Dim tabPage As TabPage

        For Each tabPage In TabControl1.TabPages
            tabPage.Enabled = True
        Next
    End Sub

    Private Sub DesabilitaComandos()
        Dim tabPage As TabPage

        For Each tabPage In TabControl1.TabPages
            tabPage.Enabled = False
        Next

    End Sub

    Private Sub RcvTCPMensagem()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf RcvTCPMensagem))
        Else
            MaquinaEstadosRcv(DadosRcv)
        End If
    End Sub

    Public Sub IniciaConexao()

        If Me.InvokeRequired Then
            Me.BeginInvoke(New MethodInvoker(AddressOf IniciaConexao))
        Else
            Mensagem(LinhaDivisao)
            listener = New TcpListener(IPAddress.Parse(TextBoxServerIP.Text), Convert.ToInt32(TextBoxPorta.Text))
            Try
                listener.Start()
            Catch ex As Exception
                Mensagem("Erro ao iniciar o listener: " & ex.ToString)
                Mensagem("Há outra porta aberta?")
                Desconectar()
                Exit Sub
            End Try

            Mensagem("Listener aberto em " & TextBoxServerIP.Text & ":" & TextBoxPorta.Text & "...")

            Try
                'aceita a conexao do cliente e retorna uma inicializacao TcpClient 
                Do While Conectado = True
                    If listener.Pending Then
                        tcpClient = listener.AcceptTcpClient()
                        Exit Do
                    End If
                    Thread.Sleep(100)
                    Application.DoEvents()
                Loop

                'parar o listener...aceitar apenas 1 conexão
                listener.Stop()

                'verificar se não saiu do loop acima por clicar no botão desconectar
                If (Conectado = False) Then
                    Exit Sub
                End If

                Mensagem("Conectado o cliente " & tcpClient.Client.RemoteEndPoint.ToString() & "!")
                TextBoxInfoCliente.Text = "IP: " + tcpClient.Client.RemoteEndPoint.ToString()

                ' obtem o stream
                networkStream = tcpClient.GetStream()

                'envia um OK
                Envia("#ok")
                ME_RCV = EstadoRcv.RecebeVersao

                HabilitaComandos()

                TimerClientConnected.Enabled = True
                TimerLive.Enabled = True

                'loop infinito para a recepcao
                While (Conectado = True)
                    Try
                        If (tcpClient.Available() > 0) Then
                            'System.Threading.Thread.Sleep(1)
                            Dim buffSize As Integer
                            buffSize = tcpClient.ReceiveBufferSize
                            Dim inStream(buffSize) As Byte
                            networkStream.Read(inStream, 0, buffSize)
                            'Dim dadosRetornados As String = Encoding.ASCII.GetString(inStream)
                            Dim dadosRetornados As String = Encoding.Default.GetString(inStream)
                            dadosRetornados = dadosRetornados.Replace(Convert.ToChar(0), "")

                            DadosRcv = "" + dadosRetornados
                            RcvTCPMensagem()
                        End If
                        Application.DoEvents()
                        System.Threading.Thread.Sleep(1)
                        Application.DoEvents()


                    Catch ex As Exception
                        'MsgBox(ex.Message)
                        Exit Sub
                    End Try
                End While

            Catch e As Exception
                Mensagem("Ocorreu um erro: " & e.ToString())
                Desconectar()
                Mensagem(LinhaDivisao)
            End Try
        End If

    End Sub

    Public Sub Envia(ByVal Texto As String)
        Mensagem("===> " & Texto)
        Mensagem("---> " & ConverteStringParaHexa(Texto))
        Dim sendBytes As [Byte]() = Encoding.Default.GetBytes(Texto)
        networkStream.Write(sendBytes, 0, sendBytes.Length)
        networkStream.Flush()
    End Sub

    Public Sub Mensagem(ByVal Texto As String)

        If Me.InvokeRequired Then
            Me.BeginInvoke(New MensagemDelegate(AddressOf Mensagem), New Object() {Texto})
        Else
            'apagar linhas caso passe do limite
            If (Conta_linhas > NUM_MAX_LINHAS) Then
                TextBoxDebug.Text = ""
                Conta_linhas = 0
            End If

            Texto = DateTime.Now & " - " & Texto
            TextBoxDebug.Text = TextBoxDebug.Text & vbCrLf & Texto
            TextBoxDebug.Select(TextBoxDebug.TextLength, 0)
            TextBoxDebug.ScrollToCaret()

            Conta_linhas = Conta_linhas + 1
            LogarEmArquivo(Texto & vbCrLf)

            Application.DoEvents()
        End If
    End Sub

    Public Sub MensagemMesmaLinha(ByVal Texto As String)
        If Me.InvokeRequired Then
            Me.BeginInvoke(New MensagemDelegate(AddressOf Mensagem), New Object() {Texto})
        Else

            'apagar linhas caso passe do limite
            If (Conta_linhas > NUM_MAX_LINHAS) Then
                Conta_linhas = 0
                TextBoxDebug.Text = ""
            End If

            TextBoxDebug.Text = TextBoxDebug.Text & Texto
            TextBoxDebug.Select(TextBoxDebug.TextLength, 0)
            TextBoxDebug.ScrollToCaret()

            LogarEmArquivo(Texto)

            Application.DoEvents()

        End If
    End Sub

    Private Sub LogarEmArquivo(ByVal Texto As String)
        File.AppendAllText("log.txt", Texto)
    End Sub

    Private Sub TimerClientConnected_Tick(sender As Object, e As EventArgs) Handles TimerClientConnected.Tick
        'RecebeImediatamente()
        If tcpClient.Client.Poll(1000, SelectMode.SelectRead) = True Then
            Mensagem("Cliente desconectou!")
            Desconectar()
            Conectar()
        End If
    End Sub

    Private Sub TimerLive_Tick(sender As Object, e As EventArgs) Handles TimerLive.Tick
        If (CheckBoxEnviarLive.Checked = True) Then
            If (ME_RCV = EstadoRcv.RecebeAssincrono) Then
                ME_RCV = EstadoRcv.RecebeLive
                Envia("#live?")
                TimerLive.Interval = 9800
            ElseIf (ME_RCV = EstadoRcv.RecebeLive) Then
                Mensagem("Cliente não respondeu Live!")
                Desconectar()
                Conectar()
            Else
                TimerLive.Interval = 1000
            End If
        End If
    End Sub

    Private Sub EnviaComando(ByVal Comando As String)

        ME_RCV = EstadoRcv.RecebeComando
        If (Comando.IndexOf("?") > 0) Then
            UltimoComandoEnviado = Comando.Substring(0, Comando.Length - 1)
        Else
            UltimoComandoEnviado = Comando
        End If

        Envia(Comando)
        TimerComando.Enabled = True

    End Sub

    Private Sub EnviaComandoSemResposta(ByVal Comando As String, ByVal Parametro As String)

        If (Comando.IndexOf("?") > 0) Then
            UltimoComandoEnviado = Comando.Substring(0, Comando.Length - 1)
        Else
            UltimoComandoEnviado = Comando
        End If

        Envia(Comando + Parametro)
        Mensagem("Comando sem resposta. Verifique se irá cair a conexão e o BPG2 irá resetar automaticamente!")

    End Sub

    Private Sub EnviaComando(ByVal Comando As String, ByVal Parametro As String)

        ME_RCV = EstadoRcv.RecebeComando
        UltimoComandoEnviado = Comando
        Envia(Comando + Parametro)
        TimerComando.Enabled = True
    End Sub

    Private Sub ButtonGetMAC_Click(sender As Object, e As EventArgs) Handles ButtonGetMAC.Click
        EnviaComando(TCPCMD_COMMAND_MACADDR + "?")
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        EnviaComando(TCPCMD_COMMAND_RESTARTSOFT, ConverteHexaParaString("A5 CC 5A 33"))
    End Sub

    Private Sub ButtonAlwaysLive_Click(sender As Object, e As EventArgs) Handles ButtonAlwaysLive.Click
        EnviaComando(TCPCMD_COMMAND_ALWAYSLIVE)
        TimerLive.Enabled = False
    End Sub

    Private Sub ButtonCheckLive_Click(sender As Object, e As EventArgs) Handles ButtonCheckLive.Click
        EnviaComando(TCPCMD_COMMAND_CHECKLIVE)
        TimerLive.Enabled = True
    End Sub

    Private Sub HideAllGetConfig()
        LabelGetServerIP.Visible = False
        LabelGetTerminalIP.Visible = False
        LabelGetMask.Visible = False
        LabelGetGateway.Visible = False
        LabelGetTipoIP.Visible = False
        LabelGetNomeTerminal.Visible = False
        TextBoxGetServerIP.Visible = False
        TextBoxGetTerminalIP.Visible = False
        TextBoxGetMask.Visible = False
        TextBoxGetGateway.Visible = False
        RadioButtonGetDinamico.Visible = False
        RadioButtonGetFixo.Visible = False
        TextBoxGetNomeTerminal.Visible = False

        LabelGetLinha1.Visible = False
        LabelGetLinha2.Visible = False
        LabelGetLinha3.Visible = False
        LabelGetLinha4.Visible = False
        LabelGetTempoExibicao.Visible = False

        TextBoxGetLinha1.Visible = False
        TextBoxGetLinha2.Visible = False
        TextBoxGetLinha3.Visible = False
        TextBoxGetLinha4.Visible = False
        TextBoxGetTempoExibicao.Visible = False

        LabelGetHabilitaWifi.Visible = False
        RadioButtonGetHabilitaWifi.Visible = False
        RadioButtonGetDesabilitaWifi.Visible = False
        LabelGetSSID.Visible = False
        LabelGetTipoCripto.Visible = False
        LabelGetSenha.Visible = False
        TextBoxGetSSID.Visible = False
        ComboBoxGetTipoCripto.Visible = False
        TextBoxGetSenha.Visible = False

    End Sub

    Private Sub SelecionaComandoGetConfig()
        HideAllGetConfig()

        Select Case ComboBoxGetConfig.Text
            Case "config"
                LabelGetServerIP.Visible = True
                LabelGetTerminalIP.Visible = True
                LabelGetMask.Visible = True
                TextBoxGetServerIP.Visible = True
                TextBoxGetTerminalIP.Visible = True
                TextBoxGetMask.Visible = True

                LabelGetLinha1.Visible = True
                LabelGetLinha2.Visible = True
                LabelGetTempoExibicao.Visible = True
                TextBoxGetLinha1.Visible = True
                TextBoxGetLinha2.Visible = True
                TextBoxGetTempoExibicao.Visible = True

            Case "config02"
                LabelGetServerIP.Visible = True
                LabelGetTerminalIP.Visible = True
                LabelGetMask.Visible = True
                TextBoxGetServerIP.Visible = True
                TextBoxGetTerminalIP.Visible = True
                TextBoxGetMask.Visible = True

                LabelGetLinha1.Visible = True
                LabelGetLinha2.Visible = True
                LabelGetLinha3.Visible = True
                LabelGetLinha4.Visible = True
                LabelGetTempoExibicao.Visible = True
                TextBoxGetLinha1.Visible = True
                TextBoxGetLinha2.Visible = True
                TextBoxGetLinha3.Visible = True
                TextBoxGetLinha4.Visible = True
                TextBoxGetTempoExibicao.Visible = True

            Case "extconfig"
                LabelGetServerIP.Visible = True
                LabelGetTerminalIP.Visible = True
                LabelGetMask.Visible = True
                LabelGetGateway.Visible = True
                LabelGetTipoIP.Visible = True
                LabelGetNomeTerminal.Visible = True
                TextBoxGetServerIP.Visible = True
                TextBoxGetTerminalIP.Visible = True
                TextBoxGetMask.Visible = True
                TextBoxGetGateway.Visible = True
                RadioButtonGetDinamico.Visible = True
                RadioButtonGetFixo.Visible = True
                TextBoxGetNomeTerminal.Visible = True

                LabelGetLinha1.Visible = True
                LabelGetLinha2.Visible = True
                LabelGetTempoExibicao.Visible = True
                TextBoxGetLinha1.Visible = True
                TextBoxGetLinha2.Visible = True
                TextBoxGetTempoExibicao.Visible = True

            Case "paramconfig"
                LabelGetTipoIP.Visible = True
                RadioButtonGetDinamico.Visible = True
                RadioButtonGetFixo.Visible = True

            Case "updconfig"
                LabelGetGateway.Visible = True
                LabelGetNomeTerminal.Visible = True
                TextBoxGetGateway.Visible = True
                TextBoxGetNomeTerminal.Visible = True

            Case "wlanconfig"
                LabelGetHabilitaWifi.Visible = True
                RadioButtonGetHabilitaWifi.Visible = True
                RadioButtonGetDesabilitaWifi.Visible = True
                LabelGetSSID.Visible = True
                LabelGetTipoCripto.Visible = True
                LabelGetSenha.Visible = True
                TextBoxGetSSID.Visible = True
                ComboBoxGetTipoCripto.Visible = True
                TextBoxGetSenha.Visible = True


        End Select
    End Sub

    Private Sub ComboBoxGetConfig_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxGetConfig.SelectedIndexChanged
        SelecionaComandoGetConfig()
    End Sub

    Private Sub HideAllSetConfig()
        LabelSetServerIP.Visible = False
        LabelSetTerminalIP.Visible = False
        LabelSetMask.Visible = False
        LabelSetGateway.Visible = False
        LabelSetTipoIP.Visible = False
        LabelSetNomeTerm.Visible = False
        TextBoxSetServerIP.Visible = False
        TextBoxSetTerminalIP.Visible = False
        TextBoxSetMask.Visible = False
        TextBoxSetGateway.Visible = False
        RadioButtonSetIPDinâmico.Visible = False
        RadioButtonSetIPFixo.Visible = False
        TextBoxSetNomeTerm.Visible = False

        LabelSetLinha1.Visible = False
        LabelSetLinha2.Visible = False
        LabelSetLinha3.Visible = False
        LabelSetLinha4.Visible = False
        LabelSetTempoExibicao.Visible = False

        TextBoxSetLinha1.Visible = False
        TextBoxSetLinha2.Visible = False
        TextBoxSetLinha3.Visible = False
        TextBoxSetLinha4.Visible = False
        TextBoxSetTempoExibicao.Visible = False

        LabelSetHabilitaWifi.Visible = False
        RadioButtonSetHabilitaWifi.Visible = False
        RadioButtonSetDesabilitaWifi.Visible = False
        LabelSetSSID.Visible = False
        LabelSetTipoCripto.Visible = False
        LabelSetSenha.Visible = False
        TextBoxSetSSID.Visible = False
        ComboBoxSetTipoCripto.Visible = False
        TextBoxSetSenha.Visible = False


    End Sub

    Private Sub SelecionaComandoSetConfig()
        HideAllSetConfig()

        Select Case ComboBoxSetConfig.Text
            Case "rconf"
                LabelSetServerIP.Visible = True
                LabelSetTerminalIP.Visible = True
                LabelSetMask.Visible = True
                TextBoxSetServerIP.Visible = True
                TextBoxSetTerminalIP.Visible = True
                TextBoxSetMask.Visible = True

                LabelSetLinha1.Visible = True
                LabelSetLinha2.Visible = True
                LabelSetTempoExibicao.Visible = True
                TextBoxSetLinha1.Visible = True
                TextBoxSetLinha2.Visible = True
                TextBoxSetTempoExibicao.Visible = True

            Case "reconf02"
                LabelSetServerIP.Visible = True
                LabelSetTerminalIP.Visible = True
                LabelSetMask.Visible = True
                TextBoxSetServerIP.Visible = True
                TextBoxSetTerminalIP.Visible = True
                TextBoxSetMask.Visible = True

                LabelSetLinha1.Visible = True
                LabelSetLinha2.Visible = True
                LabelSetLinha3.Visible = True
                LabelSetLinha4.Visible = True
                LabelSetTempoExibicao.Visible = True
                TextBoxSetLinha1.Visible = True
                TextBoxSetLinha2.Visible = True
                TextBoxSetLinha3.Visible = True
                TextBoxSetLinha4.Visible = True
                TextBoxSetTempoExibicao.Visible = True

            Case "rextconf"
                LabelSetServerIP.Visible = True
                LabelSetTerminalIP.Visible = True
                LabelSetMask.Visible = True
                LabelSetGateway.Visible = True
                LabelSetTipoIP.Visible = True
                LabelSetNomeTerm.Visible = True
                TextBoxSetServerIP.Visible = True
                TextBoxSetTerminalIP.Visible = True
                TextBoxSetMask.Visible = True
                TextBoxSetGateway.Visible = True
                RadioButtonSetIPDinâmico.Visible = True
                RadioButtonSetIPFixo.Visible = True
                TextBoxSetNomeTerm.Visible = True

                LabelSetLinha1.Visible = True
                LabelSetLinha2.Visible = True
                LabelSetTempoExibicao.Visible = True
                TextBoxSetLinha1.Visible = True
                TextBoxSetLinha2.Visible = True
                TextBoxSetTempoExibicao.Visible = True

            Case "rparamconfig"
                LabelSetTipoIP.Visible = True
                RadioButtonSetIPDinâmico.Visible = True
                RadioButtonSetIPFixo.Visible = True

            Case "rupdconfig"
                LabelSetGateway.Visible = True
                LabelSetNomeTerm.Visible = True
                TextBoxSetGateway.Visible = True
                TextBoxSetNomeTerm.Visible = True

            Case "rwlanconfig"
                LabelSetHabilitaWifi.Visible = True
                RadioButtonSetHabilitaWifi.Visible = True
                RadioButtonSetDesabilitaWifi.Visible = True
                LabelSetSSID.Visible = True
                LabelSetTipoCripto.Visible = True
                LabelSetSenha.Visible = True
                TextBoxSetSSID.Visible = True
                ComboBoxSetTipoCripto.Visible = True
                TextBoxSetSenha.Visible = True

        End Select
    End Sub

    Private Sub ComboBoxSetConfig_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSetConfig.SelectedIndexChanged
        SelecionaComandoSetConfig
    End Sub

    Private Function GetTamEString(ByVal Comando As String)
        Dim Ret As String

        Ret = ConverteInteiroParaIntString(Comando.Length) + Comando
        'Ret = ConverteInteiroParaString(Comando.Length) + Comando
        'Ret = Comando.Length.ToString("X") + Comando
        GetTamEString = Ret

    End Function

    Private Sub ButtonGetConfig_Click(sender As Object, e As EventArgs) Handles ButtonGetConfig.Click

        Dim ComandoAEnviar As String

        ComandoAEnviar = "#" + ComboBoxGetConfig.Text + "?"
        EnviaComando(ComandoAEnviar)

    End Sub

    Private Sub ButtonSetConfig_Click(sender As Object, e As EventArgs) Handles ButtonSetConfig.Click
        Dim ComandoAEnviar As String
        Dim Parametro As String

        ComandoAEnviar = "#" + ComboBoxSetConfig.Text

        Parametro = ""
        Select Case ComboBoxSetConfig.Text
            Case "rconf"
                Parametro += GetTamEString(TextBoxSetServerIP.Text)
                Parametro += GetTamEString(TextBoxSetTerminalIP.Text)
                Parametro += GetTamEString(TextBoxSetMask.Text)
                Parametro += GetTamEString(TextBoxSetLinha1.Text)
                Parametro += GetTamEString(TextBoxSetLinha2.Text)
                Parametro += ConverteInteiroParaIntString(TextBoxSetTempoExibicao.Text)

            Case "reconf02"
                Parametro += GetTamEString(TextBoxSetServerIP.Text)
                Parametro += GetTamEString(TextBoxSetTerminalIP.Text)
                Parametro += GetTamEString(TextBoxSetMask.Text)
                Parametro += GetTamEString(TextBoxSetLinha1.Text)
                Parametro += GetTamEString(TextBoxSetLinha2.Text)
                Parametro += GetTamEString(TextBoxSetLinha3.Text)
                Parametro += GetTamEString(TextBoxSetLinha4.Text)
                Parametro += ConverteInteiroParaIntString(Convert.ToInt32(TextBoxSetTempoExibicao.Text))

            Case "rextconf"
                Parametro += GetTamEString(TextBoxSetServerIP.Text)
                Parametro += GetTamEString(TextBoxSetTerminalIP.Text)
                Parametro += GetTamEString(TextBoxSetMask.Text)
                Parametro += GetTamEString(TextBoxSetGateway.Text)
                'string vazia
                Parametro += ConverteInteiroParaIntString(0)
                Parametro += GetTamEString(TextBoxSetNomeTerm.Text)
                Parametro += GetTamEString(TextBoxSetLinha1.Text)
                Parametro += GetTamEString(TextBoxSetLinha2.Text)
                'string vazia
                Parametro += ConverteInteiroParaIntString(0)
                'string vazia
                Parametro += ConverteInteiroParaIntString(0)
                'string vazia
                Parametro += ConverteInteiroParaIntString(0)
                Parametro += ConverteInteiroParaIntString(Convert.ToInt32(TextBoxSetTempoExibicao.Text))
                If RadioButtonSetIPFixo.Checked Then
                    Parametro += ConverteInteiroParaIntString(0)
                Else
                    Parametro += ConverteInteiroParaIntString(1)
                End If
                'string vazia
                Parametro += ConverteInteiroParaIntString(0)


            Case "rparamconfig"
                If RadioButtonSetIPFixo.Checked Then
                    Parametro += ConverteInteiroParaIntString(0)
                Else
                    Parametro += ConverteInteiroParaIntString(1)
                End If
                'string vazia
                Parametro += ConverteInteiroParaIntString(0)

            Case "rupdconfig"
                Parametro += GetTamEString(TextBoxSetGateway.Text)
                Parametro += GetTamEString("Sem Suporte")
                Parametro += GetTamEString(TextBoxSetNomeTerm.Text)
                'Parametro += GetTamEString("Nao suportado")
                'Parametro += GetTamEString("Nao suportado")
                'Parametro += GetTamEString("Nao suportado")
                Parametro += GetTamEString("Sem Suporte")
                Parametro += GetTamEString("Sem Suporte")
                Parametro += GetTamEString("Sem Suporte")

            Case "rwlanconfig"

                If (RadioButtonSetHabilitaWifi.Checked = True) Then
                    Parametro += ConverteInteiroParaIntString(1)
                Else
                    Parametro += ConverteInteiroParaIntString(0)
                End If

                Parametro += GetTamEString(TextBoxSetSSID.Text)
                Parametro += ConverteInteiroParaIntString(ComboBoxSetTipoCripto.SelectedIndex)
                Parametro += GetTamEString(TextBoxSetSenha.Text)

                'enable
                'tam ssid
                'ssid
                'tipo cripto
                'tam pwd
                'pwd


        End Select


        EnviaComandoSemResposta(ComandoAEnviar, Parametro)

    End Sub

    Private Sub ButtonMesg_Click(sender As Object, e As EventArgs) Handles ButtonMesg.Click
        Dim Parametros As String

        Parametros = ""

        Parametros += GetTamEString(TextBoxMesgLinha1.Text)
        Parametros += GetTamEString(TextBoxMesgLinha2.Text)
        Parametros += ConverteInteiroParaIntString(Convert.ToInt32(TextBoxMesgTempo.Text))

        EnviaComando(TCPCMD_COMMAND_MESG, Parametros)
    End Sub

    Private Sub ButtonGifGetImagem_Click(sender As Object, e As EventArgs) Handles ButtonGifGetImagem.Click
        If (OpenFileDialogGif.ShowDialog() <> 1) Then
            Exit Sub
        Else
            TextBoxGifFileName.Text = OpenFileDialogGif.FileName
        End If
    End Sub

    Private Sub ButtonGif_Click(sender As Object, e As EventArgs) Handles ButtonGif.Click
        Dim Parametros As String
        Dim fi As FileInfo
        Dim tamGif As Long

        If Not File.Exists(TextBoxGifFileName.Text) Then
            Mensagem("Arquivo " + TextBoxGifFileName.Text + " não existe!")
            Exit Sub
        End If

        fi = New FileInfo(TextBoxGifFileName.Text)
        tamGif = fi.Length

        Parametros = ""

        Parametros += FormataTamanhoStringZeroEsq(TextBoxGifIndice.Text, 2)
        Parametros += FormataTamanhoStringZeroEsq(TextBoxGifLoops.Text, 2)
        Parametros += FormataTamanhoStringZeroEsq(TextBoxGifTempo.Text, 2)
        Parametros += ConverteLongParaString(tamGif, 6)

        Parametros += "0000" 'checksum - não utilizado
        Parametros += ConverteHexaParaString("17")   'ETB

        EnviaComando(TCPCMD_COMMAND_GIF, Parametros)

        'enviar o gif separado
        Dim sendBytes As [Byte]() = File.ReadAllBytes(TextBoxGifFileName.Text)
        networkStream.Write(sendBytes, 0, sendBytes.Length)
        networkStream.Flush()

    End Sub

    Private Sub ButtonComandoLivre_Click(sender As Object, e As EventArgs) Handles ButtonComandoLivre.Click

        EnviaComando(TCPCMD_COMMAND_LIVRE, TextBoxComandoLivre.Text)

    End Sub

    Dim AlterouStr As Boolean = False
    Dim AlterouHex As Boolean = False

    Private Sub TextBoxComandoLivre_TextChanged(sender As Object, e As EventArgs) Handles TextBoxComandoLivre.TextChanged

        If (AlterouHex = False) Then
            AlterouStr = True
            TextBoxComandoLivreHexa.Text = ConverteStringParaHexa(TextBoxComandoLivre.Text)
        Else
            AlterouHex = False
        End If
    End Sub

    Private Sub TextBoxComandoLivreHexa_TextChanged(sender As Object, e As EventArgs) Handles TextBoxComandoLivreHexa.TextChanged
        If (AlterouStr = False) Then
            AlterouHex = True
            TextBoxComandoLivreHexa.Text = InsereEspacoEmHexa(RetiraEspacoEmHexa(TextBoxComandoLivreHexa.Text))
            TextBoxComandoLivreHexa.Select(TextBoxComandoLivreHexa.Text.Length, 0)
            TextBoxComandoLivre.Text = ConverteHexaParaString(TextBoxComandoLivreHexa.Text)
        Else
            AlterouStr = False
        End If
    End Sub

    Private Sub TextBoxBarCodeFile_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBarCodeFile.TextChanged
        My.Settings.BarCodeFile = TextBoxBarCodeFile.Text
        My.Settings.Save()
    End Sub

    Private Sub TextBoxBarCodeSeparador_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBarCodeSeparador.TextChanged
        My.Settings.BarCodeSeparador = TextBoxBarCodeSeparador.Text
        My.Settings.Save()
    End Sub

    Private Sub CarregaArquivoCSV()
        Dim TextLine As String = ""
        Dim SplitLine() As String

        Me.DataGridView1.Rows.Clear()

        If System.IO.File.Exists(TextBoxBarCodeFile.Text) = True Then
            Dim objReader As New System.IO.StreamReader(TextBoxBarCodeFile.Text, Encoding.ASCII)
            Do While objReader.Peek() <> -1
                TextLine = objReader.ReadLine()
                SplitLine = Split(TextLine, TextBoxBarCodeSeparador.Text)
                Me.DataGridView1.Rows.Add(SplitLine)
            Loop
            objReader.Close()
        End If

    End Sub

    Private Sub ButtonBarCodeAtualizaTabela_Click(sender As Object, e As EventArgs) Handles ButtonBarCodeAtualizaTabela.Click
        CarregaArquivoCSV()
    End Sub

    Private Sub TimerComando_Tick(sender As Object, e As EventArgs) Handles TimerComando.Tick
        Mensagem("Timeout ao receber o comando!")
        TimerComando.Enabled = False
        ME_RCV = EstadoRcv.RecebeAssincrono
    End Sub

    Private Sub ButtonAudioGetFile_Click(sender As Object, e As EventArgs) Handles ButtonAudioGetFile.Click
        If (OpenFileDialogAudio.ShowDialog() <> 1) Then
            Exit Sub
        Else
            TextBoxAudioFileName.Text = OpenFileDialogAudio.FileName
        End If
    End Sub

    Private Sub TextBoxAudioFileName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAudioFileName.TextChanged
        My.Settings.BarCodeAudio = TextBoxAudioFileName.Text
        My.Settings.Save()
    End Sub

    Public Sub EnviaAudio(ByVal Descricao As String, ByVal Preco As String)
        Dim Parametros As String
        Dim fi As FileInfo
        Dim tamAudio As Long
        Dim TempTam As String

        If Not File.Exists(TextBoxAudioFileName.Text) Then
            Mensagem("Arquivo " + TextBoxAudioFileName.Text + " não existe!")
            Exit Sub
        End If

        fi = New FileInfo(TextBoxAudioFileName.Text)
        tamAudio = fi.Length

        Parametros = ""

        Parametros += ConverteLongParaString(tamAudio, 6)
        Parametros += FormataTamanhoStringZeroEsq(TextBoxAudioDuracao.Text, 1)
        Parametros += FormataTamanhoStringZeroEsq(TextBoxAudioVolume.Text, 1)


        TempTam = Descricao.Length.ToString
        If (TempTam.Length < 2) Then
            TempTam = "0" + TempTam
        End If
        Parametros += TempTam + Descricao

        TempTam = Preco.Length.ToString
        If (TempTam.Length < 2) Then
            TempTam = "0" + TempTam
        End If
        Parametros += TempTam + Preco

        'aguardar 3s! Se responder antes, não vai tocar (está tocando o 'buscando preço, aguarde...')
        Thread.Sleep(3000)

        EnviaComando(TCPCMD_COMMAND_AUDIO, Parametros)

        'enviar o audio separado
        Dim sendBytes As [Byte]() = File.ReadAllBytes(TextBoxAudioFileName.Text)
        networkStream.Write(sendBytes, 0, sendBytes.Length)
        networkStream.Flush()
    End Sub

    Private Sub ButtonGetFW_Click(sender As Object, e As EventArgs) Handles ButtonGetFW.Click
        If (OpenFileDialogFW.ShowDialog() <> 1) Then
            Exit Sub
        Else
            TextBoxFW.Text = OpenFileDialogFW.FileName
        End If
    End Sub

    Private Sub ButtonFileCSV_Click(sender As Object, e As EventArgs) Handles ButtonFileCSV.Click
        If (OpenFileDialogCSV.ShowDialog() <> 1) Then
            Exit Sub
        Else
            TextBoxBarCodeFile.Text = OpenFileDialogCSV.FileName
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        TextBoxDebug.Text = ""
    End Sub

    Private Sub TextBoxServerIP_TextChanged(sender As Object, e As EventArgs) Handles TextBoxServerIP.TextChanged
        My.Settings.ServerIP = TextBoxServerIP.Text
        My.Settings.Save()

    End Sub
End Class
