CREATE TABLE [dbo].[Sales]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [NumSeries] INT NOT NULL DEFAULT 1, 
    [Status] CHAR NOT NULL DEFAULT 'O',
    [SalesDate] DATETIME2 NOT NULL, 
    [SubTotal] MONEY NOT NULL, 
    [Discount] MONEY NOT NULL, 
    [Tax] MONEY NOT NULL, 
    [Total] MONEY NOT NULL, 
    [CreatedUserId] NVARCHAR(128) NOT NULL, 
    [CreatedDate] DATETIME2 NOT NULL DEFAULT getutcdate()
)
