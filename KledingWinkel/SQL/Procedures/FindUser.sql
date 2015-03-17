USE [KledingWinkel]
GO
/****** Object:  StoredProcedure [dbo].[FindUser]    Script Date: 18-3-2015 0:19:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Tom,de,Haan>
-- Create date: <17-03-2015>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[FindUser](
@Name varchar(50)
)
AS
BEGIN
SELECT C.ID, C.Name, (C.StreetName + ' ' + C.StreetNumber) "Street address", C.City, C.ZippCode ,C.Country 
FROM Customer C
WHERE c.Name = @Name
END
