CREATE TABLE [dbo].[BudgettingCosting]
(
	[Id] INT NOT NULL PRIMARY KEY,
	account VARCHAR(100),
	quantity INT,
	price INT,
	id_generalentries INT,
	CONSTRAINT id_generalentries FOREIGN KEY (id_journal) REFERENCES GeneralEntries(id)
)
