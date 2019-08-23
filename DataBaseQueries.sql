/*

•	Написать запрос, отображающий список покупателей, 
которые заказывали один и тот же продукт более 3-х раз за указанный период времени. 
Запрос должен отображать наименование покупателя, наименование продукта и количество раз, которое данный продукт был заказан. 
Отсортировать запрос по полю, которое отображает количество раз закупленного продукта. (0-30 баллов)

*/

DECLARE @startDate DATETIME = CONVERT(DATETIME,'1996-07-05');   
DECLARE @endDate DATETIME = CONVERT(DATETIME,'1999-05-05');   

    WITH Orders_CTE (CustomerID,ProductID, Quantity)  
    AS  
    (  
		SELECT o.CustomerID,od.ProductID,COUNT(od.OrderID) AS Quantity FROM [dbo].[Order Details] od
		LEFT JOIN [dbo].[Orders] o ON od.OrderID = o.OrderID
			WHERE o.OrderDate BETWEEN  @startDate AND @endDate
			GROUP BY od.ProductID, o.CustomerID  
			HAVING COUNT(od.OrderID) > 3
    )
    SELECT c.CompanyName,p.ProductName, cte.Quantity
    FROM Orders_CTE cte
	LEFT JOIN [dbo].Products p ON p.ProductID = cte.ProductID 
	LEFT JOIN [dbo].Customers c ON c.CustomerID = cte.CustomerID
    ORDER BY cte.Quantity DESC
	 

/*
•	Написать запрос, который отображает список объектов БД NorthWind, 
в которых встречается заданный фрагмент текста. 
Запрос должен отображать наименование объекта и его тип. (0-20 баллов)
*/

DECLARE @searchText varchar(200) = 'Employees';

SELECT name,type FROM sys.objects 
WHERE name LIKE '%' +@SearchText+'%';