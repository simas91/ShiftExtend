CREATE TABLE [dbo].[Overtimes] (
    [Id]           INT      IDENTITY (1, 1) NOT NULL,
    [OvertimeDate] DATE     NOT NULL,
    [StartTime]    TIME (7) NOT NULL,
    [EndTime]      TIME (7) NOT NULL,
    [OP]           BIT      DEFAULT ((0)) NOT NULL,
    [CB]           BIT      DEFAULT ((0)) NOT NULL,
    [RT]           BIT      DEFAULT ((0)) NOT NULL,
    [Pack]         BIT      DEFAULT ((0)) NOT NULL
);