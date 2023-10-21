Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class ConnectToDb
    'Database
    Private con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\Backup\General Ledger\General Ledger\general_ledger_old.mdf';Integrated Security=True")
    'Private con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\PUB 1220\source\repos\General Ledger\General Ledger\general_ledger.mdf';")
    Private cmd As SqlCommand
    Private rdr As SqlDataReader
    Private adp As SqlDataAdapter
    Private dS As New DataSet()
    Private table As New DataTable()
    Private results As String, queryCommand As String, no_account As String, id_general As String, account As String = "0", expenses As Integer = 0, income As Integer = 0, asset_account As String = "0", asset As String = "0", liabilities_account As String = "0", liabilities As String = "0", capital As String = "0", price As String = "0"

    Public Function GeneralEntries(trxDate As Date, invoice As String, account As String, noAcc As Integer, debt As Integer, credit As Integer)
        'Dim listLength As String = '0'
        'queryCommand = "select * from GeneralEntries where no_account = " + noAcc.ToString
        'cmd = New SqlCommand(queryCommand, con)
        'con.Open()
        'rdr = cmd.ExecuteReader
        'listLength = rdr("id")
        'MsgBox(listLength)
        'con.Close()

        'For i As Integer = 0 To listLength
        'queryCommand = "select * from GeneralEntries where id = " + i.ToString
        'con.Open()
        'cmd = New SqlCommand(queryCommand, con)
        'rdr = cmd.ExecuteReader
        'If rdr.Read() Then
        'o = 1
        'Else
        'o = 0
        'End If
        'con.Close()
        'Next i
        'If o = 1 Then
        'MessageBox.Show("Berhasil, Total " + listLength.ToString + " Data Dibaca")
        'End If
        'cmd = New SqlCommand("Select * from GeneralEntries where no_account = @noAcc", con)
        'cmd.Parameters.Add(New SqlParameter With {.ParameterName = "@noAcc", .SqlDbType = SqlDbType.Int, .Value = noAcc})
        'con.Open()
        'rdr = cmd.ExecuteReader
        'rdr.Read()
        'MessageBox.Show(rdr("no_account"))
        If account.Equals("") Or noAcc <= 0 Or (debt = 0 And credit = 0) Then
            MessageBox.Show("Isi Kolom Yang Kosong")
        Else
            Dim cmd = New SqlCommand("Insert into GeneralEntries values(@trxDate, @invoice, @account, @noAcc, @debt, @credit)", con)
            'cmd = New SqlCommand("Insert into GeneralEntries values(" + trxDate + ",'" + invoice + "','" + account + "'," + noAcc.ToString + "," + debt.ToString + "," + credit.ToString + ")", con)
            cmd.Parameters.Add(New SqlParameter With {.ParameterName = "@trxDate", .SqlDbType = SqlDbType.DateTime, .Value = trxDate})
            cmd.Parameters.Add(New SqlParameter With {.ParameterName = "@invoice", .SqlDbType = SqlDbType.VarChar, .Value = invoice})
            cmd.Parameters.Add(New SqlParameter With {.ParameterName = "@account", .SqlDbType = SqlDbType.VarChar, .Value = account})
            cmd.Parameters.Add(New SqlParameter With {.ParameterName = "@noAcc", .SqlDbType = SqlDbType.Int, .Value = noAcc})
            cmd.Parameters.Add(New SqlParameter With {.ParameterName = "@debt", .SqlDbType = SqlDbType.Int, .Value = debt})
            cmd.Parameters.Add(New SqlParameter With {.ParameterName = "@credit", .SqlDbType = SqlDbType.Int, .Value = credit})

            con.Open()
            cmd.ExecuteNonQuery()
            cmd = New SqlCommand("Select * from GeneralEntries where no_account = @noAcc", con)
            cmd.Parameters.Add(New SqlParameter With {.ParameterName = "@noAcc", .SqlDbType = SqlDbType.Int, .Value = noAcc})
            rdr = cmd.ExecuteReader
            rdr.Read()
            id_general = rdr("Id")
            MessageBox.Show("No " + id_general + " Tersimpan")
            IncomeStatement(account, credit, debt, id_general)
            'BalanceSheet(account, debt, credit)
            con.Close()
        End If
    End Function
    Public Function BudgettingCosting()
        'queryCommand = "Insert into BudgettingCosting values('" + account + "'," + price + ")"
    End Function
    Function IncomeStatement(account As String, expense As String, income As String, id_general As String)
        con.Close()
        con.Open()
        cmd = New SqlCommand("insert into IncomeStatement values('" + account + "'," + expense + "," + income + ", " + id_general + ")", con)
        cmd.ExecuteNonQuery()


        'Read data from sql/database

        'cmd = New SqlCommand("Select * from GeneralEntries where account like = '%Pend'", con)
        'rdr = cmd.ExecuteReader
        'rdr.Read()
        'account = rdr("account").ToString
        'MessageBox.Show(account)

    End Function
    Public Function BalanceSheet(assetAcc As String, asset As String, liabilities As String)
        'con.Close()
        'con.Open()
        'MsgBox("Insert into BalanceSheet values('" + assetAcc + "'," + asset + ",'tes'," + liabilities + ",0)")
        'cmd.ExecuteNonQuery()
    End Function

    Public Function getItem(v As Object, tableName As String, headerTitleSet As String, tableSet As String)
        dS.Clear()
        Dim fromTable As New SqlDataAdapter("Select " + headerTitleSet + " from " + tableName, con)
        fromTable.Fill(dS, tableSet)
        v.DataSource = dS.Tables(tableSet)
    End Function

    Public Sub FilterData(value As String, db As String, fname As String, obj As Object)
        Dim sQ As String = "Select * from " + db + " where concat(" + fname + ") like %" + value + "%"
        cmd = New SqlCommand()
        adp = New SqlDataAdapter(cmd)
        adp.Fill(table)

        obj.DataSource = table
    End Sub
    Public Sub ResetData(tableName As String)
        con.Open()
        queryCommand = "Delete from " + tableName
        cmd = New SqlCommand(queryCommand, con)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("DBCC CHECKIDENT (" + tableName + ",RESEED,1)", con)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("DBCC CHECKIDENT (" + tableName + ",RESEED,1)", con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Sub summaryData(sumDebt As Label, sumExp As Label)
        income = 0
        expenses = 0
        For i As Integer = 1 To 100
            queryCommand = "select * from GeneralEntries where id = " + i.ToString
            con.Open()
            cmd = New SqlCommand(queryCommand, con)
            rdr = cmd.ExecuteReader
            If rdr.Read() Then
                income += rdr("debt")
                expenses += rdr("credit")
            End If
            'MessageBox.Show(rdr("credit"))
            con.Close()
        Next i
        'If income > 100000 Then
        'sumDebt.Text = income.ToString.Substring(3) + "K"
        'sumExp.Text = expenses
        'Else
        sumDebt.Text = income
            sumExp.Text = expenses
        'End If
    End Sub
End Class
