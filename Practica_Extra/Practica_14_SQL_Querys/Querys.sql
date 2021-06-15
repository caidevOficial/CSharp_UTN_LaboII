-- Select Database
using UTN;
-- Drop tables
drop table (Personas);
drop table (Envios);
drop table (Productos);

-- Create Tables
CREATE TABLE Envios(Numero int NOT NULL, pNumero int NOT NULL, Cantidad int NOT NULL) ON [PRIMARY];
CREATE TABLE Productos(pNumero int NOT NULL,pNombre varchar(30) NULL,Precio float NOT NULL,Tamanio varchar(20) NOT NULL, CONSTRAINT PK_Productos PRIMARY KEY CLUSTERED
(pNumero ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]) ON [PRIMARY];
CREATE TABLE Proveedores(Numero int NOT NULL, Nombre varchar(30) NULL, Domicilio varchar(50) NULL, Localidad varchar(80) NULL, CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(Numero ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]) ON [PRIMARY];

-- Insert Data
-- Proveedores
INSERT INTO Proveedores (Numero, Nombre, Domicilio, Localidad) VALUES (100, 'Perez', 'Perón 876', 'Quilmes');
INSERT INTO Proveedores (Numero, Nombre, Domicilio, Localidad) VALUES (101, 'Gimenez', 'Mitre 750', 'Avellaneda');
INSERT INTO Proveedores (Numero, Nombre, Domicilio, Localidad) VALUES (102, 'Aguirre', 'Boedo 634', 'Bernal');

-- Productos
INSERT INTO Productos (pNumero, pNombre, Precio, Tamanio) VALUES (1, 'Caramelos', 1.5, 'Chico');
INSERT INTO Productos (pNumero, pNombre, Precio, Tamanio) VALUES (2, 'Cigarrillos', 45.89, 'Mediano');
INSERT INTO Productos (pNumero, pNombre, Precio, Tamanio) VALUES (3, 'Gaseosa', 15.8, 'Grande');

-- Envios

INSERT INTO Envios (Numero, pNumero, Cantidad) VALUES (100, 1, 500);
INSERT INTO Envios (Numero, pNumero, Cantidad) VALUES (100, 2, 1500);
INSERT INTO Envios (Numero, pNumero, Cantidad) VALUES (100, 3, 100);
INSERT INTO Envios (Numero, pNumero, Cantidad) VALUES (101, 2, 55);
INSERT INTO Envios (Numero, pNumero, Cantidad) VALUES (101, 3, 225);
INSERT INTO Envios (Numero, pNumero, Cantidad) VALUES (102, 1, 600);
INSERT INTO Envios (Numero, pNumero, Cantidad) VALUES (102, 3, 300);

-- Querys
-- 1. Obtener los detalles completos de todos los productos, ordenados alfabéticamente.
SELECT * FROM productos ORDER BY pNombre;
-- 2. Obtener los detalles completos de todos los proveedores de ‘Quilmes’.
SELECT * FROM Proveedores WHERE Localidad='Quilmes';
-- 3. Obtener todos los envíos en los cuales la cantidad este entre 200 y 300 inclusive.
SELECT * FROM Envios WHERE Cantidad BETWEEN 200 AND 300;
-- 4. Obtener la cantidad total de todos los productos enviados.
SELECT SUM(Cantidad) FROM Envios;
-- 5. Mostrar los primeros 3 números de productos que se han enviado.
SELECT TOP 3 Numero FROM Envios;