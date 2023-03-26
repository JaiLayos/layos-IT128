CREATE PROCEDURE [dbo].[spItem_List]
AS
begin
	set nocount on;
	SELECT [i].[OrderID], [i].[Code], [i].[Name] , [i].[Brand] , [i].[UnitPrice] , [i].[DateOrdered]
	from dbo.Item i
end
