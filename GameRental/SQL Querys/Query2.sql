/*what were the games that hadn't any renters(clients) last month?*/
SELECT Game.Name
FROM Game
WHERE Game.Name NOT IN (
  SELECT Renter.Renting_game
  FROM Renter
  WHERE MONTH(Renter.Renting_date) = MONTH(DATEADD(month, -1, GETDATE()))
    AND YEAR(Renter.Renting_date) = YEAR(DATEADD(month, -1, GETDATE()))
)