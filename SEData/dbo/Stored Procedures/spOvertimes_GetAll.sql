CREATE PROCEDURE [dbo].[spOvertimes_GetAll]
AS
begin
	set nocount on;

	select [Id], [OvertimeDate], [StartTime], [EndTime], [OP], [CB], [RT], [Pack]
	from dbo.Overtimes
end
