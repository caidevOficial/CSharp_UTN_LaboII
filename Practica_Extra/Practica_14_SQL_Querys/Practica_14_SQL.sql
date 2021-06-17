/*
 * MIT License
 * 
 * Copyright (c) 2021 [FacuFalcone]
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */
 -- Select Database
USE UTN;

-- Drop tables
DROP TABLE Proveedores;
DROP TABLE Envios;
DROP TABLE Productos;

-- Create Tables
IF NOT EXISTS CREATE TABLE Envios(Numero int NOT NULL, pNumero int NOT NULL, Cantidad int NOT NULL) ON [PRIMARY];
CREATE TABLE Productos(pNumero int NOT NULL,pNombre varchar(30) NULL,Precio float NOT NULL,Tamanio varchar(20) NOT NULL, CONSTRAINT PK_Productos PRIMARY KEY CLUSTERED (pNumero ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]) ON [PRIMARY];
CREATE TABLE Proveedores(Numero int NOT NULL, Nombre varchar(30) NULL, Domicilio varchar(50) NULL, Localidad varchar(80) NULL, CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED (Numero ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]) ON [PRIMARY];

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
SELECT * AS De_Quilmes FROM Proveedores WHERE Localidad='Quilmes';

-- 3. Obtener todos los envíos en los cuales la cantidad este entre 200 y 300 inclusive.
SELECT * FROM Envios WHERE Cantidad BETWEEN 200 AND 300;

-- 4. Obtener la cantidad total de todos los productos enviados.
SELECT SUM(Cantidad) FROM Envios;

-- 5. Mostrar los primeros 3 números de productos que se han enviado.
SELECT TOP 3 Numero FROM Envios;

-- 6. Mostrar los nombres de proveedores y los nombres de los productos enviados.
SELECT P.Nombre, Pr.pNombre from Proveedores AS P, Productos AS Pr, Envios AS E WHERE Pr.pNumero = E.pNumero AND P.Numero = E.Numero;

-- 7. Indicar el monto (cantidad * precio) de todos los envíos.
SELECT E.Numero as ENVIO, (E.Cantidad*P.Precio) AS PRECIO FROM Envios AS E, Productos AS P WHERE E.pNumero = P.pNumero;

-- 8. Obtener la cantidad total del producto 1 enviado por el proveedor 102.
SELECT SUM(Cantidad) AS Cantidad_Producto_1 FROM Envios AS E WHERE pNumero = 1 AND E.Numero = 102;

-- 9. Obtener todos los números de los productos suministrados por algún proveedor de ‘Avellaneda’.
SELECT pNumero AS De_Avellaneda FROM Envios AS E, Proveedores AS P WHERE E.Numero = P.Numero AND P.Localidad = 'Avellaneda';

-- 10.Obtener los domicilios y localidades de los proveedores cuyos nombres contengan la letra ‘I’.
SELECT Domicilio, Localidad FROM Proveedores AS P WHERE P.Nombre LIKE '%i%';

-- 11.Agregar el producto numero 4, llamado ‘Chocolate’, de tamaño chico y con un precio de 25,35.
INSERT INTO Productos (pNumero, pNombre, Precio, Tamanio) VALUES (4, 'Chocolate', 25.35, 'Chico');

-- 12.Insertar un nuevo proveedor (únicamente con los campos obligatorios).
INSERT INTO Proveedores (Numero, Nombre, Domicilio, Localidad) VALUES (103, 'Simpson', 'Falsa 123', 'Springfield');

-- 13.Insertar un nuevo proveedor (107), donde el nombre y la localidad son ‘Rosales’ y ‘La Plata’.
INSERT INTO Proveedores (Numero, Nombre, Domicilio, Localidad) VALUES (107, 'Rosales', 'Diagonal 8', 'La Plata');

-- 14.Cambiar los precios de los productos de tamaño ‘grande’ a 97,50.
UPDATE Productos SET Precio = 97.5 WHERE Tamanio = 'Grande';

-- 15.Cambiar el tamaño de ‘Chico’ a ‘Mediano’ de todos los productos cuyas cantidades sean mayores a 300 inclusive.
UPDATE Productos SET Tamanio = 'Mediano' WHERE Tamanio = 'Chico';

-- 16.Eliminar el producto número 1.
DELETE FROM Productos WHERE pNumero = 1;

-- 17.Eliminar a todos los proveedores que no han enviado productos.
DELETE FROM Proveedores WHERE NOT EXISTS (SELECT * FROM Envios AS E WHERE E.Numero = Proveedores.Numero);