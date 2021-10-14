CREATE TABLE [dbo].[SalesDetails]
(
	[Id] INT NOT NULL, 
    [LineNum] INT NOT NULL DEFAULT 0, 
    [LineStatus] CHAR(1) NOT NULL DEFAULT 'O', 
    [ItemCode] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(254) NOT NULL, 
    [Price] MONEY NOT NULL, 
    [Discount] MONEY NOT NULL, 
    [Tax] MONEY NOT NULL, 
    [Quantity] FLOAT NOT NULL
)
