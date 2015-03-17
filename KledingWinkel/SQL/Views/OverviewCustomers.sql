SELECT     c.ID AS [Customer ID], c.Name AS [Customer Name], COUNT(o.OrderID) AS [No. orders], SUM(o.OrderTotalPrice) AS [Total earned]
FROM         dbo.Customer AS c INNER JOIN
                      dbo.CustomerOrder AS o ON c.ID = o.CustomerID
GROUP BY c.ID, c.Name, o.CustomerID
HAVING      (c.ID = o.CustomerID)