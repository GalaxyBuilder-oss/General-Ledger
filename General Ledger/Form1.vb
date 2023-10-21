Imports System.Data.SqlClient
Public Class Form1
    'Deklarasi variable
    Private id_generalentries As Integer, noAcc As Integer, debt_field As Integer, credit_field As Integer
    Private trxDate As String
    Private inv As Char
    Private acc As String
    Private checkMenu As Integer

    'Connect Ke database
    Private dbCon As New ConnectToDb()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dbCon.getItem(DataIncome, "IncomeStatement", "account as 'Nama Akun', income as Pendapatan, expense as Beban")
        'dbCon.getItem(DataBalance, "BalanceSheet", "asset_account as 'Nama Akun', asset as Asset, libilities as Liabilitas")
    End Sub
    Private Sub SearchButtonData_Click(sender As Object, e As EventArgs) Handles SearchButtonData.Click
    End Sub

    Private Sub refresh_button_Click(sender As Object, e As EventArgs) Handles refresh_button.Click
        dbCon.getItem(DataIncome, "IncomeStatement", "account as 'Nama Akun', income as Pendapatan, expense as Beban", "i")
    End Sub

    Private Sub reloadData_Click(sender As Object, e As EventArgs) Handles reloadData.Click
        'dbCon.getItem(DataBalance, "BalanceSheet", "asset_account as 'Nama Akun', asset as Asset, libilities as Liabilitas", "b")
    End Sub

    Private Sub bReset_Click(sender As Object, e As EventArgs) Handles bReset.Click
        dbCon.ResetData("BalanceSheet")
        dbCon.ResetData("BudgettingCosting")
        dbCon.ResetData("IncomeStatement")
        dbCon.ResetData("GeneralEntries")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_add_generalentries.Click
        dbCon.GeneralEntries(transDate.Value.Date, invoice.Text, account.Text, noAccount.Text, debt.Text, credit.Text)
        dbCon.getItem(DataIncome, "IncomeStatement", "account as 'Nama Akun', income as Pendapatan, expense as Beban", "i")
    End Sub
    Private Sub viewData_Click(sender As Object, e As EventArgs) Handles butViewData.Click
        viewData.ShowDialog()
        viewData.BringToFront()
    End Sub
End Class
