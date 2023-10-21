CREATE TABLE [dbo].[BalanceSheet]
(
	[Id] INT NOT NULL PRIMARY KEY,
	account VARCHAR(100),
	asset INT,
	liabilities INT,
	capital INT,
	id_budgettingcosting INT,
	id_incomestatement INT,
	CONSTRAINT id_budgettingcosting FOREIGN KEY (id_budgettingcosting) REFERENCES [dbo].[BudgettingCosting](Id),
	CONSTRAINT id_labarugi2 FOREIGN KEY (id_incomestatement) REFERENCES [dbo].[IncomeStatement]([Id])
)
