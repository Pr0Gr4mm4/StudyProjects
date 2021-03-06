USE [KledingWinkel]
GO
/****** Object:  StoredProcedure [dbo].[OverviewSpecificOrders]    Script Date: 18-3-2015 2:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Tom,de,Haan>
-- Create date: <17-03-2015>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[OverviewSpecificOrders]
@OrderID INT,
@OrderItemID INT OUT,
@OrderItemClothingID INT OUT,
@OrderItemClothingPrice decimal OUT,
@OrderItemClothingAmount INT OUT,
@OrderItemTotalPrice decimal OUT
AS
SELECT @OrderID = coi.OrderID, @OrderItemID = coi.OrderItemID, @OrderItemClothingID = coi.KledingStukID ,@OrderItemClothingAmount = coi.OrderedAmount ,
@OrderItemClothingPrice = coi.OrderItemPrice,
 @OrderItemTotalPrice = coi.OrderLineTotal
FROM dbo.Customer_OrderItem coi
WHERE coi.OrderID = @OrderID