CREATE TABLE [dbo].[OvertimeBookings]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] NVARCHAR(128) NOT NULL, 
    [OvertimeId] INT NOT NULL, 
    [OvertimeDate] Date NOT NULL,
    [StartTime] TIME NOT NULL, 
    [EndTime] TIME NOT NULL, 
    [OP] BIT NOT NULL DEFAULT ((0)), 
    [CB] BIT NOT NULL DEFAULT ((0)), 
    [RT] BIT NOT NULL DEFAULT ((0)), 
    [Pack] BIT NOT NULL DEFAULT ((0)), 
    [Over60Hours] BIT NOT NULL DEFAULT ((0)), 
    [Comments] NVARCHAR(100) NULL, 
    [OvertimeStatus] VARCHAR(10) NOT NULL, 
    CONSTRAINT [FK_OvertimeBookings_Overtimes] FOREIGN KEY (OvertimeId) REFERENCES Overtimes(Id), 
    CONSTRAINT [FK_OvertimeBookings_User] FOREIGN KEY (UserId) REFERENCES [User](Id)
)