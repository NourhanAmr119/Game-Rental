/*who was the vendor with the maximum renting out last month?*/
SELECT Vendor.Vendor_ID
FROM Vendor
WHERE Vendor.Vendor_game NOT IN (
  SELECT Renter.Renting_game
  FROM Renter
  WHERE MONTH(Renter.Renting_date) = MONTH(DATEADD(month, -1, GETDATE()))
    AND YEAR(Renter.Renting_date) = YEAR(DATEADD(month, -1, GETDATE()))
)
GROUP BY Vendor.Vendor_id;
