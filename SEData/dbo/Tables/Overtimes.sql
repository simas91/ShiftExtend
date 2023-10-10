CREATE TABLE [dbo].[Overtimes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [OvertimeDate] DATE NOT NULL, 
    [StartTime] TIME NOT NULL, 
    [EndTime] TIME NOT NULL, 
    [OP] BIT NOT NULL DEFAULT ((0)), 
    [CB] BIT NOT NULL DEFAULT ((0)), 
    [RT] BIT NOT NULL DEFAULT ((0)), 
    [Pack] BIT NOT NULL DEFAULT ((0)),
    [FirstAider] BIT NOT NULL DEFAULT ((0)),
    [FireWarden] BIT NOT NULL DEFAULT ((0))
)
