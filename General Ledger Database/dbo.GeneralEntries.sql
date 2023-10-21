CREATE TABLE [dbo].[GeneralEntries]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[trx_date] DATE,
	invoice CHAR(5),
	account VARCHAR(100),
	no_account INT(3),
	debt INT,
	credit INT
)
