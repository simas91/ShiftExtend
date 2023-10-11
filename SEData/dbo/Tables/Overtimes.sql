CREATE TABLE [dbo].[Overtimes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [OvertimeDate] DATE NULL, 
    [StartTime] TIME NULL, 
    [EndTime] TIME NULL, 
    [OP] BIT NOT NULL DEFAULT ((0)), 
    [CB] BIT NULL DEFAULT ((0)), 
    [RT] BIT NULL DEFAULT ((0)), 
    [Pack] BIT NULL DEFAULT ((0))
)
