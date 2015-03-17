SELECT     dbo.CustomerOrder.OrderID, dbo.Customer.Name, dbo.CustomerOrder.OrderTotalPrice, dbo.CustomerOrder.OrderDate
FROM         dbo.CustomerOrder INNER JOIN
                      dbo.Customer ON dbo.CustomerOrder.CustomerID = dbo.Customer.ID