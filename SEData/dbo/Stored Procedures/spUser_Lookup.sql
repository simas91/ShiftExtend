﻿CREATE PROCEDURE [dbo].[spUser_Lookup]
	@Id nvarchar(128)
AS
begin
	set nocount on;

	select Id, FirstName, LastName, EmailAddress, CreatedDate, OP, RT
	from [dbo].[User]
	where Id = @Id
end