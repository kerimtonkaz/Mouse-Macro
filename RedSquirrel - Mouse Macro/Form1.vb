Public Class Form1

    Public macro_yolu As String

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Public Const MOUSEEVENTF_MIDDLEDOWN = &H20
    Public Const MOUSEEVENTF_MIDDLEUP = &H40
    Public Const MOUSEEVENTF_RIGHTDOWN = &H8
    Public Const MOUSEEVENTF_RIGHTUP = &H10
    Dim CTRL_Key As Boolean
    Dim Shift_Key As Boolean
    Dim R_Key As Boolean
    Dim S_Key As Boolean
    Dim P_Key As Boolean
    Dim E_Key As Boolean
    Dim X_Key As Boolean
    Dim Z_Key As Boolean
    Dim T_Key As Boolean
    Dim O_Key As Boolean
    Dim C_Key As Boolean
    Dim sil As Boolean
    Dim Mouse_LeftClick As Boolean
    Dim Mouse_RightClick As Boolean
    Dim Mouse_MiddleClick As Boolean
    Dim Val0 As Integer = 0
    Dim Val1 As Integer = 0

    Private Sub btnKayit_Click(sender As Object, e As EventArgs) Handles btnKayit.Click
        If btnBaslat.Text = "Durdur" Then
            MsgBox("Lütfen önce macro'yu durdurun!", MsgBoxStyle.Critical)
        Else
            If btnKayit.Text = "Kayıt" Then
                btnKayit.BackColor = Color.DarkRed
                btnKayit.Text = "Durdur"
                tmrMacroKayit.Interval = nupKayitHizi.Value
                tmrMacroKayit.Start()
            Else
                btnKayit.BackColor = Color.ForestGreen
                btnKayit.Text = "Kayıt"
                tmrMacroKayit.Stop()
                lbX.Items.RemoveAt(0)
                lbX.Items.RemoveAt(0)
                lbY.Items.RemoveAt(0)
                lbY.Items.RemoveAt(0)
                lbX.SelectedIndex = 0
                lbY.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub btnBaslat_Click(sender As Object, e As EventArgs) Handles btnBaslat.Click
        If btnKayit.Text = "Durdur" Then
            MsgBox("Lütfen önce kaydı durdurun!", MsgBoxStyle.Critical)
        Else
            If btnBaslat.Text = "Başlat" Then
                btnBaslat.BackColor = Color.DarkRed
                btnBaslat.Text = "Durdur"
                Try
                    tmrMacroBaslat.Interval = nupOynatmaHizi.Value
                    lbX.SelectedIndex = 0
                    lbY.SelectedIndex = 0
                    Val1 = 0
                    Val0 = 0
                    tmrMacroBaslat.Start()
                Catch ex As Exception
                End Try

            Else
                btnBaslat.BackColor = Color.ForestGreen
                btnBaslat.Text = "Başlat"
                tmrMacroBaslat.Stop()
            End If
        End If
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        If MsgBox("Silmek istediğinizden emin misiniz ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            lbX.Items.Clear()
            lbY.Items.Clear()
        End If
    End Sub

    Private Sub btnKontrol_Click(sender As Object, e As EventArgs) Handles btnKontrol.Click
        If macro_yolu = "" Then
            MsgBox("Lütfen 'Macro Aç' bölümüne kayıtlı macro yolunu gösterin", MsgBoxStyle.Information)
        Else
            rtbKontrol.Visible = True
            Me.Height = 465
            analyzer()
        End If
    End Sub

    Private Sub lblAc_Click(sender As Object, e As EventArgs) Handles lblAc.Click
        OpenFileDialog1.FileName = "x.rs"
        OpenFileDialog1.Title = "Lütfen macroyu seçin"
        OpenFileDialog1.Filter = "x-rs dosyaları (*.  x.rs) |*x.rs"
        OpenFileDialog1.ShowDialog()
        macro_yolu = OpenFileDialog1.FileName
        lblAktifMacro.Text = macro_yolu
        macro_yolu = macro_yolu.Replace("-x.rs", "")
        Dim Macro_Part1 As String = macro_yolu & "-x.rs"
        Dim Macro_Part2 As String = macro_yolu & "-y.rs"
        Dim Macro_Part3 As String = macro_yolu & "-settings.rs"
        Try
            Dim FileLine As Short
            Dim StringData As String
            FileLine = FreeFile()
            FileOpen(FileLine, Macro_Part1, OpenMode.Input)
            lbX.Items.Clear()
            While Not EOF(FileLine)
                StringData = LineInput(FileLine)
                StringData = StringData.Replace("ï»¿", "")
                lbX.Items.Add((StringData))
            End While
            FileClose(FileLine)
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try

        Try
            Dim FileLine1 As Short
            Dim StringData1 As String
            FileLine1 = FreeFile()

            FileOpen(FileLine1, Macro_Part2, OpenMode.Input)
            lbY.Items.Clear()
            While Not EOF(FileLine1)
                StringData1 = LineInput(FileLine1)
                StringData1 = StringData1.Replace("ï»¿", "")
                lbY.Items.Add((StringData1))
            End While
            FileClose(FileLine1)
        Catch Ex As Exception
        End Try

        Try
            Dim FileLine2 As Short
            Dim StringData2 As String
            FileLine2 = FreeFile()
            FileOpen(FileLine2, Macro_Part3, OpenMode.Input)
            lbAyarlar.Items.Clear()
            While Not EOF(FileLine2)
                StringData2 = LineInput(FileLine2)
                StringData2 = StringData2.Replace("ï»¿", "")
                lbAyarlar.Items.Add((StringData2))
            End While
            FileClose(FileLine2)
        Catch ex As Exception
        End Try

        Try
            nupKayitHizi.Value = lbAyarlar.Items.Item(1)
            nupOynatmaHizi.Value = lbAyarlar.Items.Item(2)
            nupDongu.Value = lbAyarlar.Items.Item(3)
        Catch Ex As Exception
        End Try
        ToolStripStatusLabel2.Text = lbX.Items.Count
        ToolStripStatusLabel4.Text = lbY.Items.Count
    End Sub

    Private Sub lblKaydet_Click(sender As Object, e As EventArgs) Handles lblKaydet.Click
        SaveFileDialog1.Title = "RedSquirrel - Macro Kaydet"
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            macro_yolu = SaveFileDialog1.FileName
            Dim Macro_Part1 As String = macro_yolu & "-x.rs"
            Dim Macro_Part2 As String = macro_yolu & "-y.rs"
            Dim Macro_Part3 As String = macro_yolu & "-settings.rs"
            Try
                Dim Saveval As Integer = 1
                Saveval = Saveval - 1
                For i = 0 To lbX.Items.Count - 1
                    lbX.SetSelected(i, True)
                    Dim Listwrite1 As System.IO.StreamWriter
                    Listwrite1 = My.Computer.FileSystem.
                    OpenTextFileWriter(Macro_Part1, True)
                    Listwrite1.WriteLine(lbX.Items(i))
                    Listwrite1.Close()
                Next


                For i = 0 To lbY.Items.Count - 1
                    lbY.SetSelected(i, True)
                    Dim Listwrite1 As System.IO.StreamWriter
                    Listwrite1 = My.Computer.FileSystem.
                    OpenTextFileWriter(Macro_Part2, True)
                    Listwrite1.WriteLine(lbY.Items(i))
                    Listwrite1.Close()
                Next

                Dim SW As System.IO.StreamWriter
                SW = My.Computer.FileSystem.
                OpenTextFileWriter(Macro_Part3, True)
                SW.WriteLine("$OPTION SET {Allow_Change} ; RETURN {Allow_Change}, (FALSE);")
                SW.WriteLine(nupKayitHizi.Value)
                SW.WriteLine(nupOynatmaHizi.Value)
                SW.WriteLine(nupDongu.Value)
                SW.WriteLine("*******************")
                SW.WriteLine("*RedSquirrel - Hack4Sec*")
                SW.WriteLine("*******************")
                SW.Close()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub tmrMacroKayit_Tick(sender As Object, e As EventArgs) Handles tmrMacroKayit.Tick
        Record(MousePosition.X, MousePosition.Y)
    End Sub

    Private Sub tmrMacroBaslat_Tick(sender As Object, e As EventArgs) Handles tmrMacroBaslat.Tick
        If Not Val1 = Val(nupDongu.Value) Then
            Play()
        Else
            btnBaslat.PerformClick()
            tmrMacroBaslat.Stop()
        End If
    End Sub

    Private Sub lblKapat_Click(sender As Object, e As EventArgs) Handles lblKapat.Click
        rtbKontrol.Visible = False
        Me.Height = 340
    End Sub

#Region "Functions"
    Public Sub Record(ByVal PosX As String, ByVal PosY As String)
        PosX = MousePosition.X
        PosY = MousePosition.Y
        lbX.Items.Add(PosX)
        lbY.Items.Add(PosY)

        lbX.SelectedIndex = lbX.Items.Count - 1
        lbY.SelectedIndex = lbY.Items.Count - 1

        Mouse_LeftClick = GetAsyncKeyState(Keys.LButton)
        If Mouse_LeftClick Then
            lbX.Items.Add("RS_0")
            lbY.Items.Add("RS_0")
        End If

        Mouse_RightClick = GetAsyncKeyState(Keys.RButton)
        If Mouse_RightClick Then
            lbX.Items.Add("RS_1")
            lbY.Items.Add("RS_1")
        End If

        Mouse_MiddleClick = GetAsyncKeyState(Keys.MButton)
        If Mouse_MiddleClick Then
            lbX.Items.Add("RS_2")
            lbY.Items.Add("RS_2")
        End If
        ToolStripStatusLabel2.Text = lbX.Items.Count
        ToolStripStatusLabel4.Text = lbY.Items.Count
    End Sub

    Private Sub Play()
        Try
            Dim Location As New Point(lbX.Text, lbY.Text)
            Cursor.Position = Location
        Catch Ex As Exception
        End Try

        Try
            If lbX.Text = ("RS_0") Then
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, New IntPtr)
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, New IntPtr)
            End If

            If lbX.Text = ("RS_1") Then
                mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, New IntPtr)
                mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, New IntPtr)
            End If

            If lbX.Text = ("RS_2") Then
                mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, New IntPtr)
                mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, New IntPtr)
            End If
        Catch Ex As Exception
        End Try

        Try
            If Val0 = lbX.Items.Count - 1 Then
                Val0 = 0
                lbX.SetSelected(0, True)
                lbY.SetSelected(0, True)
                Val1 = Val1 + 1
                lblOynatilan.Text = Val1
            Else
                lbX.SetSelected(Val0, True)
                lbY.SetSelected(Val0, True)
                Val0 = Val0 + 1
            End If
        Catch Ex As Exception
        End Try
    End Sub
#End Region
End Class
