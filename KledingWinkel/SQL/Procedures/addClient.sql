USE [KledingWinkel]
GO
/****** Object:  StoredProcedure [dbo].[AddClient]    Script Date: 17-3-2015 23:59:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Tom,de,Haan>
-- Create date: <17-03-2015>
-- Description:	<Description,,>
-- =============================================
ALTER Procedure [dbo].[AddClient](
@Name varchar(50),
@Streetname varchar(50),
@StreetNr INT,
@CityName varchar(50),
@CountryName varchar(50),
@ZippCode varchar(12)
)
AS
BEGIN
INSERT INTO Customer VALUES(@Name,@Streetname,@Streetnr,@CityName,@CountryName ,@ZippCode)
END