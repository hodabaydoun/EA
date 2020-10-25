IF EXISTS (SELECT 1 FROM sysobjects WHERE xtype = 'P' and name = 'cars_get')
	DROP PROC addon_getAll
GO
CREATE PROCEDURE [dbo].cars_get
	@start int = 0,
	@end int
AS
BEGIN
		SELECT *
		FROM dbo.car c WITH (NOLOCK)
		JOIN dbo.auction ad WITH (NOLOCK) ON c.id = ad.carId
		ORDER BY	c.id
		OFFSET		@start ROWS 
		FETCH NEXT	@end ROWS ONLY
		
END
GO