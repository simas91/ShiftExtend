CREATE PROCEDURE [dbo].[spOvertimes_Test]
	@OvertimeDate date,
	@OP bit

AS
begin
	set nocount on;

	insert into dbo.Overtimes (OvertimeDate, OP)
	values (@OvertimeDate, @OP)
end
