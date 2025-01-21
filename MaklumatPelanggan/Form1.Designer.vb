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
        Label1 = New Label()
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
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        BtnCreate = New Button()
        BtnRead = New Button()
        BtnUpdate = New Button()
        BtnDelete = New Button()
        grbJantina.SuspendLayout()
        grbKaedahbayar.SuspendLayout()
        grbPerisa.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.Location = New Point(212, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(402, 46)
        Label1.TabIndex = 0
        Label1.Text = "MAKLUMAT PELANGGAN"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(45, 97)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(49, 20)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(100, 94)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(255, 27)
        txtNama.TabIndex = 2
        ' 
        ' lblTelefon
        ' 
        lblTelefon.AutoSize = True
        lblTelefon.Location = New Point(12, 150)
        lblTelefon.Name = "lblTelefon"
        lblTelefon.Size = New Size(85, 20)
        lblTelefon.TabIndex = 3
        lblTelefon.Text = "No. Telefon"
        ' 
        ' txtTelefon
        ' 
        txtTelefon.Location = New Point(100, 147)
        txtTelefon.Name = "txtTelefon"
        txtTelefon.Size = New Size(255, 27)
        txtTelefon.TabIndex = 4
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(37, 195)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(57, 20)
        lblAlamat.TabIndex = 5
        lblAlamat.Text = "Alamat"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(100, 195)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(255, 138)
        txtAlamat.TabIndex = 6
        ' 
        ' lblNegeri
        ' 
        lblNegeri.AutoSize = True
        lblNegeri.Location = New Point(41, 362)
        lblNegeri.Name = "lblNegeri"
        lblNegeri.Size = New Size(54, 20)
        lblNegeri.TabIndex = 7
        lblNegeri.Text = "Negeri"
        ' 
        ' cobNegeri
        ' 
        cobNegeri.FormattingEnabled = True
        cobNegeri.Items.AddRange(New Object() {"Kedah", "Perlis", "Pahang", "Perak", "Melaka", "Pulau Pinang", "Selangor", "Kuala Lumpur", "Sabah", "Sarawak"})
        cobNegeri.Location = New Point(100, 362)
        cobNegeri.Name = "cobNegeri"
        cobNegeri.Size = New Size(255, 28)
        cobNegeri.TabIndex = 8
        ' 
        ' grbJantina
        ' 
        grbJantina.Controls.Add(rabPerempuan)
        grbJantina.Controls.Add(rabLelaki)
        grbJantina.Location = New Point(467, 97)
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
        grbKaedahbayar.Location = New Point(467, 195)
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
        grbPerisa.Location = New Point(467, 291)
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
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        DataGridView1.Location = New Point(12, 409)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(432, 155)
        DataGridView1.TabIndex = 14
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Bil"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Nama"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "No.telefon"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' BtnCreate
        ' 
        BtnCreate.Location = New Point(555, 435)
        BtnCreate.Name = "BtnCreate"
        BtnCreate.Size = New Size(94, 29)
        BtnCreate.TabIndex = 15
        BtnCreate.Text = "Create"
        BtnCreate.UseVisualStyleBackColor = True
        ' 
        ' BtnRead
        ' 
        BtnRead.Location = New Point(738, 435)
        BtnRead.Name = "BtnRead"
        BtnRead.Size = New Size(94, 29)
        BtnRead.TabIndex = 16
        BtnRead.Text = "Read"
        BtnRead.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Location = New Point(555, 508)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(94, 29)
        BtnUpdate.TabIndex = 17
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(738, 508)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(94, 29)
        BtnDelete.TabIndex = 18
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(927, 576)
        Controls.Add(BtnDelete)
        Controls.Add(BtnUpdate)
        Controls.Add(BtnRead)
        Controls.Add(BtnCreate)
        Controls.Add(DataGridView1)
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
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        grbJantina.ResumeLayout(False)
        grbJantina.PerformLayout()
        grbKaedahbayar.ResumeLayout(False)
        grbKaedahbayar.PerformLayout()
        grbPerisa.ResumeLayout(False)
        grbPerisa.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnRead As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button

End Class
