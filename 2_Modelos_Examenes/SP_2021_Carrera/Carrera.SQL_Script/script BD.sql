USE MASTER
GO
CREATE DATABASE [20210717-RSP]
GO
USE [20210717-RSP]
GO
CREATE TABLE [dbo].[resultados](
	[idposiciones] [int] IDENTITY(1,1) NOT NULL,
	[escuderia] [varchar](50) NOT NULL,
	[posicion] [int] NOT NULL,
	[horaLlegada] [varchar](50) NOT NULL,
 CONSTRAINT [PK_resultados] PRIMARY KEY CLUSTERED 
(
	[idposiciones] ASC
))

