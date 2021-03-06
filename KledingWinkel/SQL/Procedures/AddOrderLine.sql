USE [KledingWinkel]
GO
/****** Object:  StoredProcedure [dbo].[AddOrderLine]    Script Date: 18-3-2015 0:00:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Tom,de,Haan>
-- Create date: <17-03-2015>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[AddOrderLine](
@OrderID INT,
@ClothingID INT,
@Amount INT
)
AS
BEGIN
INSERT INTO Customer_OrderItem VALUES(
@OrderID,@Amount,@ClothingID,
(SELECT ks.Price FROM KledingStuk ks
 WHERE ks.KledingStukID = @ClothingID),
(SELECT SUM(ks.Price * @Amount) FROM KledingStuk ks
 WHERE ks.KledingStukID = @ClothingID))
END
UPDATE CustomerOrder SET CustomerOrder.OrderTotalPrice = (
SELECT SUM(coItem.OrderLineTotal) FROM Customer_OrderItem coItem
WHERE coItem.OrderID = @OrderID)
WHERE CustomerOrder.OrderID = @OrderID
