-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE OverviewOrderItemDetails(
@OrderID INT,
@OrderItemID INT
)
AS
BEGIN
SELECT ks.KledingStukID, ks.Text, ks.JasType, ks.Size, ks.Merk, ks.Price FROM Customer_OrderItem coi
INNER JOIN KledingStuk ks ON ks.KledingStukID = coi.KledingStukID
INNER JOIN CustomerOrder co ON co.OrderID = coi.OrderID
WHERE co.OrderID = @OrderID AND coi.OrderItemID = @OrderItemID

END
