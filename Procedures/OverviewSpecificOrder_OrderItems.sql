USE [KledingWinkel]
GO
/****** Object:  StoredProcedure [dbo].[OverviewSpecificOrders]    Script Date: 18-3-2015 0:03:59 ******/
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
@OrderID INT
AS
BEGIN
SELECT     dbo.Customer_OrderItem.OrderID AS [Order ID], dbo.Customer_OrderItem.OrderItemID AS [Order Line], dbo.Customer_OrderItem.KledingStukID AS [Clothing ID], 
                      dbo.Customer_OrderItem.OrderItemPrice AS [Clothing Price], dbo.Customer_OrderItem.OrderedAmount AS Amount, 
                      SUM(dbo.Customer_OrderItem.OrderedAmount * dbo.Customer_OrderItem.OrderItemPrice) AS [Total Price]
FROM         dbo.Customer_OrderItem INNER JOIN
                      dbo.KledingStuk ON dbo.Customer_OrderItem.KledingStukID = dbo.KledingStuk.KledingStukID
GROUP BY dbo.Customer_OrderItem.OrderID, dbo.Customer_OrderItem.OrderItemID, dbo.Customer_OrderItem.KledingStukID, dbo.Customer_OrderItem.OrderItemPrice, 
                      dbo.Customer_OrderItem.OrderedAmount
HAVING      (dbo.Customer_OrderItem.OrderID = @OrderID)
END
