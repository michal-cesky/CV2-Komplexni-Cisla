﻿CREATE VIEW ahoj
	AS SELECT Zkratka, COUNT(StudentPredmet.IdStudent) AS pocet FROM Predmet LEFT JOIN StudentPredmet on StudentPredmet.ZkratkaPredmet = Predmet.Zkratka where Predmet.Zkratka IS NOT NULL  GROUP BY Predmet.Zkratka