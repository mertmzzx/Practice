CREATE DATABASE OnlineShop

USE OnlineShop

-- 1)
CREATE TABLE Laptops (
      Id INT PRIMARY KEY IDENTITY,
	  Make VARCHAR(100) NOT NULL,
	  Model VARCHAR(50) NOT NULL,
	  Quantity INT,
	  Price DECIMAL(7,2)
	  )

-- 2)
INSERT INTO Laptops (Make, Model, Quantity, Price)
VALUES
     ('Laptop1', 'L29KAS', 10, 1100),
	 ('Laptop2', '15FDR7', 14, 1350),
	 ('Laptop1', 'L29GTA', 12, 1500),
	 ('Laptop1', 'L29DFT', 8, 1499),
	 ('Laptop2', '15FDM5', 11, 1600)

-- 3)
DELETE 
FROM Laptops
WHERE Model = '15FDR7'

-- 4)
SELECT Model, (Quantity * Price) * 1.2 AS TotalPrice
FROM Laptops

-- 5)
SELECT Make, Sum(Quantity) AS SumOfQuantity
FROM Laptops
WHERE Make = 'Laptop1'
GROUP BY Make
