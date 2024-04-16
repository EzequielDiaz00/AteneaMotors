use AteneaMotors;

create table Proveedores (
	ID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Descripcion NVARCHAR(100),
    Marca NVARCHAR(50),
    Direccion NVARCHAR(100),
    Telefono NVARCHAR(50),
    Tipo NVARCHAR(50)
);

select * from Proveedores;

delete from Proveedores;

create table UsuarioAdmin (
	ID INT PRIMARY KEY IDENTITY,
    usuario NVARCHAR(100),
    contrasena NVARCHAR(100)
);

select * from UsuarioAdmin;

insert into UsuarioAdmin (usuario, contrasena)
values ('admin', 'admin');


select * from DatosUsuario;