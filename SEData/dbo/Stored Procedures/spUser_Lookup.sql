CREATE PROCEDURE [dbo].[spUser_Lookup]
	@Id nvarchar(128)
AS
begin
	set nocount on;

	select FirstName, LastName, EmailAddress, OP, RT, CB, Pack, FirstAider, FireWarden
	from [dbo].[User]
	where Id = @Id
end