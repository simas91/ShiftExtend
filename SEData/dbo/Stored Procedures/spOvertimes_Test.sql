CREATE PROCEDURE [dbo].[spOvertimes_Test]
	@OvertimeDate date,
	@StartTime time,
	@OP bit

AS
begin
	set nocount on;

	insert into dbo.Overtimes (OvertimeDate, StartTime, OP)
	values (@OvertimeDate, @StartTime, @OP)
end
