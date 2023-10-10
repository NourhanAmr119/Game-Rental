/*what was the most interesting game that had maximum number of renters(clients)?*/
SELECT	Name
FROM Game
WHERE Renters_no = (SELECT MAX(Renters_no) FROM Game);