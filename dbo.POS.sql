CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [LastName] NVARCHAR(50) NULL, 
    [FirstName] NCHAR(10) NULL, 
    [AddressId] INT NULL, 
    [EmailAddress] NVARCHAR(MAX) NULL
)
