SELECT CONCAT([First Name],' ',[Last Name]) AS FullName, [Birth Date],(CAST(GETDATE() AS INTEGER) - CAST([Birth Date] AS INTEGER))/365  FROM Kids
WHERE (CAST(GETDATE() AS INTEGER) - CAST([Birth Date] AS INTEGER))/365 > 3

SELECT CONCAT([First Name],' ',[Last Name]) AS FullName, COUNT([Colour]) FROM Kids, Toys
WHERE Toys.[Colour] = 'blue'
AND Kids.[Id] = Toys.[Kid Id]
GROUP BY CONCAT([First Name],' ',[Last Name])
HAVING COUNT(Toys.[Colour]) > 2

 SELECT CONCAT([First Name], ' ',[Last Name]) AS [Full Name], COUNT(Toys.[Kid Id]) FROM Kids, Toys
WHERE (CAST(GETDATE() AS INTEGER) - CAST([Birth Date] AS INTEGER))/365 < 5
 GROUP BY CONCAT([First Name], ' ',[Last Name])
 HAVING COUNT(Toys.[Kid Id])>1


