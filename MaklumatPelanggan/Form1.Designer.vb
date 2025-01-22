<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblMaklumatpelanggan = New Label()
        lblNama = New Label()
        txtNama = New TextBox()
        lblTelefon = New Label()
        txtTelefon = New TextBox()
        lblAlamat = New Label()
        txtAlamat = New TextBox()
        lblNegeri = New Label()
        cobNegeri = New ComboBox()
        grbJantina = New GroupBox()
        rabPerempuan = New RadioButton()
        rabLelaki = New RadioButton()
        grbKaedahbayar = New GroupBox()
        rabCashless = New RadioButton()
        rabCash = New RadioButton()
        chbCoklat = New CheckBox()
        grbPerisa = New GroupBox()
        chbStrawberry = New CheckBox()
        chbPisang = New CheckBox()
        dgwJadual = New DataGridView()
        clmBill = New DataGridViewTextBoxColumn()
        clmNama = New DataGridViewTextBoxColumn()
        clmTelefon = New DataGridViewTextBoxColumn()
        BtnCreate = New Button()
        BtnRead = New Button()
        BtnUpdate = New Button()
        BtnDelete = New Button()
        dtpTarikh = New DateTimePicker()
        lblTarikh = New Label()
        grbJantina.SuspendLayout()
        grbKaedahbayar.SuspendLayout()
        grbPerisa.SuspendLayout()
        CType(dgwJadual, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblMaklumatpelanggan
        ' 
        lblMaklumatpelanggan.AutoSize = True
        lblMaklumatpelanggan.Font = New Font("Segoe UI", 20F)
        lblMaklumatpelanggan.Location = New Point(212, 29)
        lblMaklumatpelanggan.Name = "lblMaklumatpelanggan"
        lblMaklumatpelanggan.Size = New Size(402, 46)
        lblMaklumatpelanggan.TabIndex = 0
        lblMaklumatpelanggan.Text = "MAKLUMAT PELANGGAN"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(81, 99)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(49, 20)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(140, 92)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(255, 27)
        txtNama.TabIndex = 2
        ' 
        ' lblTelefon
        ' 
        lblTelefon.AutoSize = True
        lblTelefon.Location = New Point(52, 148)
        lblTelefon.Name = "lblTelefon"
        lblTelefon.Size = New Size(85, 20)
        lblTelefon.TabIndex = 3
        lblTelefon.Text = "No. Telefon"
        ' 
        ' txtTelefon
        ' 
        txtTelefon.Location = New Point(140, 145)
        txtTelefon.Name = "txtTelefon"
        txtTelefon.Size = New Size(255, 27)
        txtTelefon.TabIndex = 4
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(77, 193)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(57, 20)
        lblAlamat.TabIndex = 5
        lblAlamat.Text = "Alamat"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(140, 193)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(255, 138)
        txtAlamat.TabIndex = 6
        ' 
        ' lblNegeri
        ' 
        lblNegeri.AutoSize = True
        lblNegeri.Location = New Point(81, 360)
        lblNegeri.Name = "lblNegeri"
        lblNegeri.Size = New Size(54, 20)
        lblNegeri.TabIndex = 7
        lblNegeri.Text = "Negeri"
        ' 
        ' cobNegeri
        ' 
        cobNegeri.FormattingEnabled = True
        cobNegeri.Items.AddRange(New Object() {"Kedah", "Perlis", "Pahang", "Perak", "Melaka", "Pulau Pinang", "Selangor", "Kuala Lumpur", "Sabah", "Sarawak"})
        cobNegeri.Location = New Point(140, 360)
        cobNegeri.Name = "cobNegeri"
        cobNegeri.Size = New Size(255, 28)
        cobNegeri.TabIndex = 8
        ' 
        ' grbJantina
        ' 
        grbJantina.Controls.Add(rabPerempuan)
        grbJantina.Controls.Add(rabLelaki)
        grbJantina.Location = New Point(459, 148)
        grbJantina.Name = "grbJantina"
        grbJantina.Size = New Size(321, 73)
        grbJantina.TabIndex = 10
        grbJantina.TabStop = False
        grbJantina.Text = "Jantina"
        ' 
        ' rabPerempuan
        ' 
        rabPerempuan.AutoSize = True
        rabPerempuan.Location = New Point(172, 26)
        rabPerempuan.Name = "rabPerempuan"
        rabPerempuan.Size = New Size(104, 24)
        rabPerempuan.TabIndex = 1
        rabPerempuan.TabStop = True
        rabPerempuan.Text = "Perempuan"
        rabPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rabLelaki
        ' 
        rabLelaki.AutoSize = True
        rabLelaki.Location = New Point(45, 26)
        rabLelaki.Name = "rabLelaki"
        rabLelaki.Size = New Size(68, 24)
        rabLelaki.TabIndex = 0
        rabLelaki.TabStop = True
        rabLelaki.Text = "Lelaki"
        rabLelaki.UseVisualStyleBackColor = True
        ' 
        ' grbKaedahbayar
        ' 
        grbKaedahbayar.Controls.Add(rabCashless)
        grbKaedahbayar.Controls.Add(rabCash)
        grbKaedahbayar.Location = New Point(459, 248)
        grbKaedahbayar.Name = "grbKaedahbayar"
        grbKaedahbayar.Size = New Size(321, 69)
        grbKaedahbayar.TabIndex = 11
        grbKaedahbayar.TabStop = False
        grbKaedahbayar.Text = "Kaedah Bayar"
        ' 
        ' rabCashless
        ' 
        rabCashless.AutoSize = True
        rabCashless.Location = New Point(172, 26)
        rabCashless.Name = "rabCashless"
        rabCashless.Size = New Size(85, 24)
        rabCashless.TabIndex = 1
        rabCashless.TabStop = True
        rabCashless.Text = "Cashless"
        rabCashless.UseVisualStyleBackColor = True
        ' 
        ' rabCash
        ' 
        rabCash.AutoSize = True
        rabCash.Location = New Point(45, 26)
        rabCash.Name = "rabCash"
        rabCash.Size = New Size(61, 24)
        rabCash.TabIndex = 0
        rabCash.TabStop = True
        rabCash.Text = "Cash"
        rabCash.UseVisualStyleBackColor = True
        ' 
        ' chbCoklat
        ' 
        chbCoklat.AutoSize = True
        chbCoklat.Location = New Point(45, 38)
        chbCoklat.Name = "chbCoklat"
        chbCoklat.Size = New Size(73, 24)
        chbCoklat.TabIndex = 12
        chbCoklat.Text = "Coklat"
        chbCoklat.UseVisualStyleBackColor = True
        ' 
        ' grbPerisa
        ' 
        grbPerisa.Controls.Add(chbStrawberry)
        grbPerisa.Controls.Add(chbPisang)
        grbPerisa.Controls.Add(chbCoklat)
        grbPerisa.Location = New Point(459, 330)
        grbPerisa.Name = "grbPerisa"
        grbPerisa.Size = New Size(321, 112)
        grbPerisa.TabIndex = 13
        grbPerisa.TabStop = False
        grbPerisa.Text = "Perisa"
        ' 
        ' chbStrawberry
        ' 
        chbStrawberry.AutoSize = True
        chbStrawberry.Location = New Point(45, 73)
        chbStrawberry.Name = "chbStrawberry"
        chbStrawberry.Size = New Size(102, 24)
        chbStrawberry.TabIndex = 14
        chbStrawberry.Text = "Strawberry"
        chbStrawberry.UseVisualStyleBackColor = True
        ' 
        ' chbPisang
        ' 
        chbPisang.AutoSize = True
        chbPisang.Location = New Point(172, 38)
        chbPisang.Name = "chbPisang"
        chbPisang.Size = New Size(74, 24)
        chbPisang.TabIndex = 13
        chbPisang.Text = "Pisang"
        chbPisang.UseVisualStyleBackColor = True
        ' 
        ' dgwJadual
        ' 
        dgwJadual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgwJadual.Columns.AddRange(New DataGridViewColumn() {clmBill, clmNama, clmTelefon})
        dgwJadual.Location = New Point(221, 459)
        dgwJadual.Name = "dgwJadual"
        dgwJadual.RowHeadersWidth = 51
        dgwJadual.Size = New Size(428, 106)
        dgwJadual.TabIndex = 14
        ' 
        ' clmBill
        ' 
        clmBill.HeaderText = "Bil"
        clmBill.MinimumWidth = 6
        clmBill.Name = "clmBill"
        clmBill.Width = 125
        ' 
        ' clmNama
        ' 
        clmNama.HeaderText = "Nama"
        clmNama.MinimumWidth = 6
        clmNama.Name = "clmNama"
        clmNama.Width = 125
        ' 
        ' clmTelefon
        ' 
        clmTelefon.HeaderText = "No.telefon"
        clmTelefon.MinimumWidth = 6
        clmTelefon.Name = "clmTelefon"
        clmTelefon.Width = 125
        ' 
        ' BtnCreate
        ' 
        BtnCreate.Location = New Point(100, 582)
        BtnCreate.Name = "BtnCreate"
        BtnCreate.Size = New Size(94, 29)
        BtnCreate.TabIndex = 15
        BtnCreate.Text = "Create"
        BtnCreate.UseVisualStyleBackColor = True
        ' 
        ' BtnRead
        ' 
        BtnRead.Location = New Point(301, 582)
        BtnRead.Name = "BtnRead"
        BtnRead.Size = New Size(94, 29)
        BtnRead.TabIndex = 16
        BtnRead.Text = "Read"
        BtnRead.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Location = New Point(512, 582)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(94, 29)
        BtnUpdate.TabIndex = 17
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(686, 582)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(94, 29)
        BtnDelete.TabIndex = 18
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' dtpTarikh
        ' 
        dtpTarikh.Location = New Point(512, 90)
        dtpTarikh.Name = "dtpTarikh"
        dtpTarikh.Size = New Size(250, 27)
        dtpTarikh.TabIndex = 19
        ' 
        ' lblTarikh
        ' 
        lblTarikh.AutoSize = True
        lblTarikh.Location = New Point(459, 95)
        lblTarikh.Name = "lblTarikh"
        lblTarikh.Size = New Size(47, 20)
        lblTarikh.TabIndex = 20
        lblTarikh.Text = "Tarikh"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(881, 645)
        Controls.Add(lblTarikh)
        Controls.Add(dtpTarikh)
        Controls.Add(BtnDelete)
        Controls.Add(BtnUpdate)
        Controls.Add(BtnRead)
        Controls.Add(BtnCreate)
        Controls.Add(dgwJadual)
        Controls.Add(grbPerisa)
        Controls.Add(grbKaedahbayar)
        Controls.Add(grbJantina)
        Controls.Add(cobNegeri)
        Controls.Add(lblNegeri)
        Controls.Add(txtAlamat)
        Controls.Add(lblAlamat)
        Controls.Add(txtTelefon)
        Controls.Add(lblTelefon)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Controls.Add(lblMaklumatpelanggan)
        Name = "Form1"
        Text = "Form1"
        grbJantina.ResumeLayout(False)
        grbJantina.PerformLayout()
        grbKaedahbayar.ResumeLayout(False)
        grbKaedahbayar.PerformLayout()
        grbPerisa.ResumeLayout(False)
        grbPerisa.PerformLayout()
        CType(dgwJadual, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblMaklumatpelanggan As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblTelefon As Label
    Friend WithEvents txtTelefon As TextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents lblNegeri As Label
    Friend WithEvents cobNegeri As ComboBox
    Friend WithEvents grbJantina As GroupBox
    Friend WithEvents rabPerempuan As RadioButton
    Friend WithEvents rabLelaki As RadioButton
    Friend WithEvents grbKaedahbayar As GroupBox
    Friend WithEvents rabCashless As RadioButton
    Friend WithEvents rabCash As RadioButton
    Friend WithEvents chbCoklat As CheckBox
    Friend WithEvents grbPerisa As GroupBox
    Friend WithEvents chbPisang As CheckBox
    Friend WithEvents chbStrawberry As CheckBox
    Friend WithEvents dgwJadual As DataGridView
    Friend WithEvents clmBill As DataGridViewTextBoxColumn
    Friend WithEvents clmNama As DataGridViewTextBoxColumn
    Friend WithEvents clmTelefon As DataGridViewTextBoxColumn
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnRead As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents dtpTarikh As DateTimePicker
    Friend WithEvents lblTarikh As Label

End Class
