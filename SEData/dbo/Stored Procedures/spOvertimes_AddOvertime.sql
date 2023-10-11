CREATE PROCEDURE [dbo].[spOvertimes_AddOvertime]
	@OvertimeDate date,
	@StartTime time,
	@EndTime time,
	@OP bit,
	@CB bit,
	@RT bit,
	@Pack bit

AS
begin
	set nocount on;

	insert into dbo.Overtimes (OvertimeDate, StartTime, EndTime, OP, CB, RT, Pack)
	values (@OvertimeDate, @StartTime, @EndTime, @OP, @CB, @RT, @Pack)
end
