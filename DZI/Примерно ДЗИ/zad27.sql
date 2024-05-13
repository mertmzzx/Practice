CREATE DATABASE pastry_shop

-- 27.1
CREATE TABLE types_sweets (
     id INT PRIMARY KEY,
	 types_name VARCHAR(100),
	 description VARCHAR(150)
	 )

CREATE TABLE sweets (
     id INT PRIMARY KEY,
	 name VARCHAR(100),
	 availability INT,
	 price DECIMAL(7,2),
	 types_id INT,
	 FOREIGN KEY (types_id) REFERENCES types_sweets(id)
	 )

-- 27.2
INSERT INTO types_sweets(id, types_name, description)
VALUES
      (1, 'Cake', 'Traditional cakes for special occasions'),
	  (2, 'Tart', 'Crispy crusts filled with sweet fruit filling'),
	  (3, 'Cupcake', 'Single-serving cakes topped with frosting'),
	  (4, 'Muffin', 'Individual baked goods, often with fruit'),
	  (5, 'Pastry', 'Flaky pastries filled with cream or fruit')

INSERT INTO sweets(id, name, availability, price, types_id)
VALUES
      (1, 'Lemon Tart', 8, 18, 2),
	  (2, 'Red Velvet Cupcake', 20, 4, 3),
	  (3, 'Strawberry Shortcake', 5, 30, 1),
	  (4, 'Blueberry Muffin', 15, 3.80, 4),
	  (5, 'Vanilla Cream Puff', 12, 3.20, 5),
	  (6, 'Chocolate Cake', 10, 25, 1)

-- 27.3
SELECT name, availability
FROM sweets
WHERE price BETWEEN 10 AND 18
ORDER BY price

-- 27.4
SELECT name, price, types_name
FROM sweets AS s
   LEFT JOIN types_sweets AS ts ON ts.id = s.types_id

-- 27.5
SELECT types_name, SUM(price)
FROM types_sweets AS ts
    LEFT JOIN sweets AS s ON ts.id = s.types_id
GROUP BY types_name

-- 27.6
SELECT name, types_name, (price * availability) * 1.2
FROM sweets AS s
    LEFT JOIN types_sweets AS ts ON s.types_id = ts.id
