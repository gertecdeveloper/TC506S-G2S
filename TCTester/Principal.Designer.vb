<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxEnviarLive = New System.Windows.Forms.CheckBox()
        Me.ButtonConectar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxPorta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxServerIP = New System.Windows.Forms.TextBox()
        Me.TextBoxDebug = New System.Windows.Forms.TextBox()
        Me.ContextMenuStripClearDebug = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerClientConnected = New System.Windows.Forms.Timer(Me.components)
        Me.TimerLive = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TextBoxFW = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ButtonGetFW = New System.Windows.Forms.Button()
        Me.ButtonSendFW = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ButtonMesg = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBoxMesgTempo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBoxMesgLinha2 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBoxMesgLinha1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonCheckLive = New System.Windows.Forms.Button()
        Me.ButtonAlwaysLive = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxGetMAC = New System.Windows.Forms.TextBox()
        Me.ButtonGetMAC = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ButtonGetConfig = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxGetConfig = New System.Windows.Forms.ComboBox()
        Me.FlowLayoutPanel8 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TextBoxGetLinha1 = New System.Windows.Forms.TextBox()
        Me.TextBoxGetLinha2 = New System.Windows.Forms.TextBox()
        Me.TextBoxGetLinha3 = New System.Windows.Forms.TextBox()
        Me.TextBoxGetLinha4 = New System.Windows.Forms.TextBox()
        Me.TextBoxGetTempoExibicao = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabelGetLinha1 = New System.Windows.Forms.Label()
        Me.LabelGetLinha2 = New System.Windows.Forms.Label()
        Me.LabelGetLinha3 = New System.Windows.Forms.Label()
        Me.LabelGetLinha4 = New System.Windows.Forms.Label()
        Me.LabelGetTempoExibicao = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TextBoxGetServerIP = New System.Windows.Forms.TextBox()
        Me.TextBoxGetTerminalIP = New System.Windows.Forms.TextBox()
        Me.TextBoxGetMask = New System.Windows.Forms.TextBox()
        Me.TextBoxGetGateway = New System.Windows.Forms.TextBox()
        Me.RadioButtonGetDinamico = New System.Windows.Forms.RadioButton()
        Me.RadioButtonGetFixo = New System.Windows.Forms.RadioButton()
        Me.TextBoxGetNomeTerminal = New System.Windows.Forms.TextBox()
        Me.RadioButtonGetHabilitaWifi = New System.Windows.Forms.RadioButton()
        Me.RadioButtonGetDesabilitaWifi = New System.Windows.Forms.RadioButton()
        Me.TextBoxGetSSID = New System.Windows.Forms.TextBox()
        Me.ComboBoxGetTipoCripto = New System.Windows.Forms.ComboBox()
        Me.TextBoxGetSenha = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabelGetServerIP = New System.Windows.Forms.Label()
        Me.LabelGetTerminalIP = New System.Windows.Forms.Label()
        Me.LabelGetMask = New System.Windows.Forms.Label()
        Me.LabelGetGateway = New System.Windows.Forms.Label()
        Me.LabelGetTipoIP = New System.Windows.Forms.Label()
        Me.LabelGetNomeTerminal = New System.Windows.Forms.Label()
        Me.LabelGetHabilitaWifi = New System.Windows.Forms.Label()
        Me.LabelGetSSID = New System.Windows.Forms.Label()
        Me.LabelGetTipoCripto = New System.Windows.Forms.Label()
        Me.LabelGetSenha = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ButtonSetConfig = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TextBoxSetLinha1 = New System.Windows.Forms.TextBox()
        Me.TextBoxSetLinha2 = New System.Windows.Forms.TextBox()
        Me.TextBoxSetLinha3 = New System.Windows.Forms.TextBox()
        Me.TextBoxSetLinha4 = New System.Windows.Forms.TextBox()
        Me.TextBoxSetTempoExibicao = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabelSetLinha1 = New System.Windows.Forms.Label()
        Me.LabelSetLinha2 = New System.Windows.Forms.Label()
        Me.LabelSetLinha3 = New System.Windows.Forms.Label()
        Me.LabelSetLinha4 = New System.Windows.Forms.Label()
        Me.LabelSetTempoExibicao = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TextBoxSetServerIP = New System.Windows.Forms.TextBox()
        Me.TextBoxSetTerminalIP = New System.Windows.Forms.TextBox()
        Me.TextBoxSetMask = New System.Windows.Forms.TextBox()
        Me.TextBoxSetGateway = New System.Windows.Forms.TextBox()
        Me.RadioButtonSetIPDinâmico = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSetIPFixo = New System.Windows.Forms.RadioButton()
        Me.TextBoxSetNomeTerm = New System.Windows.Forms.TextBox()
        Me.RadioButtonSetHabilitaWifi = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSetDesabilitaWifi = New System.Windows.Forms.RadioButton()
        Me.TextBoxSetSSID = New System.Windows.Forms.TextBox()
        Me.ComboBoxSetTipoCripto = New System.Windows.Forms.ComboBox()
        Me.TextBoxSetSenha = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabelSetServerIP = New System.Windows.Forms.Label()
        Me.LabelSetTerminalIP = New System.Windows.Forms.Label()
        Me.LabelSetMask = New System.Windows.Forms.Label()
        Me.LabelSetGateway = New System.Windows.Forms.Label()
        Me.LabelSetTipoIP = New System.Windows.Forms.Label()
        Me.LabelSetNomeTerm = New System.Windows.Forms.Label()
        Me.LabelSetHabilitaWifi = New System.Windows.Forms.Label()
        Me.LabelSetSSID = New System.Windows.Forms.Label()
        Me.LabelSetTipoCripto = New System.Windows.Forms.Label()
        Me.LabelSetSenha = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBoxSetConfig = New System.Windows.Forms.ComboBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ButtonGif = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBoxGifTempo = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBoxGifLoops = New System.Windows.Forms.TextBox()
        Me.ButtonGifGetImagem = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBoxGifIndice = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBoxGifFileName = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TextBoxAudioFileName = New System.Windows.Forms.TextBox()
        Me.TextBoxAudioVolume = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.ButtonAudioGetFile = New System.Windows.Forms.Button()
        Me.TextBoxAudioDuracao = New System.Windows.Forms.TextBox()
        Me.ButtonBarCodeAtualizaTabela = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.TextBoxBarCodeSeparador = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TextBoxBarCodeFile = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.ButtonFileCSV = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBoxComandoLivreHexa = New System.Windows.Forms.TextBox()
        Me.ButtonComandoLivre = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBoxComandoLivre = New System.Windows.Forms.TextBox()
        Me.GroupBoxInfoCliente = New System.Windows.Forms.GroupBox()
        Me.TextBoxInfoCliente = New System.Windows.Forms.TextBox()
        Me.OpenFileDialogGif = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialogAudio = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialogCSV = New System.Windows.Forms.OpenFileDialog()
        Me.TimerComando = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialogFW = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStripClearDebug.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.FlowLayoutPanel8.SuspendLayout()
        Me.FlowLayoutPanel7.SuspendLayout()
        Me.FlowLayoutPanel6.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBoxInfoCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxEnviarLive)
        Me.GroupBox1.Controls.Add(Me.ButtonConectar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxPorta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxServerIP)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 85)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Servidor"
        '
        'CheckBoxEnviarLive
        '
        Me.CheckBoxEnviarLive.AutoSize = True
        Me.CheckBoxEnviarLive.Checked = True
        Me.CheckBoxEnviarLive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxEnviarLive.Location = New System.Drawing.Point(21, 54)
        Me.CheckBoxEnviarLive.Name = "CheckBoxEnviarLive"
        Me.CheckBoxEnviarLive.Size = New System.Drawing.Size(157, 17)
        Me.CheckBoxEnviarLive.TabIndex = 5
        Me.CheckBoxEnviarLive.Text = "Enviar Live a cada 10s"
        Me.CheckBoxEnviarLive.UseVisualStyleBackColor = True
        '
        'ButtonConectar
        '
        Me.ButtonConectar.Location = New System.Drawing.Point(313, 20)
        Me.ButtonConectar.Name = "ButtonConectar"
        Me.ButtonConectar.Size = New System.Drawing.Size(75, 46)
        Me.ButtonConectar.TabIndex = 3
        Me.ButtonConectar.Text = "Iniciar"
        Me.ButtonConectar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(203, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Porta"
        '
        'TextBoxPorta
        '
        Me.TextBoxPorta.Location = New System.Drawing.Point(249, 24)
        Me.TextBoxPorta.Name = "TextBoxPorta"
        Me.TextBoxPorta.Size = New System.Drawing.Size(46, 20)
        Me.TextBoxPorta.TabIndex = 4
        Me.TextBoxPorta.Text = "6500"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Endereço"
        '
        'TextBoxServerIP
        '
        Me.TextBoxServerIP.Location = New System.Drawing.Point(88, 24)
        Me.TextBoxServerIP.Name = "TextBoxServerIP"
        Me.TextBoxServerIP.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxServerIP.TabIndex = 2
        Me.TextBoxServerIP.Text = "192.168.0.55"
        '
        'TextBoxDebug
        '
        Me.TextBoxDebug.ContextMenuStrip = Me.ContextMenuStripClearDebug
        Me.TextBoxDebug.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDebug.Location = New System.Drawing.Point(12, 372)
        Me.TextBoxDebug.Multiline = True
        Me.TextBoxDebug.Name = "TextBoxDebug"
        Me.TextBoxDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxDebug.Size = New System.Drawing.Size(776, 216)
        Me.TextBoxDebug.TabIndex = 1
        '
        'ContextMenuStripClearDebug
        '
        Me.ContextMenuStripClearDebug.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStripClearDebug.Name = "ContextMenuStripClearDebug"
        Me.ContextMenuStripClearDebug.Size = New System.Drawing.Size(112, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem1.Text = "Limpar"
        '
        'TimerClientConnected
        '
        Me.TimerClientConnected.Interval = 1000
        '
        'TimerLive
        '
        Me.TimerLive.Interval = 9800
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 103)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 261)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.ButtonReset)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(768, 235)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Geral"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TextBoxFW)
        Me.GroupBox7.Controls.Add(Me.Label22)
        Me.GroupBox7.Controls.Add(Me.ButtonGetFW)
        Me.GroupBox7.Controls.Add(Me.ButtonSendFW)
        Me.GroupBox7.Location = New System.Drawing.Point(321, 8)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(441, 66)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Atualizar FW"
        '
        'TextBoxFW
        '
        Me.TextBoxFW.Location = New System.Drawing.Point(62, 29)
        Me.TextBoxFW.Name = "TextBoxFW"
        Me.TextBoxFW.Size = New System.Drawing.Size(259, 20)
        Me.TextBoxFW.TabIndex = 44
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 13)
        Me.Label22.TabIndex = 46
        Me.Label22.Text = "Arquivo"
        '
        'ButtonGetFW
        '
        Me.ButtonGetFW.Location = New System.Drawing.Point(327, 27)
        Me.ButtonGetFW.Name = "ButtonGetFW"
        Me.ButtonGetFW.Size = New System.Drawing.Size(27, 23)
        Me.ButtonGetFW.TabIndex = 45
        Me.ButtonGetFW.Text = "..."
        Me.ButtonGetFW.UseVisualStyleBackColor = True
        '
        'ButtonSendFW
        '
        Me.ButtonSendFW.Location = New System.Drawing.Point(360, 26)
        Me.ButtonSendFW.Name = "ButtonSendFW"
        Me.ButtonSendFW.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSendFW.TabIndex = 40
        Me.ButtonSendFW.Text = "Enviar"
        Me.ButtonSendFW.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ButtonMesg)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.TextBoxMesgTempo)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.TextBoxMesgLinha2)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.TextBoxMesgLinha1)
        Me.GroupBox4.Location = New System.Drawing.Point(109, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(180, 141)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "mesg"
        '
        'ButtonMesg
        '
        Me.ButtonMesg.Location = New System.Drawing.Point(92, 105)
        Me.ButtonMesg.Name = "ButtonMesg"
        Me.ButtonMesg.Size = New System.Drawing.Size(75, 23)
        Me.ButtonMesg.TabIndex = 38
        Me.ButtonMesg.Text = "Enviar"
        Me.ButtonMesg.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(13, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(115, 13)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Tempo Exibição (s)"
        '
        'TextBoxMesgTempo
        '
        Me.TextBoxMesgTempo.Location = New System.Drawing.Point(135, 73)
        Me.TextBoxMesgTempo.Name = "TextBoxMesgTempo"
        Me.TextBoxMesgTempo.Size = New System.Drawing.Size(32, 20)
        Me.TextBoxMesgTempo.TabIndex = 37
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(13, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Linha2"
        '
        'TextBoxMesgLinha2
        '
        Me.TextBoxMesgLinha2.Location = New System.Drawing.Point(67, 47)
        Me.TextBoxMesgLinha2.Name = "TextBoxMesgLinha2"
        Me.TextBoxMesgLinha2.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMesgLinha2.TabIndex = 35
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Linha1"
        '
        'TextBoxMesgLinha1
        '
        Me.TextBoxMesgLinha1.Location = New System.Drawing.Point(67, 21)
        Me.TextBoxMesgLinha1.Name = "TextBoxMesgLinha1"
        Me.TextBoxMesgLinha1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMesgLinha1.TabIndex = 33
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonCheckLive)
        Me.GroupBox3.Controls.Add(Me.ButtonAlwaysLive)
        Me.GroupBox3.Location = New System.Drawing.Point(582, 83)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(180, 56)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Live"
        '
        'ButtonCheckLive
        '
        Me.ButtonCheckLive.Location = New System.Drawing.Point(98, 19)
        Me.ButtonCheckLive.Name = "ButtonCheckLive"
        Me.ButtonCheckLive.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCheckLive.TabIndex = 4
        Me.ButtonCheckLive.Text = "checklive"
        Me.ButtonCheckLive.UseVisualStyleBackColor = True
        '
        'ButtonAlwaysLive
        '
        Me.ButtonAlwaysLive.Location = New System.Drawing.Point(17, 19)
        Me.ButtonAlwaysLive.Name = "ButtonAlwaysLive"
        Me.ButtonAlwaysLive.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAlwaysLive.TabIndex = 3
        Me.ButtonAlwaysLive.Text = "Alwayslive"
        Me.ButtonAlwaysLive.UseVisualStyleBackColor = True
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(6, 6)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(75, 23)
        Me.ButtonReset.TabIndex = 2
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxGetMAC)
        Me.GroupBox2.Controls.Add(Me.ButtonGetMAC)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(321, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 56)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MAC Address"
        '
        'TextBoxGetMAC
        '
        Me.TextBoxGetMAC.Location = New System.Drawing.Point(6, 20)
        Me.TextBoxGetMAC.Name = "TextBoxGetMAC"
        Me.TextBoxGetMAC.Size = New System.Drawing.Size(115, 20)
        Me.TextBoxGetMAC.TabIndex = 2
        '
        'ButtonGetMAC
        '
        Me.ButtonGetMAC.Location = New System.Drawing.Point(127, 17)
        Me.ButtonGetMAC.Name = "ButtonGetMAC"
        Me.ButtonGetMAC.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGetMAC.TabIndex = 2
        Me.ButtonGetMAC.Text = "Get"
        Me.ButtonGetMAC.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.ButtonGetConfig)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.ComboBoxGetConfig)
        Me.TabPage2.Controls.Add(Me.FlowLayoutPanel8)
        Me.TabPage2.Controls.Add(Me.FlowLayoutPanel7)
        Me.TabPage2.Controls.Add(Me.FlowLayoutPanel6)
        Me.TabPage2.Controls.Add(Me.FlowLayoutPanel5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(768, 235)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ler Config de Rede"
        '
        'ButtonGetConfig
        '
        Me.ButtonGetConfig.Location = New System.Drawing.Point(219, 16)
        Me.ButtonGetConfig.Name = "ButtonGetConfig"
        Me.ButtonGetConfig.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGetConfig.TabIndex = 44
        Me.ButtonGetConfig.Text = "Enviar"
        Me.ButtonGetConfig.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Comando"
        '
        'ComboBoxGetConfig
        '
        Me.ComboBoxGetConfig.FormattingEnabled = True
        Me.ComboBoxGetConfig.Location = New System.Drawing.Point(84, 18)
        Me.ComboBoxGetConfig.Name = "ComboBoxGetConfig"
        Me.ComboBoxGetConfig.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxGetConfig.TabIndex = 42
        '
        'FlowLayoutPanel8
        '
        Me.FlowLayoutPanel8.Controls.Add(Me.TextBoxGetLinha1)
        Me.FlowLayoutPanel8.Controls.Add(Me.TextBoxGetLinha2)
        Me.FlowLayoutPanel8.Controls.Add(Me.TextBoxGetLinha3)
        Me.FlowLayoutPanel8.Controls.Add(Me.TextBoxGetLinha4)
        Me.FlowLayoutPanel8.Controls.Add(Me.TextBoxGetTempoExibicao)
        Me.FlowLayoutPanel8.Location = New System.Drawing.Point(461, 43)
        Me.FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        Me.FlowLayoutPanel8.Size = New System.Drawing.Size(119, 162)
        Me.FlowLayoutPanel8.TabIndex = 41
        '
        'TextBoxGetLinha1
        '
        Me.TextBoxGetLinha1.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxGetLinha1.Name = "TextBoxGetLinha1"
        Me.TextBoxGetLinha1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxGetLinha1.TabIndex = 23
        '
        'TextBoxGetLinha2
        '
        Me.TextBoxGetLinha2.Location = New System.Drawing.Point(3, 29)
        Me.TextBoxGetLinha2.Name = "TextBoxGetLinha2"
        Me.TextBoxGetLinha2.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxGetLinha2.TabIndex = 21
        '
        'TextBoxGetLinha3
        '
        Me.TextBoxGetLinha3.Location = New System.Drawing.Point(3, 55)
        Me.TextBoxGetLinha3.Name = "TextBoxGetLinha3"
        Me.TextBoxGetLinha3.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxGetLinha3.TabIndex = 25
        '
        'TextBoxGetLinha4
        '
        Me.TextBoxGetLinha4.Location = New System.Drawing.Point(3, 81)
        Me.TextBoxGetLinha4.Name = "TextBoxGetLinha4"
        Me.TextBoxGetLinha4.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxGetLinha4.TabIndex = 27
        '
        'TextBoxGetTempoExibicao
        '
        Me.TextBoxGetTempoExibicao.Location = New System.Drawing.Point(3, 107)
        Me.TextBoxGetTempoExibicao.Name = "TextBoxGetTempoExibicao"
        Me.TextBoxGetTempoExibicao.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxGetTempoExibicao.TabIndex = 31
        '
        'FlowLayoutPanel7
        '
        Me.FlowLayoutPanel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel7.Controls.Add(Me.LabelGetLinha1)
        Me.FlowLayoutPanel7.Controls.Add(Me.LabelGetLinha2)
        Me.FlowLayoutPanel7.Controls.Add(Me.LabelGetLinha3)
        Me.FlowLayoutPanel7.Controls.Add(Me.LabelGetLinha4)
        Me.FlowLayoutPanel7.Controls.Add(Me.LabelGetTempoExibicao)
        Me.FlowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(324, 45)
        Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        Me.FlowLayoutPanel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel7.Size = New System.Drawing.Size(131, 160)
        Me.FlowLayoutPanel7.TabIndex = 40
        '
        'LabelGetLinha1
        '
        Me.LabelGetLinha1.AutoSize = True
        Me.LabelGetLinha1.Location = New System.Drawing.Point(83, 0)
        Me.LabelGetLinha1.Name = "LabelGetLinha1"
        Me.LabelGetLinha1.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelGetLinha1.Size = New System.Drawing.Size(45, 26)
        Me.LabelGetLinha1.TabIndex = 36
        Me.LabelGetLinha1.Text = "Linha1"
        '
        'LabelGetLinha2
        '
        Me.LabelGetLinha2.AutoSize = True
        Me.LabelGetLinha2.Location = New System.Drawing.Point(83, 26)
        Me.LabelGetLinha2.Name = "LabelGetLinha2"
        Me.LabelGetLinha2.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelGetLinha2.Size = New System.Drawing.Size(45, 26)
        Me.LabelGetLinha2.TabIndex = 38
        Me.LabelGetLinha2.Text = "Linha2"
        '
        'LabelGetLinha3
        '
        Me.LabelGetLinha3.AutoSize = True
        Me.LabelGetLinha3.Location = New System.Drawing.Point(83, 52)
        Me.LabelGetLinha3.Name = "LabelGetLinha3"
        Me.LabelGetLinha3.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelGetLinha3.Size = New System.Drawing.Size(45, 26)
        Me.LabelGetLinha3.TabIndex = 40
        Me.LabelGetLinha3.Text = "Linha3"
        '
        'LabelGetLinha4
        '
        Me.LabelGetLinha4.AutoSize = True
        Me.LabelGetLinha4.Location = New System.Drawing.Point(83, 78)
        Me.LabelGetLinha4.Name = "LabelGetLinha4"
        Me.LabelGetLinha4.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelGetLinha4.Size = New System.Drawing.Size(45, 26)
        Me.LabelGetLinha4.TabIndex = 42
        Me.LabelGetLinha4.Text = "Linha4"
        '
        'LabelGetTempoExibicao
        '
        Me.LabelGetTempoExibicao.AutoSize = True
        Me.LabelGetTempoExibicao.Location = New System.Drawing.Point(31, 104)
        Me.LabelGetTempoExibicao.Name = "LabelGetTempoExibicao"
        Me.LabelGetTempoExibicao.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelGetTempoExibicao.Size = New System.Drawing.Size(97, 26)
        Me.LabelGetTempoExibicao.TabIndex = 44
        Me.LabelGetTempoExibicao.Text = "Tempo Exibição"
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.Controls.Add(Me.TextBoxGetServerIP)
        Me.FlowLayoutPanel6.Controls.Add(Me.TextBoxGetTerminalIP)
        Me.FlowLayoutPanel6.Controls.Add(Me.TextBoxGetMask)
        Me.FlowLayoutPanel6.Controls.Add(Me.TextBoxGetGateway)
        Me.FlowLayoutPanel6.Controls.Add(Me.RadioButtonGetDinamico)
        Me.FlowLayoutPanel6.Controls.Add(Me.RadioButtonGetFixo)
        Me.FlowLayoutPanel6.Controls.Add(Me.TextBoxGetNomeTerminal)
        Me.FlowLayoutPanel6.Controls.Add(Me.RadioButtonGetHabilitaWifi)
        Me.FlowLayoutPanel6.Controls.Add(Me.RadioButtonGetDesabilitaWifi)
        Me.FlowLayoutPanel6.Controls.Add(Me.TextBoxGetSSID)
        Me.FlowLayoutPanel6.Controls.Add(Me.ComboBoxGetTipoCripto)
        Me.FlowLayoutPanel6.Controls.Add(Me.TextBoxGetSenha)
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(133, 45)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(185, 262)
        Me.FlowLayoutPanel6.TabIndex = 39
        '
        'TextBoxGetServerIP
        '
        Me.TextBoxGetServerIP.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxGetServerIP.Name = "TextBoxGetServerIP"
        Me.TextBoxGetServerIP.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxGetServerIP.TabIndex = 15
        '
        'TextBoxGetTerminalIP
        '
        Me.TextBoxGetTerminalIP.Location = New System.Drawing.Point(3, 29)
        Me.TextBoxGetTerminalIP.Name = "TextBoxGetTerminalIP"
        Me.TextBoxGetTerminalIP.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxGetTerminalIP.TabIndex = 17
        '
        'TextBoxGetMask
        '
        Me.TextBoxGetMask.Location = New System.Drawing.Point(3, 55)
        Me.TextBoxGetMask.Name = "TextBoxGetMask"
        Me.TextBoxGetMask.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxGetMask.TabIndex = 19
        '
        'TextBoxGetGateway
        '
        Me.TextBoxGetGateway.Location = New System.Drawing.Point(3, 81)
        Me.TextBoxGetGateway.Name = "TextBoxGetGateway"
        Me.TextBoxGetGateway.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxGetGateway.TabIndex = 29
        '
        'RadioButtonGetDinamico
        '
        Me.RadioButtonGetDinamico.AutoSize = True
        Me.RadioButtonGetDinamico.Location = New System.Drawing.Point(3, 107)
        Me.RadioButtonGetDinamico.Name = "RadioButtonGetDinamico"
        Me.RadioButtonGetDinamico.Size = New System.Drawing.Size(77, 17)
        Me.RadioButtonGetDinamico.TabIndex = 50
        Me.RadioButtonGetDinamico.TabStop = True
        Me.RadioButtonGetDinamico.Text = "Dinâmico"
        Me.RadioButtonGetDinamico.UseVisualStyleBackColor = True
        '
        'RadioButtonGetFixo
        '
        Me.RadioButtonGetFixo.AutoSize = True
        Me.RadioButtonGetFixo.Location = New System.Drawing.Point(86, 107)
        Me.RadioButtonGetFixo.Name = "RadioButtonGetFixo"
        Me.RadioButtonGetFixo.Size = New System.Drawing.Size(48, 17)
        Me.RadioButtonGetFixo.TabIndex = 51
        Me.RadioButtonGetFixo.TabStop = True
        Me.RadioButtonGetFixo.Text = "Fixo"
        Me.RadioButtonGetFixo.UseVisualStyleBackColor = True
        '
        'TextBoxGetNomeTerminal
        '
        Me.TextBoxGetNomeTerminal.Location = New System.Drawing.Point(3, 130)
        Me.TextBoxGetNomeTerminal.Name = "TextBoxGetNomeTerminal"
        Me.TextBoxGetNomeTerminal.Size = New System.Drawing.Size(172, 20)
        Me.TextBoxGetNomeTerminal.TabIndex = 35
        '
        'RadioButtonGetHabilitaWifi
        '
        Me.RadioButtonGetHabilitaWifi.AutoSize = True
        Me.RadioButtonGetHabilitaWifi.Location = New System.Drawing.Point(3, 156)
        Me.RadioButtonGetHabilitaWifi.Name = "RadioButtonGetHabilitaWifi"
        Me.RadioButtonGetHabilitaWifi.Size = New System.Drawing.Size(68, 17)
        Me.RadioButtonGetHabilitaWifi.TabIndex = 58
        Me.RadioButtonGetHabilitaWifi.TabStop = True
        Me.RadioButtonGetHabilitaWifi.Text = "Habilita"
        Me.RadioButtonGetHabilitaWifi.UseVisualStyleBackColor = True
        '
        'RadioButtonGetDesabilitaWifi
        '
        Me.RadioButtonGetDesabilitaWifi.AutoSize = True
        Me.RadioButtonGetDesabilitaWifi.Location = New System.Drawing.Point(77, 156)
        Me.RadioButtonGetDesabilitaWifi.Name = "RadioButtonGetDesabilitaWifi"
        Me.RadioButtonGetDesabilitaWifi.Size = New System.Drawing.Size(81, 17)
        Me.RadioButtonGetDesabilitaWifi.TabIndex = 59
        Me.RadioButtonGetDesabilitaWifi.TabStop = True
        Me.RadioButtonGetDesabilitaWifi.Text = "Desabilita"
        Me.RadioButtonGetDesabilitaWifi.UseVisualStyleBackColor = True
        '
        'TextBoxGetSSID
        '
        Me.TextBoxGetSSID.Location = New System.Drawing.Point(3, 179)
        Me.TextBoxGetSSID.Name = "TextBoxGetSSID"
        Me.TextBoxGetSSID.Size = New System.Drawing.Size(172, 20)
        Me.TextBoxGetSSID.TabIndex = 55
        '
        'ComboBoxGetTipoCripto
        '
        Me.ComboBoxGetTipoCripto.FormattingEnabled = True
        Me.ComboBoxGetTipoCripto.Items.AddRange(New Object() {"Nenhum", "WEP64", "WEP128", "WPA-PSK", "WPA2-PSK", "WPA-Mixed"})
        Me.ComboBoxGetTipoCripto.Location = New System.Drawing.Point(3, 205)
        Me.ComboBoxGetTipoCripto.Name = "ComboBoxGetTipoCripto"
        Me.ComboBoxGetTipoCripto.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxGetTipoCripto.TabIndex = 56
        '
        'TextBoxGetSenha
        '
        Me.TextBoxGetSenha.Location = New System.Drawing.Point(3, 232)
        Me.TextBoxGetSenha.Name = "TextBoxGetSenha"
        Me.TextBoxGetSenha.Size = New System.Drawing.Size(172, 20)
        Me.TextBoxGetSenha.TabIndex = 57
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel5.Controls.Add(Me.LabelGetServerIP)
        Me.FlowLayoutPanel5.Controls.Add(Me.LabelGetTerminalIP)
        Me.FlowLayoutPanel5.Controls.Add(Me.LabelGetMask)
        Me.FlowLayoutPanel5.Controls.Add(Me.LabelGetGateway)
        Me.FlowLayoutPanel5.Controls.Add(Me.LabelGetTipoIP)
        Me.FlowLayoutPanel5.Controls.Add(Me.LabelGetNomeTerminal)
        Me.FlowLayoutPanel5.Controls.Add(Me.LabelGetHabilitaWifi)
        Me.FlowLayoutPanel5.Controls.Add(Me.LabelGetSSID)
        Me.FlowLayoutPanel5.Controls.Add(Me.LabelGetTipoCripto)
        Me.FlowLayoutPanel5.Controls.Add(Me.LabelGetSenha)
        Me.FlowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(14, 45)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(116, 262)
        Me.FlowLayoutPanel5.TabIndex = 38
        '
        'LabelGetServerIP
        '
        Me.LabelGetServerIP.AutoSize = True
        Me.LabelGetServerIP.Location = New System.Drawing.Point(25, 0)
        Me.LabelGetServerIP.Name = "LabelGetServerIP"
        Me.LabelGetServerIP.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelGetServerIP.Size = New System.Drawing.Size(88, 26)
        Me.LabelGetServerIP.TabIndex = 36
        Me.LabelGetServerIP.Text = "IP do Servidor"
        '
        'LabelGetTerminalIP
        '
        Me.LabelGetTerminalIP.AutoSize = True
        Me.LabelGetTerminalIP.Location = New System.Drawing.Point(24, 26)
        Me.LabelGetTerminalIP.Name = "LabelGetTerminalIP"
        Me.LabelGetTerminalIP.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelGetTerminalIP.Size = New System.Drawing.Size(89, 26)
        Me.LabelGetTerminalIP.TabIndex = 38
        Me.LabelGetTerminalIP.Text = "IP do Terminal"
        '
        'LabelGetMask
        '
        Me.LabelGetMask.AutoSize = True
        Me.LabelGetMask.Location = New System.Drawing.Point(6, 52)
        Me.LabelGetMask.Name = "LabelGetMask"
        Me.LabelGetMask.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelGetMask.Size = New System.Drawing.Size(107, 26)
        Me.LabelGetMask.TabIndex = 40
        Me.LabelGetMask.Text = "Máscara de Rede"
        '
        'LabelGetGateway
        '
        Me.LabelGetGateway.AutoSize = True
        Me.LabelGetGateway.Location = New System.Drawing.Point(57, 78)
        Me.LabelGetGateway.Name = "LabelGetGateway"
        Me.LabelGetGateway.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelGetGateway.Size = New System.Drawing.Size(56, 26)
        Me.LabelGetGateway.TabIndex = 42
        Me.LabelGetGateway.Text = "Gateway"
        '
        'LabelGetTipoIP
        '
        Me.LabelGetTipoIP.AutoSize = True
        Me.LabelGetTipoIP.Location = New System.Drawing.Point(65, 104)
        Me.LabelGetTipoIP.Name = "LabelGetTipoIP"
        Me.LabelGetTipoIP.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelGetTipoIP.Size = New System.Drawing.Size(48, 26)
        Me.LabelGetTipoIP.TabIndex = 44
        Me.LabelGetTipoIP.Text = "Tipo IP"
        '
        'LabelGetNomeTerminal
        '
        Me.LabelGetNomeTerminal.AutoSize = True
        Me.LabelGetNomeTerminal.Location = New System.Drawing.Point(4, 130)
        Me.LabelGetNomeTerminal.Name = "LabelGetNomeTerminal"
        Me.LabelGetNomeTerminal.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelGetNomeTerminal.Size = New System.Drawing.Size(109, 26)
        Me.LabelGetNomeTerminal.TabIndex = 46
        Me.LabelGetNomeTerminal.Text = "Nome do Terminal"
        '
        'LabelGetHabilitaWifi
        '
        Me.LabelGetHabilitaWifi.AutoSize = True
        Me.LabelGetHabilitaWifi.Location = New System.Drawing.Point(37, 156)
        Me.LabelGetHabilitaWifi.Name = "LabelGetHabilitaWifi"
        Me.LabelGetHabilitaWifi.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelGetHabilitaWifi.Size = New System.Drawing.Size(76, 26)
        Me.LabelGetHabilitaWifi.TabIndex = 54
        Me.LabelGetHabilitaWifi.Text = "Habilita Wifi"
        '
        'LabelGetSSID
        '
        Me.LabelGetSSID.AutoSize = True
        Me.LabelGetSSID.Location = New System.Drawing.Point(77, 182)
        Me.LabelGetSSID.Name = "LabelGetSSID"
        Me.LabelGetSSID.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelGetSSID.Size = New System.Drawing.Size(36, 26)
        Me.LabelGetSSID.TabIndex = 51
        Me.LabelGetSSID.Text = "SSID"
        '
        'LabelGetTipoCripto
        '
        Me.LabelGetTipoCripto.AutoSize = True
        Me.LabelGetTipoCripto.Location = New System.Drawing.Point(41, 208)
        Me.LabelGetTipoCripto.Name = "LabelGetTipoCripto"
        Me.LabelGetTipoCripto.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelGetTipoCripto.Size = New System.Drawing.Size(72, 26)
        Me.LabelGetTipoCripto.TabIndex = 52
        Me.LabelGetTipoCripto.Text = "Criptografia"
        '
        'LabelGetSenha
        '
        Me.LabelGetSenha.AutoSize = True
        Me.LabelGetSenha.Location = New System.Drawing.Point(70, 234)
        Me.LabelGetSenha.Name = "LabelGetSenha"
        Me.LabelGetSenha.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelGetSenha.Size = New System.Drawing.Size(43, 26)
        Me.LabelGetSenha.TabIndex = 53
        Me.LabelGetSenha.Text = "Senha"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.ButtonSetConfig)
        Me.TabPage3.Controls.Add(Me.FlowLayoutPanel3)
        Me.TabPage3.Controls.Add(Me.FlowLayoutPanel4)
        Me.TabPage3.Controls.Add(Me.FlowLayoutPanel2)
        Me.TabPage3.Controls.Add(Me.FlowLayoutPanel1)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.ComboBoxSetConfig)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(768, 235)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Setar Config de Rede"
        '
        'ButtonSetConfig
        '
        Me.ButtonSetConfig.Location = New System.Drawing.Point(214, 12)
        Me.ButtonSetConfig.Name = "ButtonSetConfig"
        Me.ButtonSetConfig.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSetConfig.TabIndex = 10
        Me.ButtonSetConfig.Text = "Enviar"
        Me.ButtonSetConfig.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBoxSetLinha1)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBoxSetLinha2)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBoxSetLinha3)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBoxSetLinha4)
        Me.FlowLayoutPanel3.Controls.Add(Me.TextBoxSetTempoExibicao)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(496, 62)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(185, 160)
        Me.FlowLayoutPanel3.TabIndex = 8
        '
        'TextBoxSetLinha1
        '
        Me.TextBoxSetLinha1.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxSetLinha1.Name = "TextBoxSetLinha1"
        Me.TextBoxSetLinha1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSetLinha1.TabIndex = 39
        '
        'TextBoxSetLinha2
        '
        Me.TextBoxSetLinha2.Location = New System.Drawing.Point(3, 29)
        Me.TextBoxSetLinha2.Name = "TextBoxSetLinha2"
        Me.TextBoxSetLinha2.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSetLinha2.TabIndex = 37
        '
        'TextBoxSetLinha3
        '
        Me.TextBoxSetLinha3.Location = New System.Drawing.Point(3, 55)
        Me.TextBoxSetLinha3.Name = "TextBoxSetLinha3"
        Me.TextBoxSetLinha3.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSetLinha3.TabIndex = 41
        '
        'TextBoxSetLinha4
        '
        Me.TextBoxSetLinha4.Location = New System.Drawing.Point(3, 81)
        Me.TextBoxSetLinha4.Name = "TextBoxSetLinha4"
        Me.TextBoxSetLinha4.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSetLinha4.TabIndex = 43
        '
        'TextBoxSetTempoExibicao
        '
        Me.TextBoxSetTempoExibicao.Location = New System.Drawing.Point(3, 107)
        Me.TextBoxSetTempoExibicao.Name = "TextBoxSetTempoExibicao"
        Me.TextBoxSetTempoExibicao.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSetTempoExibicao.TabIndex = 45
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel4.Controls.Add(Me.LabelSetLinha1)
        Me.FlowLayoutPanel4.Controls.Add(Me.LabelSetLinha2)
        Me.FlowLayoutPanel4.Controls.Add(Me.LabelSetLinha3)
        Me.FlowLayoutPanel4.Controls.Add(Me.LabelSetLinha4)
        Me.FlowLayoutPanel4.Controls.Add(Me.LabelSetTempoExibicao)
        Me.FlowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(312, 62)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(178, 160)
        Me.FlowLayoutPanel4.TabIndex = 7
        '
        'LabelSetLinha1
        '
        Me.LabelSetLinha1.AutoSize = True
        Me.LabelSetLinha1.Location = New System.Drawing.Point(130, 0)
        Me.LabelSetLinha1.Name = "LabelSetLinha1"
        Me.LabelSetLinha1.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelSetLinha1.Size = New System.Drawing.Size(45, 26)
        Me.LabelSetLinha1.TabIndex = 36
        Me.LabelSetLinha1.Text = "Linha1"
        '
        'LabelSetLinha2
        '
        Me.LabelSetLinha2.AutoSize = True
        Me.LabelSetLinha2.Location = New System.Drawing.Point(130, 26)
        Me.LabelSetLinha2.Name = "LabelSetLinha2"
        Me.LabelSetLinha2.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelSetLinha2.Size = New System.Drawing.Size(45, 26)
        Me.LabelSetLinha2.TabIndex = 38
        Me.LabelSetLinha2.Text = "Linha2"
        '
        'LabelSetLinha3
        '
        Me.LabelSetLinha3.AutoSize = True
        Me.LabelSetLinha3.Location = New System.Drawing.Point(130, 52)
        Me.LabelSetLinha3.Name = "LabelSetLinha3"
        Me.LabelSetLinha3.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelSetLinha3.Size = New System.Drawing.Size(45, 26)
        Me.LabelSetLinha3.TabIndex = 40
        Me.LabelSetLinha3.Text = "Linha3"
        '
        'LabelSetLinha4
        '
        Me.LabelSetLinha4.AutoSize = True
        Me.LabelSetLinha4.Location = New System.Drawing.Point(130, 78)
        Me.LabelSetLinha4.Name = "LabelSetLinha4"
        Me.LabelSetLinha4.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelSetLinha4.Size = New System.Drawing.Size(45, 26)
        Me.LabelSetLinha4.TabIndex = 42
        Me.LabelSetLinha4.Text = "Linha4"
        '
        'LabelSetTempoExibicao
        '
        Me.LabelSetTempoExibicao.AutoSize = True
        Me.LabelSetTempoExibicao.Location = New System.Drawing.Point(78, 104)
        Me.LabelSetTempoExibicao.Name = "LabelSetTempoExibicao"
        Me.LabelSetTempoExibicao.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelSetTempoExibicao.Size = New System.Drawing.Size(97, 26)
        Me.LabelSetTempoExibicao.TabIndex = 44
        Me.LabelSetTempoExibicao.Text = "Tempo Exibição"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBoxSetServerIP)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBoxSetTerminalIP)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBoxSetMask)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBoxSetGateway)
        Me.FlowLayoutPanel2.Controls.Add(Me.RadioButtonSetIPDinâmico)
        Me.FlowLayoutPanel2.Controls.Add(Me.RadioButtonSetIPFixo)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBoxSetNomeTerm)
        Me.FlowLayoutPanel2.Controls.Add(Me.RadioButtonSetHabilitaWifi)
        Me.FlowLayoutPanel2.Controls.Add(Me.RadioButtonSetDesabilitaWifi)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBoxSetSSID)
        Me.FlowLayoutPanel2.Controls.Add(Me.ComboBoxSetTipoCripto)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBoxSetSenha)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(121, 62)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(185, 265)
        Me.FlowLayoutPanel2.TabIndex = 6
        '
        'TextBoxSetServerIP
        '
        Me.TextBoxSetServerIP.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxSetServerIP.Name = "TextBoxSetServerIP"
        Me.TextBoxSetServerIP.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSetServerIP.TabIndex = 37
        '
        'TextBoxSetTerminalIP
        '
        Me.TextBoxSetTerminalIP.Location = New System.Drawing.Point(3, 29)
        Me.TextBoxSetTerminalIP.Name = "TextBoxSetTerminalIP"
        Me.TextBoxSetTerminalIP.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSetTerminalIP.TabIndex = 39
        '
        'TextBoxSetMask
        '
        Me.TextBoxSetMask.Location = New System.Drawing.Point(3, 55)
        Me.TextBoxSetMask.Name = "TextBoxSetMask"
        Me.TextBoxSetMask.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSetMask.TabIndex = 41
        '
        'TextBoxSetGateway
        '
        Me.TextBoxSetGateway.Location = New System.Drawing.Point(3, 81)
        Me.TextBoxSetGateway.Name = "TextBoxSetGateway"
        Me.TextBoxSetGateway.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSetGateway.TabIndex = 43
        '
        'RadioButtonSetIPDinâmico
        '
        Me.RadioButtonSetIPDinâmico.AutoSize = True
        Me.RadioButtonSetIPDinâmico.Location = New System.Drawing.Point(3, 107)
        Me.RadioButtonSetIPDinâmico.Name = "RadioButtonSetIPDinâmico"
        Me.RadioButtonSetIPDinâmico.Size = New System.Drawing.Size(77, 17)
        Me.RadioButtonSetIPDinâmico.TabIndex = 48
        Me.RadioButtonSetIPDinâmico.TabStop = True
        Me.RadioButtonSetIPDinâmico.Text = "Dinâmico"
        Me.RadioButtonSetIPDinâmico.UseVisualStyleBackColor = True
        '
        'RadioButtonSetIPFixo
        '
        Me.RadioButtonSetIPFixo.AutoSize = True
        Me.RadioButtonSetIPFixo.Location = New System.Drawing.Point(86, 107)
        Me.RadioButtonSetIPFixo.Name = "RadioButtonSetIPFixo"
        Me.RadioButtonSetIPFixo.Size = New System.Drawing.Size(48, 17)
        Me.RadioButtonSetIPFixo.TabIndex = 49
        Me.RadioButtonSetIPFixo.TabStop = True
        Me.RadioButtonSetIPFixo.Text = "Fixo"
        Me.RadioButtonSetIPFixo.UseVisualStyleBackColor = True
        '
        'TextBoxSetNomeTerm
        '
        Me.TextBoxSetNomeTerm.Location = New System.Drawing.Point(3, 130)
        Me.TextBoxSetNomeTerm.Name = "TextBoxSetNomeTerm"
        Me.TextBoxSetNomeTerm.Size = New System.Drawing.Size(172, 20)
        Me.TextBoxSetNomeTerm.TabIndex = 47
        '
        'RadioButtonSetHabilitaWifi
        '
        Me.RadioButtonSetHabilitaWifi.AutoSize = True
        Me.RadioButtonSetHabilitaWifi.Location = New System.Drawing.Point(3, 156)
        Me.RadioButtonSetHabilitaWifi.Name = "RadioButtonSetHabilitaWifi"
        Me.RadioButtonSetHabilitaWifi.Size = New System.Drawing.Size(68, 17)
        Me.RadioButtonSetHabilitaWifi.TabIndex = 53
        Me.RadioButtonSetHabilitaWifi.TabStop = True
        Me.RadioButtonSetHabilitaWifi.Text = "Habilita"
        Me.RadioButtonSetHabilitaWifi.UseVisualStyleBackColor = True
        '
        'RadioButtonSetDesabilitaWifi
        '
        Me.RadioButtonSetDesabilitaWifi.AutoSize = True
        Me.RadioButtonSetDesabilitaWifi.Location = New System.Drawing.Point(77, 156)
        Me.RadioButtonSetDesabilitaWifi.Name = "RadioButtonSetDesabilitaWifi"
        Me.RadioButtonSetDesabilitaWifi.Size = New System.Drawing.Size(81, 17)
        Me.RadioButtonSetDesabilitaWifi.TabIndex = 54
        Me.RadioButtonSetDesabilitaWifi.TabStop = True
        Me.RadioButtonSetDesabilitaWifi.Text = "Desabilita"
        Me.RadioButtonSetDesabilitaWifi.UseVisualStyleBackColor = True
        '
        'TextBoxSetSSID
        '
        Me.TextBoxSetSSID.Location = New System.Drawing.Point(3, 179)
        Me.TextBoxSetSSID.Name = "TextBoxSetSSID"
        Me.TextBoxSetSSID.Size = New System.Drawing.Size(172, 20)
        Me.TextBoxSetSSID.TabIndex = 50
        '
        'ComboBoxSetTipoCripto
        '
        Me.ComboBoxSetTipoCripto.FormattingEnabled = True
        Me.ComboBoxSetTipoCripto.Items.AddRange(New Object() {"Nenhum", "WEP64", "WEP128", "WPA-PSK", "WPA2-PSK", "WPA-Mixed"})
        Me.ComboBoxSetTipoCripto.Location = New System.Drawing.Point(3, 205)
        Me.ComboBoxSetTipoCripto.Name = "ComboBoxSetTipoCripto"
        Me.ComboBoxSetTipoCripto.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxSetTipoCripto.TabIndex = 51
        '
        'TextBoxSetSenha
        '
        Me.TextBoxSetSenha.Location = New System.Drawing.Point(3, 232)
        Me.TextBoxSetSenha.Name = "TextBoxSetSenha"
        Me.TextBoxSetSenha.Size = New System.Drawing.Size(172, 20)
        Me.TextBoxSetSenha.TabIndex = 52
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelSetServerIP)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelSetTerminalIP)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelSetMask)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelSetGateway)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelSetTipoIP)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelSetNomeTerm)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelSetHabilitaWifi)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelSetSSID)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelSetTipoCripto)
        Me.FlowLayoutPanel1.Controls.Add(Me.LabelSetSenha)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 62)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(116, 265)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'LabelSetServerIP
        '
        Me.LabelSetServerIP.AutoSize = True
        Me.LabelSetServerIP.Location = New System.Drawing.Point(25, 0)
        Me.LabelSetServerIP.Name = "LabelSetServerIP"
        Me.LabelSetServerIP.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelSetServerIP.Size = New System.Drawing.Size(88, 26)
        Me.LabelSetServerIP.TabIndex = 36
        Me.LabelSetServerIP.Text = "IP do Servidor"
        '
        'LabelSetTerminalIP
        '
        Me.LabelSetTerminalIP.AutoSize = True
        Me.LabelSetTerminalIP.Location = New System.Drawing.Point(24, 26)
        Me.LabelSetTerminalIP.Name = "LabelSetTerminalIP"
        Me.LabelSetTerminalIP.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelSetTerminalIP.Size = New System.Drawing.Size(89, 26)
        Me.LabelSetTerminalIP.TabIndex = 38
        Me.LabelSetTerminalIP.Text = "IP do Terminal"
        '
        'LabelSetMask
        '
        Me.LabelSetMask.AutoSize = True
        Me.LabelSetMask.Location = New System.Drawing.Point(6, 52)
        Me.LabelSetMask.Name = "LabelSetMask"
        Me.LabelSetMask.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelSetMask.Size = New System.Drawing.Size(107, 26)
        Me.LabelSetMask.TabIndex = 40
        Me.LabelSetMask.Text = "Máscara de Rede"
        '
        'LabelSetGateway
        '
        Me.LabelSetGateway.AutoSize = True
        Me.LabelSetGateway.Location = New System.Drawing.Point(57, 78)
        Me.LabelSetGateway.Name = "LabelSetGateway"
        Me.LabelSetGateway.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelSetGateway.Size = New System.Drawing.Size(56, 26)
        Me.LabelSetGateway.TabIndex = 42
        Me.LabelSetGateway.Text = "Gateway"
        '
        'LabelSetTipoIP
        '
        Me.LabelSetTipoIP.AutoSize = True
        Me.LabelSetTipoIP.Location = New System.Drawing.Point(65, 104)
        Me.LabelSetTipoIP.Name = "LabelSetTipoIP"
        Me.LabelSetTipoIP.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelSetTipoIP.Size = New System.Drawing.Size(48, 26)
        Me.LabelSetTipoIP.TabIndex = 44
        Me.LabelSetTipoIP.Text = "Tipo IP"
        '
        'LabelSetNomeTerm
        '
        Me.LabelSetNomeTerm.AutoSize = True
        Me.LabelSetNomeTerm.Location = New System.Drawing.Point(4, 130)
        Me.LabelSetNomeTerm.Name = "LabelSetNomeTerm"
        Me.LabelSetNomeTerm.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelSetNomeTerm.Size = New System.Drawing.Size(109, 26)
        Me.LabelSetNomeTerm.TabIndex = 46
        Me.LabelSetNomeTerm.Text = "Nome do Terminal"
        '
        'LabelSetHabilitaWifi
        '
        Me.LabelSetHabilitaWifi.AutoSize = True
        Me.LabelSetHabilitaWifi.Location = New System.Drawing.Point(37, 156)
        Me.LabelSetHabilitaWifi.Name = "LabelSetHabilitaWifi"
        Me.LabelSetHabilitaWifi.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelSetHabilitaWifi.Size = New System.Drawing.Size(76, 26)
        Me.LabelSetHabilitaWifi.TabIndex = 50
        Me.LabelSetHabilitaWifi.Text = "Habilita Wifi"
        '
        'LabelSetSSID
        '
        Me.LabelSetSSID.AutoSize = True
        Me.LabelSetSSID.Location = New System.Drawing.Point(77, 182)
        Me.LabelSetSSID.Name = "LabelSetSSID"
        Me.LabelSetSSID.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelSetSSID.Size = New System.Drawing.Size(36, 26)
        Me.LabelSetSSID.TabIndex = 47
        Me.LabelSetSSID.Text = "SSID"
        '
        'LabelSetTipoCripto
        '
        Me.LabelSetTipoCripto.AutoSize = True
        Me.LabelSetTipoCripto.Location = New System.Drawing.Point(41, 208)
        Me.LabelSetTipoCripto.Name = "LabelSetTipoCripto"
        Me.LabelSetTipoCripto.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelSetTipoCripto.Size = New System.Drawing.Size(72, 26)
        Me.LabelSetTipoCripto.TabIndex = 48
        Me.LabelSetTipoCripto.Text = "Criptografia"
        '
        'LabelSetSenha
        '
        Me.LabelSetSenha.AutoSize = True
        Me.LabelSetSenha.Location = New System.Drawing.Point(70, 234)
        Me.LabelSetSenha.Name = "LabelSetSenha"
        Me.LabelSetSenha.Padding = New System.Windows.Forms.Padding(0, 6, 0, 7)
        Me.LabelSetSenha.Size = New System.Drawing.Size(43, 26)
        Me.LabelSetSenha.TabIndex = 49
        Me.LabelSetSenha.Text = "Senha"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Comando"
        '
        'ComboBoxSetConfig
        '
        Me.ComboBoxSetConfig.FormattingEnabled = True
        Me.ComboBoxSetConfig.Location = New System.Drawing.Point(79, 14)
        Me.ComboBoxSetConfig.Name = "ComboBoxSetConfig"
        Me.ComboBoxSetConfig.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxSetConfig.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Controls.Add(Me.GroupBox5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(768, 235)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Gif"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ButtonGif)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.TextBoxGifTempo)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.TextBoxGifLoops)
        Me.GroupBox5.Controls.Add(Me.ButtonGifGetImagem)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.TextBoxGifIndice)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.TextBoxGifFileName)
        Me.GroupBox5.Location = New System.Drawing.Point(17, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(452, 89)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Gif"
        '
        'ButtonGif
        '
        Me.ButtonGif.Location = New System.Drawing.Point(371, 51)
        Me.ButtonGif.Name = "ButtonGif"
        Me.ButtonGif.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGif.TabIndex = 45
        Me.ButtonGif.Text = "Enviar"
        Me.ButtonGif.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(236, 53)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 13)
        Me.Label21.TabIndex = 43
        Me.Label21.Text = "Tempo"
        '
        'TextBoxGifTempo
        '
        Me.TextBoxGifTempo.Location = New System.Drawing.Point(290, 50)
        Me.TextBoxGifTempo.Name = "TextBoxGifTempo"
        Me.TextBoxGifTempo.Size = New System.Drawing.Size(42, 20)
        Me.TextBoxGifTempo.TabIndex = 44
        Me.TextBoxGifTempo.Text = "5"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(125, 53)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 13)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Loops"
        '
        'TextBoxGifLoops
        '
        Me.TextBoxGifLoops.Location = New System.Drawing.Point(179, 50)
        Me.TextBoxGifLoops.Name = "TextBoxGifLoops"
        Me.TextBoxGifLoops.Size = New System.Drawing.Size(42, 20)
        Me.TextBoxGifLoops.TabIndex = 42
        Me.TextBoxGifLoops.Text = "1"
        '
        'ButtonGifGetImagem
        '
        Me.ButtonGifGetImagem.Location = New System.Drawing.Point(421, 22)
        Me.ButtonGifGetImagem.Name = "ButtonGifGetImagem"
        Me.ButtonGifGetImagem.Size = New System.Drawing.Size(27, 23)
        Me.ButtonGifGetImagem.TabIndex = 40
        Me.ButtonGifGetImagem.Text = "..."
        Me.ButtonGifGetImagem.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 53)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 13)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Índice"
        '
        'TextBoxGifIndice
        '
        Me.TextBoxGifIndice.Location = New System.Drawing.Point(67, 50)
        Me.TextBoxGifIndice.Name = "TextBoxGifIndice"
        Me.TextBoxGifIndice.Size = New System.Drawing.Size(42, 20)
        Me.TextBoxGifIndice.TabIndex = 39
        Me.TextBoxGifIndice.Text = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(31, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(27, 13)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "GIF"
        '
        'TextBoxGifFileName
        '
        Me.TextBoxGifFileName.Location = New System.Drawing.Point(67, 24)
        Me.TextBoxGifFileName.Name = "TextBoxGifFileName"
        Me.TextBoxGifFileName.Size = New System.Drawing.Size(348, 20)
        Me.TextBoxGifFileName.TabIndex = 37
        Me.TextBoxGifFileName.Text = "C:\Users\rchinelatto\Downloads\tenor.gif"
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage6.Controls.Add(Me.GroupBox10)
        Me.TabPage6.Controls.Add(Me.ButtonBarCodeAtualizaTabela)
        Me.TabPage6.Controls.Add(Me.DataGridView1)
        Me.TabPage6.Controls.Add(Me.GroupBox9)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(768, 235)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Código de Barras"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Label31)
        Me.GroupBox10.Controls.Add(Me.TextBoxAudioFileName)
        Me.GroupBox10.Controls.Add(Me.TextBoxAudioVolume)
        Me.GroupBox10.Controls.Add(Me.Label32)
        Me.GroupBox10.Controls.Add(Me.Label33)
        Me.GroupBox10.Controls.Add(Me.ButtonAudioGetFile)
        Me.GroupBox10.Controls.Add(Me.TextBoxAudioDuracao)
        Me.GroupBox10.Location = New System.Drawing.Point(17, 108)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(361, 84)
        Me.GroupBox10.TabIndex = 47
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Configurações de Áudio"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(177, 57)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(89, 13)
        Me.Label31.TabIndex = 53
        Me.Label31.Text = "Volume (0 a 3)"
        '
        'TextBoxAudioFileName
        '
        Me.TextBoxAudioFileName.Location = New System.Drawing.Point(54, 19)
        Me.TextBoxAudioFileName.Name = "TextBoxAudioFileName"
        Me.TextBoxAudioFileName.Size = New System.Drawing.Size(261, 20)
        Me.TextBoxAudioFileName.TabIndex = 49
        '
        'TextBoxAudioVolume
        '
        Me.TextBoxAudioVolume.Location = New System.Drawing.Point(272, 54)
        Me.TextBoxAudioVolume.Name = "TextBoxAudioVolume"
        Me.TextBoxAudioVolume.Size = New System.Drawing.Size(42, 20)
        Me.TextBoxAudioVolume.TabIndex = 54
        Me.TextBoxAudioVolume.Text = "3"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(9, 22)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(39, 13)
        Me.Label32.TabIndex = 48
        Me.Label32.Text = "Audio"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(9, 56)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(96, 13)
        Me.Label33.TabIndex = 51
        Me.Label33.Text = "Duração (2 a 7)"
        '
        'ButtonAudioGetFile
        '
        Me.ButtonAudioGetFile.Location = New System.Drawing.Point(328, 17)
        Me.ButtonAudioGetFile.Name = "ButtonAudioGetFile"
        Me.ButtonAudioGetFile.Size = New System.Drawing.Size(27, 23)
        Me.ButtonAudioGetFile.TabIndex = 50
        Me.ButtonAudioGetFile.Text = "..."
        Me.ButtonAudioGetFile.UseVisualStyleBackColor = True
        '
        'TextBoxAudioDuracao
        '
        Me.TextBoxAudioDuracao.Location = New System.Drawing.Point(111, 54)
        Me.TextBoxAudioDuracao.Name = "TextBoxAudioDuracao"
        Me.TextBoxAudioDuracao.Size = New System.Drawing.Size(42, 20)
        Me.TextBoxAudioDuracao.TabIndex = 52
        Me.TextBoxAudioDuracao.Text = "2"
        '
        'ButtonBarCodeAtualizaTabela
        '
        Me.ButtonBarCodeAtualizaTabela.Location = New System.Drawing.Point(264, 214)
        Me.ButtonBarCodeAtualizaTabela.Name = "ButtonBarCodeAtualizaTabela"
        Me.ButtonBarCodeAtualizaTabela.Size = New System.Drawing.Size(114, 23)
        Me.ButtonBarCodeAtualizaTabela.TabIndex = 46
        Me.ButtonBarCodeAtualizaTabela.Text = "Atualiza Tabela"
        Me.ButtonBarCodeAtualizaTabela.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(384, 14)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(378, 223)
        Me.DataGridView1.TabIndex = 45
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nome"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Preço"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Audio"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.Width = 50
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.TextBoxBarCodeSeparador)
        Me.GroupBox9.Controls.Add(Me.Label30)
        Me.GroupBox9.Controls.Add(Me.TextBoxBarCodeFile)
        Me.GroupBox9.Controls.Add(Me.Label29)
        Me.GroupBox9.Controls.Add(Me.ButtonFileCSV)
        Me.GroupBox9.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(361, 78)
        Me.GroupBox9.TabIndex = 44
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Configurações do Arquivo"
        '
        'TextBoxBarCodeSeparador
        '
        Me.TextBoxBarCodeSeparador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBarCodeSeparador.Location = New System.Drawing.Point(75, 46)
        Me.TextBoxBarCodeSeparador.MaxLength = 1
        Me.TextBoxBarCodeSeparador.Name = "TextBoxBarCodeSeparador"
        Me.TextBoxBarCodeSeparador.Size = New System.Drawing.Size(30, 26)
        Me.TextBoxBarCodeSeparador.TabIndex = 45
        Me.TextBoxBarCodeSeparador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(0, 54)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(65, 13)
        Me.Label30.TabIndex = 44
        Me.Label30.Text = "Separador"
        '
        'TextBoxBarCodeFile
        '
        Me.TextBoxBarCodeFile.Location = New System.Drawing.Point(71, 19)
        Me.TextBoxBarCodeFile.Name = "TextBoxBarCodeFile"
        Me.TextBoxBarCodeFile.Size = New System.Drawing.Size(244, 20)
        Me.TextBoxBarCodeFile.TabIndex = 41
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(15, 22)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(50, 13)
        Me.Label29.TabIndex = 43
        Me.Label29.Text = "Arquivo"
        '
        'ButtonFileCSV
        '
        Me.ButtonFileCSV.Location = New System.Drawing.Point(328, 17)
        Me.ButtonFileCSV.Name = "ButtonFileCSV"
        Me.ButtonFileCSV.Size = New System.Drawing.Size(27, 23)
        Me.ButtonFileCSV.TabIndex = 42
        Me.ButtonFileCSV.Text = "..."
        Me.ButtonFileCSV.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage5.Controls.Add(Me.GroupBox8)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(768, 235)
        Me.TabPage5.TabIndex = 6
        Me.TabPage5.Text = "Comando Livre"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label28)
        Me.GroupBox8.Controls.Add(Me.TextBoxComandoLivreHexa)
        Me.GroupBox8.Controls.Add(Me.ButtonComandoLivre)
        Me.GroupBox8.Controls.Add(Me.Label27)
        Me.GroupBox8.Controls.Add(Me.TextBoxComandoLivre)
        Me.GroupBox8.Location = New System.Drawing.Point(17, 16)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(441, 141)
        Me.GroupBox8.TabIndex = 6
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Comando Livre"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(16, 83)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(36, 13)
        Me.Label28.TabIndex = 40
        Me.Label28.Text = "Hexa"
        '
        'TextBoxComandoLivreHexa
        '
        Me.TextBoxComandoLivreHexa.Location = New System.Drawing.Point(62, 80)
        Me.TextBoxComandoLivreHexa.Multiline = True
        Me.TextBoxComandoLivreHexa.Name = "TextBoxComandoLivreHexa"
        Me.TextBoxComandoLivreHexa.Size = New System.Drawing.Size(292, 48)
        Me.TextBoxComandoLivreHexa.TabIndex = 41
        '
        'ButtonComandoLivre
        '
        Me.ButtonComandoLivre.Location = New System.Drawing.Point(360, 24)
        Me.ButtonComandoLivre.Name = "ButtonComandoLivre"
        Me.ButtonComandoLivre.Size = New System.Drawing.Size(75, 23)
        Me.ButtonComandoLivre.TabIndex = 39
        Me.ButtonComandoLivre.Text = "Enviar"
        Me.ButtonComandoLivre.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(16, 27)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(40, 13)
        Me.Label27.TabIndex = 34
        Me.Label27.Text = "String"
        '
        'TextBoxComandoLivre
        '
        Me.TextBoxComandoLivre.Location = New System.Drawing.Point(62, 24)
        Me.TextBoxComandoLivre.Multiline = True
        Me.TextBoxComandoLivre.Name = "TextBoxComandoLivre"
        Me.TextBoxComandoLivre.Size = New System.Drawing.Size(292, 50)
        Me.TextBoxComandoLivre.TabIndex = 35
        '
        'GroupBoxInfoCliente
        '
        Me.GroupBoxInfoCliente.Controls.Add(Me.TextBoxInfoCliente)
        Me.GroupBoxInfoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxInfoCliente.Location = New System.Drawing.Point(597, 12)
        Me.GroupBoxInfoCliente.Name = "GroupBoxInfoCliente"
        Me.GroupBoxInfoCliente.Size = New System.Drawing.Size(191, 85)
        Me.GroupBoxInfoCliente.TabIndex = 3
        Me.GroupBoxInfoCliente.TabStop = False
        Me.GroupBoxInfoCliente.Text = "Informações do Cliente"
        '
        'TextBoxInfoCliente
        '
        Me.TextBoxInfoCliente.Location = New System.Drawing.Point(6, 19)
        Me.TextBoxInfoCliente.Multiline = True
        Me.TextBoxInfoCliente.Name = "TextBoxInfoCliente"
        Me.TextBoxInfoCliente.Size = New System.Drawing.Size(179, 60)
        Me.TextBoxInfoCliente.TabIndex = 0
        '
        'OpenFileDialogGif
        '
        Me.OpenFileDialogGif.Filter = "Gif files|*.gif|Allfiles|*.*"
        '
        'OpenFileDialogAudio
        '
        Me.OpenFileDialogAudio.Filter = "wave files|*.wav|Allfiles|*.*"
        '
        'OpenFileDialogCSV
        '
        Me.OpenFileDialogCSV.Filter = "CSV files|*.csv|Allfiles|*.*"
        '
        'TimerComando
        '
        Me.TimerComando.Interval = 1000
        '
        'OpenFileDialogFW
        '
        Me.OpenFileDialogFW.Filter = "bin files|*.bin|Allfiles|*.*"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 600)
        Me.Controls.Add(Me.GroupBoxInfoCliente)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TextBoxDebug)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TC Tester"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStripClearDebug.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.FlowLayoutPanel8.ResumeLayout(False)
        Me.FlowLayoutPanel8.PerformLayout()
        Me.FlowLayoutPanel7.ResumeLayout(False)
        Me.FlowLayoutPanel7.PerformLayout()
        Me.FlowLayoutPanel6.ResumeLayout(False)
        Me.FlowLayoutPanel6.PerformLayout()
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.FlowLayoutPanel5.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBoxInfoCliente.ResumeLayout(False)
        Me.GroupBoxInfoCliente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonConectar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxPorta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxServerIP As TextBox
    Friend WithEvents TextBoxDebug As TextBox
    Friend WithEvents TimerClientConnected As Timer
    Friend WithEvents TimerLive As Timer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ButtonReset As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ButtonCheckLive As Button
    Friend WithEvents ButtonAlwaysLive As Button
    Friend WithEvents GroupBoxInfoCliente As GroupBox
    Friend WithEvents TextBoxInfoCliente As TextBox
    Friend WithEvents TextBoxGetTerminalIP As TextBox
    Friend WithEvents TextBoxGetServerIP As TextBox
    Friend WithEvents TextBoxGetLinha3 As TextBox
    Friend WithEvents TextBoxGetLinha1 As TextBox
    Friend WithEvents TextBoxGetLinha2 As TextBox
    Friend WithEvents TextBoxGetMask As TextBox
    Friend WithEvents TextBoxGetTempoExibicao As TextBox
    Friend WithEvents TextBoxGetGateway As TextBox
    Friend WithEvents TextBoxGetLinha4 As TextBox
    Friend WithEvents TextBoxGetNomeTerminal As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBoxGetMAC As TextBox
    Friend WithEvents ButtonGetMAC As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBoxSetConfig As ComboBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents LabelSetNomeTerm As Label
    Friend WithEvents TextBoxSetNomeTerm As TextBox
    Friend WithEvents LabelSetTipoIP As Label
    Friend WithEvents LabelSetGateway As Label
    Friend WithEvents TextBoxSetGateway As TextBox
    Friend WithEvents TextBoxSetTerminalIP As TextBox
    Friend WithEvents TextBoxSetServerIP As TextBox
    Friend WithEvents TextBoxSetMask As TextBox
    Friend WithEvents LabelSetServerIP As Label
    Friend WithEvents LabelSetTerminalIP As Label
    Friend WithEvents LabelSetMask As Label
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents TextBoxSetLinha1 As TextBox
    Friend WithEvents TextBoxSetLinha2 As TextBox
    Friend WithEvents TextBoxSetLinha3 As TextBox
    Friend WithEvents TextBoxSetLinha4 As TextBox
    Friend WithEvents TextBoxSetTempoExibicao As TextBox
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents LabelSetLinha1 As Label
    Friend WithEvents LabelSetLinha2 As Label
    Friend WithEvents LabelSetLinha3 As Label
    Friend WithEvents LabelSetLinha4 As Label
    Friend WithEvents LabelSetTempoExibicao As Label
    Friend WithEvents ButtonSetConfig As Button
    Friend WithEvents RadioButtonSetIPDinâmico As RadioButton
    Friend WithEvents RadioButtonSetIPFixo As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ButtonMesg As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBoxMesgTempo As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBoxMesgLinha2 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBoxMesgLinha1 As TextBox
    Friend WithEvents OpenFileDialogGif As OpenFileDialog
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ButtonGif As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBoxGifTempo As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBoxGifLoops As TextBox
    Friend WithEvents ButtonGifGetImagem As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBoxGifIndice As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBoxGifFileName As TextBox
    Friend WithEvents OpenFileDialogAudio As OpenFileDialog
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Label29 As Label
    Friend WithEvents ButtonFileCSV As Button
    Friend WithEvents TextBoxBarCodeFile As TextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label30 As Label
    Friend WithEvents TextBoxBarCodeSeparador As TextBox
    Friend WithEvents OpenFileDialogCSV As OpenFileDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonBarCodeAtualizaTabela As Button
    Friend WithEvents TimerComando As Timer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label31 As Label
    Friend WithEvents TextBoxAudioFileName As TextBox
    Friend WithEvents TextBoxAudioVolume As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents ButtonAudioGetFile As Button
    Friend WithEvents TextBoxAudioDuracao As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents ButtonSendFW As Button
    Friend WithEvents TextBoxFW As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents ButtonGetFW As Button
    Friend WithEvents OpenFileDialogFW As OpenFileDialog
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TextBoxComandoLivreHexa As TextBox
    Friend WithEvents ButtonComandoLivre As Button
    Friend WithEvents Label27 As Label
    Friend WithEvents TextBoxComandoLivre As TextBox
    Friend WithEvents FlowLayoutPanel8 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
    Friend WithEvents LabelGetLinha1 As Label
    Friend WithEvents LabelGetLinha2 As Label
    Friend WithEvents LabelGetLinha3 As Label
    Friend WithEvents LabelGetLinha4 As Label
    Friend WithEvents LabelGetTempoExibicao As Label
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents LabelGetServerIP As Label
    Friend WithEvents LabelGetTerminalIP As Label
    Friend WithEvents LabelGetMask As Label
    Friend WithEvents LabelGetGateway As Label
    Friend WithEvents LabelGetTipoIP As Label
    Friend WithEvents LabelGetNomeTerminal As Label
    Friend WithEvents RadioButtonGetDinamico As RadioButton
    Friend WithEvents RadioButtonGetFixo As RadioButton
    Friend WithEvents ButtonGetConfig As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxGetConfig As ComboBox
    Friend WithEvents LabelSetSSID As Label
    Friend WithEvents LabelSetTipoCripto As Label
    Friend WithEvents LabelSetSenha As Label
    Friend WithEvents TextBoxSetSSID As TextBox
    Friend WithEvents ComboBoxSetTipoCripto As ComboBox
    Friend WithEvents TextBoxSetSenha As TextBox
    Friend WithEvents RadioButtonSetHabilitaWifi As RadioButton
    Friend WithEvents RadioButtonSetDesabilitaWifi As RadioButton
    Friend WithEvents LabelSetHabilitaWifi As Label
    Friend WithEvents RadioButtonGetHabilitaWifi As RadioButton
    Friend WithEvents RadioButtonGetDesabilitaWifi As RadioButton
    Friend WithEvents TextBoxGetSSID As TextBox
    Friend WithEvents ComboBoxGetTipoCripto As ComboBox
    Friend WithEvents TextBoxGetSenha As TextBox
    Friend WithEvents LabelGetHabilitaWifi As Label
    Friend WithEvents LabelGetSSID As Label
    Friend WithEvents LabelGetTipoCripto As Label
    Friend WithEvents LabelGetSenha As Label
    Friend WithEvents CheckBoxEnviarLive As CheckBox
    Friend WithEvents ContextMenuStripClearDebug As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
