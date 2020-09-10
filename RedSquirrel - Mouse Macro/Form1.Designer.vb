<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.rtbKontrol = New System.Windows.Forms.RichTextBox()
        Me.btnKontrol = New System.Windows.Forms.Button()
        Me.btnBaslat = New System.Windows.Forms.Button()
        Me.btnKayit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lblAktifMacro = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblKaydet = New System.Windows.Forms.Button()
        Me.lblAc = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lblOynatilan = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.nupDongu = New System.Windows.Forms.NumericUpDown()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.nupOynatmaHizi = New System.Windows.Forms.NumericUpDown()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.nupKayitHizi = New System.Windows.Forms.NumericUpDown()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lbY = New System.Windows.Forms.ListBox()
        Me.lbX = New System.Windows.Forms.ListBox()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.lblKapat = New System.Windows.Forms.Label()
        Me.tmrMacroKayit = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMacroBaslat = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lbAyarlar = New System.Windows.Forms.ListBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.nupDongu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupOynatmaHizi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupKayitHizi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtbKontrol
        '
        Me.rtbKontrol.Location = New System.Drawing.Point(12, 264)
        Me.rtbKontrol.Margin = New System.Windows.Forms.Padding(4)
        Me.rtbKontrol.Name = "rtbKontrol"
        Me.rtbKontrol.ReadOnly = True
        Me.rtbKontrol.Size = New System.Drawing.Size(532, 192)
        Me.rtbKontrol.TabIndex = 37
        Me.rtbKontrol.Text = ""
        Me.rtbKontrol.Visible = False
        Me.rtbKontrol.WordWrap = False
        '
        'btnKontrol
        '
        Me.btnKontrol.BackColor = System.Drawing.Color.Teal
        Me.btnKontrol.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnKontrol.ForeColor = System.Drawing.Color.White
        Me.btnKontrol.Location = New System.Drawing.Point(136, 16)
        Me.btnKontrol.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKontrol.Name = "btnKontrol"
        Me.btnKontrol.Size = New System.Drawing.Size(100, 89)
        Me.btnKontrol.TabIndex = 36
        Me.btnKontrol.Text = "Hedefteki Macroyu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kontrol Et" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnKontrol.UseVisualStyleBackColor = False
        '
        'btnBaslat
        '
        Me.btnBaslat.BackColor = System.Drawing.Color.ForestGreen
        Me.btnBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBaslat.ForeColor = System.Drawing.Color.White
        Me.btnBaslat.Location = New System.Drawing.Point(12, 47)
        Me.btnBaslat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBaslat.Name = "btnBaslat"
        Me.btnBaslat.Size = New System.Drawing.Size(100, 34)
        Me.btnBaslat.TabIndex = 35
        Me.btnBaslat.Text = "Başlat"
        Me.btnBaslat.UseVisualStyleBackColor = False
        '
        'btnKayit
        '
        Me.btnKayit.BackColor = System.Drawing.Color.ForestGreen
        Me.btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnKayit.ForeColor = System.Drawing.Color.White
        Me.btnKayit.Location = New System.Drawing.Point(11, 5)
        Me.btnKayit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKayit.Name = "btnKayit"
        Me.btnKayit.Size = New System.Drawing.Size(100, 34)
        Me.btnKayit.TabIndex = 34
        Me.btnKayit.Text = "Kayıt"
        Me.btnKayit.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 268)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(565, 25)
        Me.StatusStrip1.TabIndex = 33
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(21, 20)
        Me.ToolStripStatusLabel1.Text = "X:"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(17, 20)
        Me.ToolStripStatusLabel2.Text = "0"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(20, 20)
        Me.ToolStripStatusLabel3.Text = "Y:"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel4.Text = "ToolStripStatusLabel4"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lblAktifMacro)
        Me.GroupBox7.Controls.Add(Me.Label21)
        Me.GroupBox7.Controls.Add(Me.lblKaydet)
        Me.GroupBox7.Controls.Add(Me.lblAc)
        Me.GroupBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox7.Location = New System.Drawing.Point(292, 144)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox7.Size = New System.Drawing.Size(256, 112)
        Me.GroupBox7.TabIndex = 32
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Macro Kaydet / Macro Aç"
        '
        'lblAktifMacro
        '
        Me.lblAktifMacro.AutoSize = True
        Me.lblAktifMacro.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAktifMacro.Location = New System.Drawing.Point(9, 44)
        Me.lblAktifMacro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAktifMacro.Name = "lblAktifMacro"
        Me.lblAktifMacro.Size = New System.Drawing.Size(17, 12)
        Me.lblAktifMacro.TabIndex = 29
        Me.lblAktifMacro.Text = "---"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 21)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(116, 17)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "Aktif Olan Macro:"
        '
        'lblKaydet
        '
        Me.lblKaydet.BackColor = System.Drawing.Color.ForestGreen
        Me.lblKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblKaydet.ForeColor = System.Drawing.Color.White
        Me.lblKaydet.Location = New System.Drawing.Point(17, 70)
        Me.lblKaydet.Margin = New System.Windows.Forms.Padding(4)
        Me.lblKaydet.Name = "lblKaydet"
        Me.lblKaydet.Size = New System.Drawing.Size(100, 34)
        Me.lblKaydet.TabIndex = 26
        Me.lblKaydet.Text = "Kaydet"
        Me.lblKaydet.UseVisualStyleBackColor = False
        '
        'lblAc
        '
        Me.lblAc.BackColor = System.Drawing.Color.ForestGreen
        Me.lblAc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblAc.ForeColor = System.Drawing.Color.White
        Me.lblAc.Location = New System.Drawing.Point(125, 70)
        Me.lblAc.Margin = New System.Windows.Forms.Padding(4)
        Me.lblAc.Name = "lblAc"
        Me.lblAc.Size = New System.Drawing.Size(100, 34)
        Me.lblAc.TabIndex = 25
        Me.lblAc.Text = "Aç"
        Me.lblAc.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.lblOynatilan)
        Me.GroupBox8.Controls.Add(Me.Label35)
        Me.GroupBox8.Controls.Add(Me.nupDongu)
        Me.GroupBox8.Controls.Add(Me.Label24)
        Me.GroupBox8.Controls.Add(Me.nupOynatmaHizi)
        Me.GroupBox8.Controls.Add(Me.Label25)
        Me.GroupBox8.Controls.Add(Me.nupKayitHizi)
        Me.GroupBox8.Controls.Add(Me.Label26)
        Me.GroupBox8.ForeColor = System.Drawing.Color.White
        Me.GroupBox8.Location = New System.Drawing.Point(269, 2)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Size = New System.Drawing.Size(279, 135)
        Me.GroupBox8.TabIndex = 31
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Kayıt Ayarı (salise)"
        '
        'lblOynatilan
        '
        Me.lblOynatilan.AutoSize = True
        Me.lblOynatilan.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblOynatilan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOynatilan.Location = New System.Drawing.Point(96, 106)
        Me.lblOynatilan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOynatilan.Name = "lblOynatilan"
        Me.lblOynatilan.Size = New System.Drawing.Size(17, 17)
        Me.lblOynatilan.TabIndex = 31
        Me.lblOynatilan.Text = "0"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label35.Location = New System.Drawing.Point(12, 106)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(82, 17)
        Me.Label35.TabIndex = 30
        Me.Label35.Text = "Oynatılan: "
        '
        'nupDongu
        '
        Me.nupDongu.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.nupDongu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nupDongu.ForeColor = System.Drawing.Color.White
        Me.nupDongu.Location = New System.Drawing.Point(172, 78)
        Me.nupDongu.Margin = New System.Windows.Forms.Padding(4)
        Me.nupDongu.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.nupDongu.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupDongu.Name = "nupDongu"
        Me.nupDongu.Size = New System.Drawing.Size(95, 22)
        Me.nupDongu.TabIndex = 5
        Me.nupDongu.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label24.Location = New System.Drawing.Point(11, 78)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(134, 18)
        Me.Label24.TabIndex = 4
        Me.Label24.Text = "Döngü Oynatma:"
        '
        'nupOynatmaHizi
        '
        Me.nupOynatmaHizi.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.nupOynatmaHizi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nupOynatmaHizi.ForeColor = System.Drawing.Color.White
        Me.nupOynatmaHizi.Location = New System.Drawing.Point(172, 49)
        Me.nupOynatmaHizi.Margin = New System.Windows.Forms.Padding(4)
        Me.nupOynatmaHizi.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.nupOynatmaHizi.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupOynatmaHizi.Name = "nupOynatmaHizi"
        Me.nupOynatmaHizi.Size = New System.Drawing.Size(95, 22)
        Me.nupOynatmaHizi.TabIndex = 3
        Me.nupOynatmaHizi.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label25.Location = New System.Drawing.Point(12, 49)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(114, 18)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Oynatma Hızı:"
        '
        'nupKayitHizi
        '
        Me.nupKayitHizi.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.nupKayitHizi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nupKayitHizi.ForeColor = System.Drawing.Color.White
        Me.nupKayitHizi.Location = New System.Drawing.Point(172, 21)
        Me.nupKayitHizi.Margin = New System.Windows.Forms.Padding(4)
        Me.nupKayitHizi.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.nupKayitHizi.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupKayitHizi.Name = "nupKayitHizi"
        Me.nupKayitHizi.Size = New System.Drawing.Size(95, 22)
        Me.nupKayitHizi.TabIndex = 1
        Me.nupKayitHizi.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label26.Location = New System.Drawing.Point(11, 21)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(84, 18)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Kayıt Hızı:"
        '
        'lbY
        '
        Me.lbY.ForeColor = System.Drawing.Color.Red
        Me.lbY.FormattingEnabled = True
        Me.lbY.ItemHeight = 16
        Me.lbY.Location = New System.Drawing.Point(151, 144)
        Me.lbY.Margin = New System.Windows.Forms.Padding(4)
        Me.lbY.Name = "lbY"
        Me.lbY.Size = New System.Drawing.Size(131, 100)
        Me.lbY.TabIndex = 30
        '
        'lbX
        '
        Me.lbX.ForeColor = System.Drawing.Color.Red
        Me.lbX.FormattingEnabled = True
        Me.lbX.ItemHeight = 16
        Me.lbX.Location = New System.Drawing.Point(11, 144)
        Me.lbX.Margin = New System.Windows.Forms.Padding(4)
        Me.lbX.Name = "lbX"
        Me.lbX.Size = New System.Drawing.Size(131, 100)
        Me.lbX.TabIndex = 29
        '
        'btnSil
        '
        Me.btnSil.BackColor = System.Drawing.Color.ForestGreen
        Me.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSil.ForeColor = System.Drawing.Color.White
        Me.btnSil.Location = New System.Drawing.Point(12, 89)
        Me.btnSil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(100, 34)
        Me.btnSil.TabIndex = 28
        Me.btnSil.Text = "Sil"
        Me.btnSil.UseVisualStyleBackColor = False
        '
        'lblKapat
        '
        Me.lblKapat.AutoSize = True
        Me.lblKapat.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKapat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblKapat.Location = New System.Drawing.Point(20, 464)
        Me.lblKapat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKapat.Name = "lblKapat"
        Me.lblKapat.Size = New System.Drawing.Size(490, 24)
        Me.lblKapat.TabIndex = 38
        Me.lblKapat.Text = "^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^"
        '
        'tmrMacroKayit
        '
        Me.tmrMacroKayit.Interval = 1
        '
        'tmrMacroBaslat
        '
        Me.tmrMacroBaslat.Interval = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lbAyarlar
        '
        Me.lbAyarlar.ForeColor = System.Drawing.Color.Red
        Me.lbAyarlar.FormattingEnabled = True
        Me.lbAyarlar.ItemHeight = 16
        Me.lbAyarlar.Location = New System.Drawing.Point(592, 82)
        Me.lbAyarlar.Margin = New System.Windows.Forms.Padding(4)
        Me.lbAyarlar.Name = "lbAyarlar"
        Me.lbAyarlar.Size = New System.Drawing.Size(131, 100)
        Me.lbAyarlar.TabIndex = 39
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(565, 293)
        Me.Controls.Add(Me.lbAyarlar)
        Me.Controls.Add(Me.lblKapat)
        Me.Controls.Add(Me.rtbKontrol)
        Me.Controls.Add(Me.btnKontrol)
        Me.Controls.Add(Me.btnBaslat)
        Me.Controls.Add(Me.btnKayit)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.lbY)
        Me.Controls.Add(Me.lbX)
        Me.Controls.Add(Me.btnSil)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Red Squirrel (Hack4Sec) - Mouse Macro"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.nupDongu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupOynatmaHizi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupKayitHizi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnKontrol As Button
    Friend WithEvents btnBaslat As Button
    Friend WithEvents btnKayit As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents lblAktifMacro As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblKaydet As Button
    Friend WithEvents lblAc As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents lblOynatilan As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents nupDongu As NumericUpDown
    Friend WithEvents Label24 As Label
    Friend WithEvents nupOynatmaHizi As NumericUpDown
    Friend WithEvents Label25 As Label
    Friend WithEvents nupKayitHizi As NumericUpDown
    Friend WithEvents Label26 As Label
    Friend WithEvents lbY As ListBox
    Friend WithEvents lbX As ListBox
    Friend WithEvents btnSil As Button
    Friend WithEvents lblKapat As Label
    Friend WithEvents tmrMacroKayit As Timer
    Friend WithEvents tmrMacroBaslat As Timer
    Public WithEvents rtbKontrol As RichTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lbAyarlar As ListBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
