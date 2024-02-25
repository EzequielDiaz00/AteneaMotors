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

INSERT INTO Autos (Nombre, Descripcion, Anio, Color, ImagenUrl, Tipo)
VALUES ('Ford Focus', 'Sedán compacto', 2022, 'Azul', 'https://hips.hearstapps.com/hmg-prod/images/2021-ford-focus-st-line-outdoor-01-1634201978.jpg?crop=0.495xw:0.815xh;0.239xw,0.115xh&resize=1200:*', 'Sedan');

DELETE FROM Autos;