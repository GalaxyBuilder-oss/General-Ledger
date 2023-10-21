Imports System.Data.SqlClient
Public Class viewData
    Private condb As New ConnectToDb()
    Private Sub viewData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelData.Text = "Jurnal Umum"
        condb.getItem(DataGridView1, "GeneralEntries", "trx_date as Tanggal, invoice as 'No. AJP', account as 'Nama Akun', no_account as 'No. Akun',debt as Debit, credit as Kredit", "i")
        condb.summaryData(sumDebt, sumIncome)
    End Sub
    Private Sub Close_Click(sender As Object, e As EventArgs) Handles closep.Click
        Me.Hide()
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex >= 0 Or e.RowIndex > 0 Then
            MessageBox.Show(DataGridView1.CurrentCell.Value, DataGridView1.Columns(e.ColumnIndex).HeaderText)
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub labelData_Click(sender As Object, e As EventArgs) Handles labelData.Click

    End Sub
End Class