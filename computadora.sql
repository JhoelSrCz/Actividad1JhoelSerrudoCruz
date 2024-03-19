CREATE DATABASE COMPUTADORAS

CREATE TABLE Computadora (
IdComputadora INT IDENTITY (1,1) NOT NULL,
Nombre NVARCHAR (50) NOT NULL,
Descripcion NVARCHAR (50) NOT NULL,
Precio MONEY NOT NULL,
FechaFabricacion DATETIME NOT NULL,
PRIMARY KEY (IdComputadora),
);