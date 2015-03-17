USE [KledingWinkel]
GO
/****** Object:  StoredProcedure [dbo].[FindUserWithID]    Script Date: 18-3-2015 0:18:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Tom,de,Haan>
-- Create date: <17-03-2015>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[FindUserWithID](
@ID INT
)
AS
BEGIN
SELECT C.ID, C.Name, (C.StreetName + ' ' + C.StreetNumber) "Street address", C.City, C.ZippCode ,C.Country 
FROM Customer C
WHERE c.ID = @ID
END
