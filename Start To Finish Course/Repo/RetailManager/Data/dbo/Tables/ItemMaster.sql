CREATE TABLE [dbo].[ItemMaster]
(
	[ItemCode] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [ItemName] NVARCHAR(254) NOT NULL, 
    [Price] MONEY NOT NULL DEFAULT 0,
    [CreatedUserId] NVARCHAR(128) NOT NULL,
    [CreatedDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [ModifiedUserId] NVARCHAR(128) NOT NULL, 
    [ModifiedDate] DATETIME2 NOT NULL
)
