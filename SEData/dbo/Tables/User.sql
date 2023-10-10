CREATE TABLE [dbo].[User]
(
    [Id] NVARCHAR(128) NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [EmailAddress] NVARCHAR(256) NOT NULL, 
    [OP] BIT NOT NULL DEFAULT ((0)), 
    [RT] BIT NOT NULL DEFAULT ((0)), 
    [CB] BIT NOT NULL DEFAULT ((0)), 
    [Pack] BIT NOT NULL DEFAULT ((0)), 
    [FirstAider] BIT NOT NULL DEFAULT ((0)), 
    [FireWarden] BIT NOT NULL DEFAULT ((0)), 
    [CreatedDate] DATETIME2 NOT NULL DEFAULT getutcdate()
)
