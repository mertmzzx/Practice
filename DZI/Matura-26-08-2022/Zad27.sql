CREATE DATABASE School

CREATE TABLE Students (
     Id INT PRIMARY KEY,
	 [Name] VARCHAR(150),
	 BEL INT,
	 English INT,
	 Math INT,
	 Informatics INT,
	 IT INT
	 )

INSERT INTO Students
     (Id, Name, BEL, English, Math, Informatics, IT)
VALUES
     (1, 'Антония Колева', 4, 5, 6, 5, 4),
	 (2, 'Асен Ангелов', 5, 5, 6, 4, 5),
	 (3, 'Борислав Ганев', 4, 4, 5, 5, 6),
	 (4, 'Бояна Тодорова', 5, 6, 6, 6, 6),
	 (5, 'Валери Илиев', 6, 6, 6, 6, 6)

SELECT *
FROM Students
WHERE Id = 4

SELECT COUNT(Id)
FROM Students
WHERE Math = 6 AND Informatics = 6 AND IT = 6

SELECT AVG(BEL) AS BEL, AVG(Math) AS Math -- CEILING()???
FROM Students

SELECT [Name], ROUND((BEL + Math + English + Informatics + IT) / 5.0, 2) AS Grade
FROM Students
ORDER BY Grade DESC, [Name] ASC