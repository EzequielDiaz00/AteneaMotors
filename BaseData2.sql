USE AteneaMotors

CREATE TABLE DatosUsuario (
    
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
	Correo VARCHAR(50) NOT NULL,
    Telefono VARCHAR(15) NOT NULL
);

select * from DatosUsuario;

delete from DatosUsuario;