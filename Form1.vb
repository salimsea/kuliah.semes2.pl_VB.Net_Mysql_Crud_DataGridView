Public Class Form1
    Sub TampilGrid()
        Dim no As Integer
        Me.dg_kelas.Rows.Clear()
        openDB()
        rec.Open("SELECT * FROM tb_kelas", conn, 3, 2)
        no = 1
        Do While Not rec.EOF
            Me.dg_kelas.Rows.Add(no, rec.Fields("nama_kelas").Value)
            rec.MoveNext()
            no = no + 1
        Loop
        closeDB()
    End Sub
    Sub TextClear()
        txt_kd_kelas.Text = ""
        txt_nama_kelas.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim judul() As String = {"No", "Nama Kelas"}
        Dim lebar() As String = {50, 350}
        Dim i As Integer
        dg_kelas.RowHeadersVisible = False
        dg_kelas.ColumnCount = 2
        dg_kelas.RowCount = 1
        dg_kelas.SelectionMode = DataGridViewSelectionMode.CellSelect
        dg_kelas.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 18)

        For i = 0 To dg_kelas.ColumnCount - 1
            dg_kelas.Columns(i).HeaderText = judul(i)
            dg_kelas.Columns(i).Width = lebar(i)
            dg_kelas.Columns(i).DefaultCellStyle.Font = New Font("Arial", 12)
            dg_kelas.Columns(i).DefaultCellStyle.BackColor = Color.AliceBlue
        Next
        TampilGrid()
    End Sub

    Private Sub dg_kelas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_kelas.CellClick
        Dim selectedRowIndex As Integer
        selectedRowIndex = e.RowIndex
        Dim row As New DataGridViewRow()

        row = dg_kelas.Rows(selectedRowIndex)
        Dim kd_kelas, nama_kelas As String
        kd_kelas = row.Cells(0).Value.ToString()
        nama_kelas = row.Cells(1).Value.ToString()

        txt_kd_kelas.Text = kd_kelas
        txt_nama_kelas.Text = nama_kelas
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Dim sql, kd_kelas, nama_kelas As String
        kd_kelas = txt_kd_kelas.Text
        nama_kelas = txt_nama_kelas.Text

        If kd_kelas = "" Or nama_kelas = "" Then
            MessageBox.Show("Masukan data yang benar!", "Info")
        End If

        openDB()
        sql = "INSERT INTO tb_kelas VALUES('" & kd_kelas & "', '" & nama_kelas & "')"
        conn.Execute(sql)
        closeDB()

        TampilGrid()
        TextClear()
    End Sub
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim sql, kd_kelas, nama_kelas As String
        kd_kelas = txt_kd_kelas.Text
        nama_kelas = txt_nama_kelas.Text

        If kd_kelas = "" Or nama_kelas = "" Then
            MessageBox.Show("Masukan data yang benar!", "Info")
        End If

        openDB()
        sql = "UPDATE tb_kelas SET nama_kelas = '" & nama_kelas & "' WHERE kd_kelas = '" & kd_kelas & "' "
        conn.Execute(sql)
        closeDB()

        TampilGrid()
        TextClear()
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim sql, kd_kelas, nama_kelas As String
        kd_kelas = txt_kd_kelas.Text
        nama_kelas = txt_nama_kelas.Text

        If kd_kelas = "" Or nama_kelas = "" Then
            MessageBox.Show("Masukan data yang benar!", "Info")
        End If

        Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ingin hapus data (" + nama_kelas + ")", "Info", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            openDB()
            sql = "DELETE FROM tb_kelas WHERE kd_kelas = '" & kd_kelas & "' AND nama_kelas = '" & nama_kelas & "' "
            conn.Execute(sql)
            closeDB()

            TampilGrid()
            TextClear()
            MessageBox.Show("Data berhasil dihapus!", "Info")
        End If
    End Sub
End Class
