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
        Me.dg_kelas = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Jurusan = New System.Windows.Forms.Label()
        Me.txt_nama_kelas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_kd_kelas = New System.Windows.Forms.TextBox()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        CType(Me.dg_kelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg_kelas
        '
        Me.dg_kelas.AllowUserToAddRows = False
        Me.dg_kelas.AllowUserToDeleteRows = False
        Me.dg_kelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_kelas.Location = New System.Drawing.Point(12, 12)
        Me.dg_kelas.Name = "dg_kelas"
        Me.dg_kelas.ReadOnly = True
        Me.dg_kelas.RowTemplate.Height = 25
        Me.dg_kelas.Size = New System.Drawing.Size(478, 426)
        Me.dg_kelas.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Jurusan)
        Me.GroupBox1.Controls.Add(Me.txt_nama_kelas)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_kd_kelas)
        Me.GroupBox1.Controls.Add(Me.btn_hapus)
        Me.GroupBox1.Controls.Add(Me.btn_edit)
        Me.GroupBox1.Controls.Add(Me.btn_tambah)
        Me.GroupBox1.Location = New System.Drawing.Point(500, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 427)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FORM"
        '
        'Jurusan
        '
        Me.Jurusan.AutoSize = True
        Me.Jurusan.Location = New System.Drawing.Point(17, 103)
        Me.Jurusan.Name = "Jurusan"
        Me.Jurusan.Size = New System.Drawing.Size(69, 15)
        Me.Jurusan.TabIndex = 6
        Me.Jurusan.Text = "Nama Kelas"
        '
        'txt_nama_kelas
        '
        Me.txt_nama_kelas.Location = New System.Drawing.Point(17, 130)
        Me.txt_nama_kelas.Name = "txt_nama_kelas"
        Me.txt_nama_kelas.Size = New System.Drawing.Size(356, 23)
        Me.txt_nama_kelas.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Kode Kelas"
        '
        'txt_kd_kelas
        '
        Me.txt_kd_kelas.Location = New System.Drawing.Point(17, 62)
        Me.txt_kd_kelas.Name = "txt_kd_kelas"
        Me.txt_kd_kelas.Size = New System.Drawing.Size(356, 23)
        Me.txt_kd_kelas.TabIndex = 3
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(265, 360)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(108, 42)
        Me.btn_hapus.TabIndex = 2
        Me.btn_hapus.Text = "HAPUS"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(142, 360)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(108, 42)
        Me.btn_edit.TabIndex = 1
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(17, 360)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(108, 42)
        Me.btn_tambah.TabIndex = 0
        Me.btn_tambah.Text = "TAMBAH"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dg_kelas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dg_kelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dg_kelas As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Jurusan As Label
    Friend WithEvents txt_nama_kelas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_kd_kelas As TextBox
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_tambah As Button
End Class
