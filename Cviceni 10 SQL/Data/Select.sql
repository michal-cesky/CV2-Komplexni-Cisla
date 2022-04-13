
 SELECT Name, Surname, Subjects.SubjectName FROM Students LEFT JOIN Subjects ON Subjects.Id = Students.IdStudent;

SELECT Surname, Count(SurName) as NamesCount FROM Students GROUP BY SurName ORDER BY COUNT (SurName) DESC;

SELECT Shortcut, COUNT(Shortcut) as StudentsInSubject FROM Subjects GROUP BY Shortcut HAVING COUNT(Shortcut) < 3 AND Shortcut IS NOT NULL  ORDER BY Shortcut DESC;

 SELECT Subjects.Shortcut, COUNT(Subjects.Shortcut) as StudentNumber, MAX(Marks.Mark) as MaxVal, MIN(Marks.Mark) as MinVal, AVG(Marks.Mark) as AvgVal 
	FROM Subjects LEFT JOIN Marks ON Subjects.Id = Marks.IDStudent GROUP BY Subjects.Shortcut HAVING Subjects.Shortcut IS NOT NULL ORDER BY StudentNumber DESC;