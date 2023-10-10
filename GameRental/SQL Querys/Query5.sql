/*who were the vendors whose games hadn't any renting last month?*/
SELECT Vendor.Vendor_id
FROM Vendor
JOIN Renter ON Renter.Renting_game= Vendor.Vendor_game
WHERE Renter.Renting_game NOT IN (
  SELECT Renter.Renting_game
  FROM Renter
  WHERE MONTH(Renter.Renting_date) = MONTH(DATEADD(month, -1, GETDATE()))
    AND YEAR(Renter.Renting_date) = YEAR(DATEADD(month, -1, GETDATE()))
)