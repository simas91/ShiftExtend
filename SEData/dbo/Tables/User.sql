CREATE TABLE [dbo].[User] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [AuthUserId]    NVARCHAR (450) NOT NULL,
    [FirstName]     NVARCHAR (50)  NOT NULL,
    [LastName]      NVARCHAR (50)  NOT NULL,
    [Employer]      NVARCHAR (10)  NOT NULL,
    [OP]            BIT            DEFAULT ((0)) NOT NULL,
    [CB]            BIT            DEFAULT ((0)) NOT NULL,
    [RT]            BIT            DEFAULT ((0)) NOT NULL,
    [Pack]          BIT            DEFAULT ((0)) NOT NULL,
    [FirstAider]    BIT            DEFAULT ((0)) NOT NULL,
    [FireWarden]    BIT            DEFAULT ((0)) NOT NULL, 
    [CreatedDate] DATETIME2 NOT NULL DEFAULT getutcdate(),
);