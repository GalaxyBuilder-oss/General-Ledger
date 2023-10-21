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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button_add_generalentries = New System.Windows.Forms.Button()
        Me.transDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.invoice = New System.Windows.Forms.RichTextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.generalEntries_button = New System.Windows.Forms.TabPage()
        Me.noAccount = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.credit = New System.Windows.Forms.RichTextBox()
        Me.debt = New System.Windows.Forms.RichTextBox()
        Me.account = New System.Windows.Forms.RichTextBox()
        Me.budgetting_button = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RichTextBox5 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox6 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox7 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox8 = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.income_button = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SearchButtonData = New System.Windows.Forms.Button()
        Me.DataIncome = New System.Windows.Forms.DataGridView()
        Me.refresh_button = New System.Windows.Forms.Button()
        Me.balanceSheet_button = New System.Windows.Forms.TabPage()
        Me.reloadData = New System.Windows.Forms.Button()
        Me.DataBalance = New System.Windows.Forms.DataGridView()
        Me.butViewData = New System.Windows.Forms.Button()
        Me.bReset = New System.Windows.Forms.Button()
        Me.DataSetIncome = New System.Data.DataSet()
        Me.DataSetBalance = New System.Data.DataSet()
        Me.TabControl1.SuspendLayout()
        Me.generalEntries_button.SuspendLayout()
        Me.budgetting_button.SuspendLayout()
        Me.income_button.SuspendLayout()
        CType(Me.DataIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.balanceSheet_button.SuspendLayout()
        CType(Me.DataBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_add_generalentries
        '
        resources.ApplyResources(Me.Button_add_generalentries, "Button_add_generalentries")
        Me.Button_add_generalentries.Name = "Button_add_generalentries"
        Me.Button_add_generalentries.UseVisualStyleBackColor = True
        '
        'transDate
        '
        Me.transDate.Checked = False
        Me.transDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        resources.ApplyResources(Me.transDate, "transDate")
        Me.transDate.Name = "transDate"
        Me.transDate.Value = New Date(2023, 8, 25, 0, 0, 0, 0)
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'invoice
        '
        Me.invoice.DetectUrls = False
        resources.ApplyResources(Me.invoice, "invoice")
        Me.invoice.Name = "invoice"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.generalEntries_button)
        Me.TabControl1.Controls.Add(Me.budgetting_button)
        Me.TabControl1.Controls.Add(Me.income_button)
        Me.TabControl1.Controls.Add(Me.balanceSheet_button)
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'generalEntries_button
        '
        Me.generalEntries_button.BackColor = System.Drawing.Color.Yellow
        Me.generalEntries_button.Controls.Add(Me.noAccount)
        Me.generalEntries_button.Controls.Add(Me.Label8)
        Me.generalEntries_button.Controls.Add(Me.credit)
        Me.generalEntries_button.Controls.Add(Me.debt)
        Me.generalEntries_button.Controls.Add(Me.account)
        Me.generalEntries_button.Controls.Add(Me.invoice)
        Me.generalEntries_button.Controls.Add(Me.Button_add_generalentries)
        Me.generalEntries_button.Controls.Add(Me.transDate)
        Me.generalEntries_button.Controls.Add(Me.Label5)
        Me.generalEntries_button.Controls.Add(Me.Label1)
        Me.generalEntries_button.Controls.Add(Me.Label4)
        Me.generalEntries_button.Controls.Add(Me.Label2)
        Me.generalEntries_button.Controls.Add(Me.Label3)
        resources.ApplyResources(Me.generalEntries_button, "generalEntries_button")
        Me.generalEntries_button.Name = "generalEntries_button"
        '
        'noAccount
        '
        Me.noAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.noAccount, "noAccount")
        Me.noAccount.Name = "noAccount"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'credit
        '
        Me.credit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.credit, "credit")
        Me.credit.Name = "credit"
        '
        'debt
        '
        Me.debt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.debt, "debt")
        Me.debt.Name = "debt"
        '
        'account
        '
        Me.account.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.account.DetectUrls = False
        resources.ApplyResources(Me.account, "account")
        Me.account.Name = "account"
        '
        'budgetting_button
        '
        Me.budgetting_button.BackColor = System.Drawing.Color.Yellow
        Me.budgetting_button.Controls.Add(Me.Label12)
        Me.budgetting_button.Controls.Add(Me.Label6)
        Me.budgetting_button.Controls.Add(Me.RichTextBox5)
        Me.budgetting_button.Controls.Add(Me.RichTextBox6)
        Me.budgetting_button.Controls.Add(Me.RichTextBox7)
        Me.budgetting_button.Controls.Add(Me.RichTextBox8)
        Me.budgetting_button.Controls.Add(Me.Button2)
        Me.budgetting_button.Controls.Add(Me.Label7)
        Me.budgetting_button.Controls.Add(Me.Label9)
        Me.budgetting_button.Controls.Add(Me.Label10)
        Me.budgetting_button.Controls.Add(Me.Label11)
        resources.ApplyResources(Me.budgetting_button, "budgetting_button")
        Me.budgetting_button.Name = "budgetting_button"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'RichTextBox5
        '
        Me.RichTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.RichTextBox5, "RichTextBox5")
        Me.RichTextBox5.Name = "RichTextBox5"
        '
        'RichTextBox6
        '
        Me.RichTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.RichTextBox6, "RichTextBox6")
        Me.RichTextBox6.Name = "RichTextBox6"
        '
        'RichTextBox7
        '
        Me.RichTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.RichTextBox7, "RichTextBox7")
        Me.RichTextBox7.Name = "RichTextBox7"
        '
        'RichTextBox8
        '
        Me.RichTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.RichTextBox8, "RichTextBox8")
        Me.RichTextBox8.Name = "RichTextBox8"
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'income_button
        '
        Me.income_button.BackColor = System.Drawing.Color.Yellow
        Me.income_button.Controls.Add(Me.RichTextBox1)
        Me.income_button.Controls.Add(Me.SearchButtonData)
        Me.income_button.Controls.Add(Me.DataIncome)
        Me.income_button.Controls.Add(Me.refresh_button)
        resources.ApplyResources(Me.income_button, "income_button")
        Me.income_button.Name = "income_button"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.RichTextBox1, "RichTextBox1")
        Me.RichTextBox1.Name = "RichTextBox1"
        '
        'SearchButtonData
        '
        resources.ApplyResources(Me.SearchButtonData, "SearchButtonData")
        Me.SearchButtonData.Name = "SearchButtonData"
        Me.SearchButtonData.UseVisualStyleBackColor = True
        '
        'DataIncome
        '
        Me.DataIncome.AllowUserToAddRows = False
        Me.DataIncome.AllowUserToResizeColumns = False
        Me.DataIncome.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataIncome.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.DataIncome, "DataIncome")
        Me.DataIncome.MultiSelect = False
        Me.DataIncome.Name = "DataIncome"
        Me.DataIncome.ReadOnly = True
        Me.DataIncome.RowHeadersVisible = False
        Me.DataIncome.RowTemplate.Height = 24
        Me.DataIncome.TabStop = False
        '
        'refresh_button
        '
        resources.ApplyResources(Me.refresh_button, "refresh_button")
        Me.refresh_button.Name = "refresh_button"
        Me.refresh_button.UseVisualStyleBackColor = True
        '
        'balanceSheet_button
        '
        Me.balanceSheet_button.BackColor = System.Drawing.Color.Yellow
        Me.balanceSheet_button.CausesValidation = False
        Me.balanceSheet_button.Controls.Add(Me.reloadData)
        Me.balanceSheet_button.Controls.Add(Me.DataBalance)
        resources.ApplyResources(Me.balanceSheet_button, "balanceSheet_button")
        Me.balanceSheet_button.Name = "balanceSheet_button"
        '
        'reloadData
        '
        resources.ApplyResources(Me.reloadData, "reloadData")
        Me.reloadData.Name = "reloadData"
        Me.reloadData.UseVisualStyleBackColor = True
        '
        'DataBalance
        '
        Me.DataBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.DataBalance, "DataBalance")
        Me.DataBalance.Name = "DataBalance"
        Me.DataBalance.RowTemplate.Height = 28
        '
        'butViewData
        '
        Me.butViewData.BackColor = System.Drawing.Color.YellowGreen
        Me.butViewData.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.butViewData, "butViewData")
        Me.butViewData.Name = "butViewData"
        Me.butViewData.UseVisualStyleBackColor = False
        '
        'bReset
        '
        Me.bReset.BackColor = System.Drawing.Color.Red
        Me.bReset.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.bReset, "bReset")
        Me.bReset.ForeColor = System.Drawing.Color.White
        Me.bReset.Name = "bReset"
        Me.bReset.UseVisualStyleBackColor = False
        '
        'DataSetIncome
        '
        Me.DataSetIncome.DataSetName = "NewDataSet"
        '
        'DataSetBalance
        '
        Me.DataSetBalance.DataSetName = "NewDataSet"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.Controls.Add(Me.bReset)
        Me.Controls.Add(Me.butViewData)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.generalEntries_button.ResumeLayout(False)
        Me.generalEntries_button.PerformLayout()
        Me.budgetting_button.ResumeLayout(False)
        Me.budgetting_button.PerformLayout()
        Me.income_button.ResumeLayout(False)
        CType(Me.DataIncome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.balanceSheet_button.ResumeLayout(False)
        CType(Me.DataBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetIncome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetBalance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_add_generalentries As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents invoice As RichTextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents generalEntries_button As TabPage
    Friend WithEvents balanceSheet_button As TabPage
    Friend WithEvents budgetting_button As TabPage
    Friend WithEvents income_button As TabPage
    Friend WithEvents credit As RichTextBox
    Friend WithEvents debt As RichTextBox
    Friend WithEvents account As RichTextBox
    Friend WithEvents RichTextBox5 As RichTextBox
    Friend WithEvents RichTextBox6 As RichTextBox
    Friend WithEvents RichTextBox7 As RichTextBox
    Friend WithEvents RichTextBox8 As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents refresh_button As Button
    Friend WithEvents transDate As DateTimePicker
    Friend WithEvents noAccount As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents butViewData As Button
    Friend WithEvents bReset As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataIncome As DataGridView
    Friend WithEvents DataSetIncome As DataSet
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents SearchButtonData As Button
    Friend WithEvents reloadData As Button
    Friend WithEvents DataBalance As DataGridView
    Friend WithEvents DataSetBalance As DataSet
End Class
