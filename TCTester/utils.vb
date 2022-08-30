Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Diagnostics
Imports System.Text
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions

Module utils

    Public Function ConverteStringParaHexa(ByVal Texto As String)
        Dim sVal As String
        Dim sHex As String = ""
        While Texto.Length > 0
            sVal = Conversion.Hex(Strings.Asc(Texto.Substring(0, 1).ToString()))
            Texto = Texto.Substring(1, Texto.Length - 1)
            'sHex = sHex & " " & sVal
            sHex = sHex & " " & Microsoft.VisualBasic.Right("0" & sVal, 2)
        End While

        'tirar o espaço inicial
        sHex = sHex.Substring(1, sHex.Length - 1)
        Return sHex

    End Function

    Public Function ConverteStringParaHexa(ByVal Texto As String, ByVal Tam As Integer)
        Dim Cont As Integer
        Dim Caracter, Temp As String
        Temp = ""

        For Cont = 0 To Tam - 1
            Caracter = Hex(Convert.ToInt32(Texto(Cont)))
            While Caracter.Length < 2
                Caracter = "0" & Caracter
            End While

            Temp = Temp & Caracter & " "
        Next

        ConverteStringParaHexa = Temp

    End Function

    Public Function ConverteHexaParaString(ByVal Valor As String)
        Dim strTemp As String
        Dim strReturn As String
        Dim tt As String
        Dim i As Long
        strReturn = ""

        'For i = 1 To Len(HexToStr) Step 3
        For i = 1 To Len(Valor) Step 3
            tt = Mid$(Valor, i, 2)
            strTemp = Chr(Val("&H" & Mid$(Valor, i, 2)))
            strReturn = strReturn & strTemp
        Next i

        ConverteHexaParaString = strReturn
    End Function

    Public Function ConverteIntStringParaInteiro(ByVal Valor As String)
        Dim ret As Integer

        ret = Asc(Valor) - 48

        ConverteIntStringParaInteiro = ret

    End Function

    'inteiro 1  -> string 01
    'inteiro 10 -> string 0A
    Public Function ConverteInteiroParaString(ByVal Valor As String)
        Return ConverteHexaParaString(Hex(Valor))
    End Function

    'inteiro 1  -> string 01
    'inteiro 10 -> string 0A
    Public Function ConverteInteiroParaIntString(ByVal Valor As Integer)
        Valor += 48

        Return ConverteHexaParaString(Hex(Valor))
    End Function

    Public Function ConverteLongParaString(ByVal Valor As Long, ByVal Tam As Integer)
        Dim Ret As String

        'Ret = ConverteHexaParaString(Hex(Valor))
        Ret = Valor.ToString("X")

        While Ret.Length < Tam
            Ret = "0" + Ret
        End While

        Dim temp As String
        temp = ConverteStringParaHexa(Ret)
        Return Ret
    End Function

    Public Function ConverteStringLongParaHexaInvertido(ByVal Valor As Long, ByVal TamanhoSaida As Integer)
        Dim Retorno As String = ""
        Dim RetornoInvertido As String = ""
        Dim i As Integer

        Retorno = Valor.ToString("X")
        If (Retorno.Length Mod 2 <> 0) Then
            Retorno = "0" & Retorno
        End If

        'formatar para o tamanho
        Retorno = "0000000000" & Retorno
        Retorno = Retorno.Substring(Retorno.Length - TamanhoSaida * 2, TamanhoSaida * 2)

        'inverter e colocar espaços
        For i = TamanhoSaida * 2 - 2 To 0 Step -2
            RetornoInvertido += Retorno.Substring(i, 2)
            If (i <> 0) Then
                RetornoInvertido += " "
            End If
        Next


        ConverteStringLongParaHexaInvertido = RetornoInvertido
    End Function

    Public Function FormataTamanhoStringZeroEsq(ByVal Valor As String, ByVal Tam As String)

        While Valor.Length < Tam
            Valor = "0" + Valor
        End While

        FormataTamanhoStringZeroEsq = Valor
    End Function

    Public Function InsereEspacoEmHexa(ByVal Entrada As String) As String
        Dim strRetorno As String
        Dim i As Long

        strRetorno = ""
        If (Entrada.Length > 0) Then
            For i = 1 To Len(Entrada) Step 2
                strRetorno = strRetorno & Mid(Entrada, i, 2) & " "
            Next

            'tirar o último " "
            strRetorno = Left(strRetorno, Len(strRetorno) - 1)
        End If

        InsereEspacoEmHexa = strRetorno

    End Function

    Public Function RetiraEspacoEmHexa(ByVal Entrada As String) As String
        Return Entrada.Replace(" ", "")
    End Function
End Module
