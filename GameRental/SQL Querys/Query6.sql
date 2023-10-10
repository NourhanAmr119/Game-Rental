/*who were the vendors who didn't add any game last year?*/
SELECT Vendor.Vendor_id
FROM Vendor
WHERE YEAR(Vendor.Developing_date) = YEAR(GETDATE())
  AND Vendor.Vendor_id NOT IN (
    SELECT DISTINCT Vendor_ID
    FROM Vendor
    WHERE YEAR(Developing_date) = YEAR(DATEADD(year, -1, GETDATE()))
  )
  group by Vendor.Vendor_id