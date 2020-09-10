Module RedSquirrel

    Dim Count As Integer = 0

    Public Function analyzer()
        On Error Resume Next
        Dim Macro_Part1 As String = Form1.macro_yolu & "-x.rs"
        Dim Macro_Part2 As String = Form1.macro_yolu & "-y.rs"
        Dim Macro_Part3 As String = Form1.macro_yolu & "-settings.rs"

        Dim File(2) As Boolean
        Form1.rtbKontrol.Text = ""
        If Form1.macro_yolu = "" Then

        Else
            If IO.File.Exists(Macro_Part1) Then
                File(0) = True
                Form1.rtbKontrol.Text += "Macro Adı: " & Macro_Part1 & vbCrLf
            Else
                File(0) = False
            End If

            If IO.File.Exists(Macro_Part2) Then
                File(1) = True
                Count = Count + 1
                Form1.rtbKontrol.Text += "{" & vbCrLf & Macro_Part2 & vbCrLf
            Else
                Form1.rtbKontrol.Text += "{" & vbCrLf
                File(1) = False
            End If

            If IO.File.Exists(Macro_Part3) Then
                File(2) = True
                Count = Count + 1
                Form1.rtbKontrol.Text += Macro_Part3 & vbCrLf & "}" & vbCrLf
            Else
                Form1.rtbKontrol.Text += "}" & vbCrLf
                File(2) = False
            End If

            Form1.rtbKontrol.Text += "X değeri dosyası: " & File(0) & vbCrLf & "Y değeri dosyası: " & File(1) & vbCrLf & "Macro ayar dosyası: " & File(2) & vbCrLf
            Form1.rtbKontrol.Text += "X karakterleri: " & FileLen(Macro_Part1) & vbCrLf & "Y karakterleri: " & FileLen(Macro_Part2) & vbCrLf
            Form1.rtbKontrol.Text += "X satırları: " & Form1.lbX.Items.Count & vbCrLf & "Y satırları: " & Form1.lbY.Items.Count & vbCrLf
            Form1.rtbKontrol.Text += "Genişletilmiş Dosyalar: " & Count & vbCrLf & vbCrLf
            Form1.rtbKontrol.Text += "****************" & vbCrLf
            Form1.rtbKontrol.Text += "*RedSquirrel - Hack4Sec*" & vbCrLf
            Form1.rtbKontrol.Text += "****************"

            If Count < 2 Or File(0) = False Or File(1) = False Or File(2) = False Then
                MsgBox("Esksik dosya bulunmaktadır. Lütfen macro yeniden kaydedin.", MsgBoxStyle.Critical)
            End If
        End If
        Count = 0
    End Function

End Module
