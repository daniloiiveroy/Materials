CREATE TABLE [dbo].[Inventory]
(
	[ItemCode] NVARCHAR(50) NOT NULL, 
    [PurchaseDate] DATETIME2 NULL, 
    [PurchasePrice] MONEY NOT NULL DEFAULT 0, 
    [Quantity] NCHAR(10) NOT NULL DEFAULT 0
)
