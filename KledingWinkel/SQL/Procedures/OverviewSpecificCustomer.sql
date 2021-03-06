USE [KledingWinkel]
GO
/****** Object:  StoredProcedure [dbo].[OverviewSpecificCustomer]    Script Date: 18-3-2015 0:57:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Tom,de,Haan>
-- Create date: <17-03-2015>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[OverviewSpecificCustomer](
@CustomerID INT
)
AS
SELECT c.ID, c.Name,(CONCAT(c.StreetName , ' ' , c.StreetNumber)) AS "Street Address", c.City, c.ZippCode, c.Country FROM Customer c
WHERE c.ID = @CustomerID