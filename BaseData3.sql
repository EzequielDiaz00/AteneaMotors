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
values ('admin', 'admin2020');


select * from DatosUsuario;

create table DatosdeRegistrados (
	ID INT PRIMARY KEY IDENTITY,
    usuario NVARCHAR(100),
	correo NVARCHAR(100),
    contraseña NVARCHAR(100)
);

select * from DatosdeRegistrados;

create table PruebaManejo (
	ID INT PRIMARY KEY IDENTITY,
	Nombre NVARCHAR(100),
	Apellido NVARCHAR(100),
	Correo NVARCHAR(100),
	Telefono NVARCHAR(50),
	Auto NVARCHAR(50),
	Fecha DATE
);

select * from PruebaManejo;

insert into PruebaManejo(Fecha)
values ('2024-04-19');

delete from PruebaManejo;

drop table PruebaManejo;