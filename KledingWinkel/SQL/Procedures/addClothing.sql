USE [KledingWinkel]
GO
/****** Object:  StoredProcedure [dbo].[AddClothing]    Script Date: 18-3-2015 0:01:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Tom,de,Haan>
-- Create date: <17-03-2015>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[AddClothing](
@Text varchar(50) null,
@CoatType varchar(50) null,
@ImageURL varchar(max) null,
@ClothingSize varchar(10) null,
@ClothingBrand varchar(50) null,
@AmountInStock INT null,
@ClothingPrice decimal(18,2) null,
@ISInStock bit null
)
AS
BEGIN
INSERT INTO KledingStuk VALUES(@Text,@ClothingPrice,@AmountInStock,@ImageURL,@ClothingSize,@ClothingBrand,@CoatType,@ISInStock)
END
