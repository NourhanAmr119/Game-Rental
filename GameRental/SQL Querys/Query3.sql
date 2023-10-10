/*who was the renter(client) with the maximum renting last month?*/
SELECT TOP 1 Renter_id
FROM Renter
WHERE MONTH(Renting_date) = MONTH(DATEADD(month, -1, GETDATE()))
  AND YEAR(Renting_date) = YEAR(DATEADD(month, -1, GETDATE()))
GROUP BY Renter_id
ORDER BY COUNT(*) DESC;
