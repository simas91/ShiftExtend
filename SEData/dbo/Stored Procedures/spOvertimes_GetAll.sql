CREATE PROCEDURE [dbo].[spOvertimes_GetAll]
AS
begin
	set nocount on;

	select [Id], [OvertimeDate], [StartTime], [EndTime], [OP], [CB], [RT], [Pack], [FirstAider], [FireWarden]
	from dbo.Overtimes
end
