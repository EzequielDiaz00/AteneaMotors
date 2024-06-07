create database AteneaMotors;

use AteneaMotors;

CREATE TABLE Autos (
    ID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Descripcion NVARCHAR(MAX),
    Anio INT,
    Color NVARCHAR(50),
    ImagenUrl NVARCHAR(MAX),
    Tipo NVARCHAR(50)
);

select * from Autos;

DELETE FROM Autos;