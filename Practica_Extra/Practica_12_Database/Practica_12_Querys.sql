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
 
-- Querys
-- DB
USE RepasoBD

-- Drops
DROP TABLE Customers;
DROP TABLE Localidad;
DROP TABLE Provincia;

-- Creates
CREATE TABLE Customers(	id bigint IDENTITY(1,1) NOT NULL,	Name varchar(50) NULL,	Surname varchar(50) NULL,	Age int NOT NULL, CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED (id ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]) ON [PRIMARY]
CREATE TABLE Localidad(id numeric(18, 0) IDENTITY(1,1) NOT NULL, idProvincia numeric(18, 0) NOT NULL, Nombre varchar(100) NOT NULL) ON [PRIMARY]
CREATE TABLE [dbo].[Provincia](id numeric(18, 0) NOT NULL,	descripcion varchar(100) NULL) ON [PRIMARY]

-- Inserts
insert into Customers (Name, Surname, Age) values ('Stacy', 'Loachhead', 33); 
insert into Customers (Name, Surname, Age) values ('Eartha', 'Marthen', 87); 
insert into Customers (Name, Surname, Age) values ('Mela', 'Trinkwon', 88); 
insert into Customers (Name, Surname, Age) values ('Penrod', 'Spowage', 69);
insert into Customers (Name, Surname, Age) values ('Elbert', 'Biermatowicz', 88); 
insert into Customers (Name, Surname, Age) values ('Kirsten', 'Levane', 23); 
insert into Customers (Name, Surname, Age) values ('Juana', 'Goodin', 19); 
insert into Customers (Name, Surname, Age) values ('Kirstyn', 'Peinton', 70); 
insert into Customers (Name, Surname, Age) values ('Lisha', 'Tulleth', 83); 
insert into Customers (Name, Surname, Age) values ('Dedra', 'Kinig', 90); 
insert into Customers (Name, Surname, Age) values ('Becka', 'Pahlsson', 15); 
insert into Customers (Name, Surname, Age) values ('Corene', 'Moakler', 77); 
insert into Customers (Name, Surname, Age) values ('Gweneth', 'Beveridge', 53); 
insert into Customers (Name, Surname, Age) values ('Brendan', 'Cordle', 88); 
insert into Customers (Name, Surname, Age) values ('Joceline', 'Goter', 25); 
insert into Customers (Name, Surname, Age) values ('Suki', 'Cossans', 26); 
insert into Customers (Name, Surname, Age) values ('Ava', 'Helix', 87); 
insert into Customers (Name, Surname, Age) values ('Jo ann', 'Valintine', 62); 
insert into Customers (Name, Surname, Age) values ('Pennie', 'Kelson', 45); 
insert into Customers (Name, Surname, Age) values ('Erda', 'Levet', 80);
