USE [KledingWinkel]
GO
/****** Object:  StoredProcedure [dbo].[AddOrder]    Script Date: 18-3-2015 0:01:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Tom,de,Haan>
-- Create date: <17-03-2015>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[AddOrder](
@CUSTOMERID INT NULL
)
AS
BEGIN
INSERT INTO CustomerOrder 
VALUES(@CUSTOMERID,
0.00,
CONVERT(VARCHAR(11),GETDATE(),106))
END
