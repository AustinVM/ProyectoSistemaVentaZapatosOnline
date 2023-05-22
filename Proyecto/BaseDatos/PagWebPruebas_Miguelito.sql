CREATE DATABASE PagWebPruebas

USE PagWebPruebas

ALTER AUTHORIZATION ON DATABASE::PagWebPruebas TO sa

	-- Tablas

CREATE TABLE rol (
	id INT IDENTITY ( 1 , 1 ) PRIMARY KEY,
	nombre VARCHAR (20) NOT NULL,
	estado BIT NOT NULL DEFAULT 1
)

CREATE TABLE usuario (
	id INT IDENTITY ( 1 , 1 ) PRIMARY KEY,
	usuario VARCHAR (50) NOT NULL UNIQUE,
	contrasenia VARCHAR (100) NOT NULL,
	ID_rol INT NOT NULL FOREIGN KEY REFERENCES rol (id) ON UPDATE CASCADE,
	estado BIT NOT NULL DEFAULT 1
)

CREATE TABLE tipoDocumento (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (50) NOT NULL,
	estado BIT NOT NULL DEFAULT 1
)

CREATE TABLE iva (
	id INT IDENTITY (1,1) PRIMARY KEY,
	iva VARCHAR (5) NOT NULL ,
	estado BIT NOT NULL DEFAULT 1
)

CREATE TABLE categoria (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (5) NOT NULL,
	descripcion VARCHAR (100),
	descuento INT NOT NULL,
	estado BIT NOT NULL DEFAULT 1
)

CREATE TABLE tipoCliente (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (50) NOT NULL,
	estado BIT NOT NULL DEFAULT 1
)

CREATE TABLE departamento (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (100) NOT NULL,
	estado BIT NOT NULL DEFAULT 1
)

CREATE TABLE municipio (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (100) NOT NULL,
	ID_departamento INT NOT NULL FOREIGN KEY REFERENCES departamento (id) ON DELETE NO ACTION ON UPDATE CASCADE,
	estado BIT NOT NULL DEFAULT 1
)

CREATE TABLE color (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (100) NOT NULL,
	estado BIT NOT NULL DEFAULT 1
)

CREATE TABLE tallas (
	id INT IDENTITY (1,1) PRIMARY KEY,
	talla VARCHAR (2) NOT NULL,
	estado BIT NOT NULL DEFAULT 1
)

CREATE TABLE coleccion (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (100) NOT NULL,
	epoca VARCHAR (50) NOT NULL,
	estado BIT NOT NULL DEFAULT 1
)

CREATE TABLE material (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (100) NOT NULL,
	estado BIT NOT NULL DEFAULT 1
)

CREATE TABLE tipoCalzado (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (100) NOT NULL,
	estado BIT NOT NULL DEFAULT 1
)

CREATE TABLE tipoPago (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre VARCHAR (100) NOT NULL,
	estado BIT NOT NULL DEFAULT 1
)

CREATE TABLE cliente (
	numID VARCHAR (20) PRIMARY KEY,
	id_tipoDocumento INT NOT NULL FOREIGN KEY REFERENCES tipoDocumento (id) ON DELETE NO ACTION ON UPDATE CASCADE,
	nombres VARCHAR (100) NOT NULL,
	apellidos VARCHAR (100) NOT NULL,
	fchNac DATE NOT NULL,
	direccion VARCHAR (100) NOT NULL,
	telefono VARCHAR (10) NOT NULL,
	correoElectronico VARCHAR (100) UNIQUE NOT NULL,
	contrasenia VARCHAR (100) NOT NULL,
	ID_tipoCliente INT NOT NULL FOREIGN KEY REFERENCES tipoCliente (id) ON DELETE NO ACTION ON UPDATE CASCADE,
	ID_municipio INT NOT NULL FOREIGN KEY REFERENCES municipio (id) ON DELETE NO ACTION ON UPDATE CASCADE,
	ID_categoria INT NOT NULL FOREIGN KEY REFERENCES categoria (id) ON DELETE NO ACTION ON UPDATE CASCADE,
	estado BIT NOT NULL DEFAULT 1
)

CREATE TABLE empresa (
	numIDCliente VARCHAR (20) NOT NULL FOREIGN KEY REFERENCES cliente (numID) ON DELETE NO ACTION ON UPDATE CASCADE UNIQUE,
	NIT VARCHAR (20) NOT NULL UNIQUE,
	PRIMARY KEY (numIDCliente, NIT),
	nombreEmpresa VARCHAR (100) NOT NULL,
	dirBodega VARCHAR (100) NOT NULL,
	estado BIT NOT NULL DEFAULT 1
)

CREATE TABLE producto (
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombreProd VARCHAR (100) NOT NULL,
	ID_color INT NOT NULL FOREIGN KEY REFERENCES color (id) ON DELETE NO ACTION ON UPDATE CASCADE,
	ID_coleccion INT NOT NULL FOREIGN KEY REFERENCES coleccion (id) ON DELETE NO ACTION ON UPDATE CASCADE,
	ID_material INT NOT NULL FOREIGN KEY REFERENCES material (id) ON DELETE NO ACTION ON UPDATE CASCADE,
	ID_tipoCAlzado INT NOT NULL FOREIGN KEY REFERENCES tipoCalzado (id) ON DELETE NO ACTION ON UPDATE CASCADE,
	estado BIT NOT NULL DEFAULT 1
);

CREATE TABLE producto_talla (
	id INT IDENTITY (1,1) PRIMARY KEY,
	ID_producto INT NOT NULL FOREIGN KEY REFERENCES producto (id) ON DELETE NO ACTION ON UPDATE CASCADE,
	ID_talla INT NOT NULL FOREIGN KEY REFERENCES tallas (id) ON DELETE NO ACTION ON UPDATE CASCADE,	
	valUnitario INT NOT NULL,
	cant SMALLINT NOT NULL,
	estado BIT NOT NULL DEFAULT 1
);

CREATE TABLE detallesFactura (
	id INT IDENTITY (1,1) PRIMARY KEY,
	ID_producto_talla INT NOT NULL FOREIGN KEY REFERENCES producto_talla (id) ON DELETE NO ACTION ON UPDATE CASCADE UNIQUE,
	descripcion VARCHAR (100),
	ID_tipoPago INT NOT NULL FOREIGN KEY REFERENCES tipoPago (id),
	ID_iva INT NOT NULL FOREIGN KEY REFERENCES iva (id),
	subtotal INT NOT NULL,
	total INT NOT NULL
);

CREATE TABLE factura (
	id INT IDENTITY (1,1) PRIMARY KEY,
	fchExpedicion DATETIME NOT NULL,
	ID_cliente VARCHAR (20) NOT NULL FOREIGN KEY REFERENCES cliente (numID),
	ID_detallesFactura INT NOT NULL FOREIGN KEY REFERENCES detallesFactura (id) UNIQUE,
	ID_municipio INT NOT NULL FOREIGN KEY REFERENCES municipio (id)
);
GO

-----PROCEDIMINETOS ---------

----ROL----

---mostrar----

create proc MostarRol--mostrar toda la tabla
as
select*from rol
go

create proc MostrarNombreRol --muestra solo el nombre 
@id int,
@nombre varchar(20)
as
select nombre from rol where id=@id
go

/* create proc BuscarRol--busca por el id o por el nombre y muestra el nombre
@id int,
@nombre varchar(20),
@estado bit
as
select nombre from rol where id!=@id and nombre=@nombre
go */ -- Procedimiento sin sentido



--INSERTAR---
CREATE proc InsertarRol
@id INT ,
@nombre VARCHAR (20),
@estado BIT 
as
INSERT INTO rol VALUES (@id, @nombre, @estado)
go

---editar ----
create proc EditarRol
@id int,
@nombre varchar(20),
@estado bit
as
update rol set nombre=@nombre, estado=@estado where id = @id and estado = @estado
go

---eliminar -----
create proc EliminarRol
@id int
as
delete rol where id = @id
go


 ----- PROCESOS DE USUARIOS----
 
 --MOSTRAR---
 create proc MostrarUsuario
  as
  select*from usuario
GO

  create proc MostrarDatosUsuario
	@usuario varchar (50),
	@Contrasenia varchar (50)
	as
	select usuario,contrasenia from usuario where usuario=@usuario and contrasenia=@Contrasenia and estado=1
	go

create proc BuscarUsuario
@id varchar (50),
@usuario varchar (50)
as
select usuario from usuario where id=@id or usuario=@usuario and estado=1
GO

create proc BuscarEditarUsuario
@id varchar (50),
@usuario varchar (50)
as
select usuario from usuario where id!=@id or usuario=@usuario and estado=1
GO

create proc BuscarIDUsuario
@id int
as
select usuario,estado from usuario where id=@id and estado=1
go

--inicio sesion--
create proc Buscar_Usuario
@usuario varchar(50)
as
select id from usuario where usuario=@usuario and estado=1
GO

---insertar ---
create proc InsertarUsuario
@id INT,
@usuario VARCHAR (50) ,
@contrasenia VARCHAR (100),
@estado BIT
as
insert into usuario values(@id,@usuario,@contrasenia,@estado)
go
---eliminar---

CREATE PROC EliminarUsuario
@id INT 
AS
DELETE usuario
WHERE id = @id and estado=1
go

---editar----

create proc EditarUsuario
@id INT,
@usuario VARCHAR (50) ,
@contrasenia VARCHAR (100),
@estado BIT
as
UPDATE usuario SET usuario = @usuario, contrasenia = @contrasenia
WHERE id = @id and estado=1
GO

create proc EditarContrasenia
@id int,
@contrasenia varchar(100)
as
update usuario set contrasenia=@contrasenia where id=@id and estado=1
go


---tipoDocumento---


---mostrar ----
create proc MostrarTipoDocumento
as
select*from tipoDocumento
go

create proc BuscarTipoDocumento
@id int
as
select nombre from tipoDocumento where id=@id and estado=1
GO
----actualizar---
create proc EditarTipoDocumento
@id int,
@nombre varchar(50),
@estado bit
as
update tipoDocumento set nombre=@nombre,estado=@estado where id=@id and estado=1
GO
---insertar---
create proc InsertarTipoDocumento
@nombre varchar(50),
@estado bit
as
insert into tipoDocumento values(@nombre,@estado) 
GO
---elininar---
create proc EliminarTipoDocumento
@id int
as
delete tipoDocumento where id=@id and estado=1
GO

-- iva----


---mostar
create proc MostrarIva
as
select*from iva 
go

create proc BuscarIva
@id int
as
select iva from iva where id=@id and estado=1
go
----actualizar---
create proc EditarIva
@id int,
@iva varchar(5),
@estado bit
as
update iva set iva=@iva,estado=@estado where id=@id and estado=1
go

---insertar---
create proc InsertarIva
@id int,
@iva varchar(5),
@estado bit
as
insert into iva values(@iva,@estado) 
---elininar---
create proc EliminarIva
@id int
as
delete iva where id=@id and estado=1


---categoria---



create proc MostrarCategoria
as
select*from categoria

create proc MostarNombreCategoria
@id int
as
select nombre from categoria where id=@id and estado=1


----actualizar---
create proc EditarCategoria
@id int,
@nombre varchar(5),
@descripcion varchar (100),
@estado bit
as
update categoria set id=@id,nombre=@nombre,descripcion=@descripcion, estado=@estado where id=@id and estado=1

---insertar---
create proc InsertarCategoria
@id int,
@nombre varchar(5),
@descripcion varchar (100),
@estado bit
as
insert into categoria values(@id,@nombre,@descripcion,@estado) 
---elininar---
create proc EliminarCategoria
@id int
as
delete categoria where id=@id and estado=1


----tipoCliente



create proc MostarTipoCliente
as
select*from tipoCliente

create proc MostrarNombreTipoCliente
@id int
as
select nombre from tipoCliente

create proc EditarTipoCliente
@id int ,
@nombre varchar(50),
@estado bit
as
update tipoCliente set id=@id, nombre=@nombre,estado=@estado where id=@id and estado=1

create proc InsertarTipoCliente
@id int ,
@nombre varchar(50),
@estado bit
as
insert into tipoCliente values(@id,@nombre,@estado)

create proc EliminarTipoCliente
@id int
as
delete tipoCliente where  id=@id and estado=1


----departamento


create proc MostrarDepartamento
as
select*from departamento

create proc MostrarNombreDepartamento
@id int
as
select nombre from departamento where id=@id and estado=1

create proc EditarDepartamento
@nombre varchar(100),
@estado bit
as
update departamento set nombre=@nombre,estado=@estado where id=@id and estado=1

create proc InsertarDepartamento
@nombre varchar(100),
@estado bit
as
insert into departamento values(@nombre,@estado)

create proc EliminarDepartamento
@id int
as
delete departamento where  id=@id and estado=1


----municipio--

create proc MostrarMunicipio
as
select*from municipio

create proc MostrarNombreMunicipio
@id int
as
select nombre from municipio where id=@id and estado=1

create proc EditarMunicipio
@id int ,
@nombre varchar(100),
@estado bit
as
update municipio set id=@id, nombre=@nombre,estado=@estado where id=@id and estado=1

create proc InsertarMunicipio
@id int ,
@nombre varchar(100),
@estado bit
as
insert into municipio values(@id,@nombre,@estado)

create proc EliminarMunicipio
@id int
as
delete municipio where  id=@id and estado=1


---color


create proc MostrarColor
as
select*from color

create proc MostrarNombreColor
@id int
as
select nombre from color where id=@id and estado=1

create proc EditarColor
@id int ,
@nombre varchar(100),
@estado bit
as
update color set id=@id, nombre=@nombre,estado=@estado where id=@id and estado=1

create proc InsertarColor
@id int ,
@nombre varchar(100),
@estado bit
as
insert into color values(@id,@nombre,@estado)

create proc EliminarColor
@id int
as
delete color where  id=@id and estado=1


----talla

create proc MostrarTallas
as
select*from tallas

create proc MostrarNombreTallas
@id int
as
select  talla from tallas where id=@id and estado=1

create proc EditarTallas
@id int ,
@talla varchar(5),
@estado bit
as
update tallas set id=@id, talla=@talla,estado=@estado where id=@id and estado=1

create proc Insertartallas
@id int ,
@talla varchar(5),
@estado bit
as
insert into tallas values(@id,@talla,@estado)

create proc EliminarTallas
@id int
as
delete tallas where  id=@id and estado=1

----coleccion----
create proc MostrarColeccion
as
select*from coleccion

create proc MostrarNombreColeccion
@id int
as
select  nombre from coleccion where id=@id and estado=1

create proc EditarColeccion
@id int ,
@nombre varchar(100),
@epoca varchar(50),
@estado bit
as
update coleccion set id=@id, nombre=@nombre,epoca=@epoca, estado=@estado where id=@id and estado=1

create proc InsertarColeccion
@id int ,
@nombre varchar(100),
@epoca varchar(50),
@estado bit
as
insert into coleccion values(@id,@nombre,@epoca,@estado)

create proc EliminarColeccion
@id int
as
delete coleccion where  id=@id and estado=1


----material----
create proc MostrarMaterial
as
select*from material

create proc MostrarNombreMaterial
@id int
as
select  nombre from material where id=@id and estado=1

create proc EditarMaterial
@id int ,
@nombre varchar(100),
@estado bit
as
update material set id=@id, nombre=@nombre, estado=@estado where id=@id and estado=1

create proc InsertarMaterial
@id int ,
@nombre varchar(100),
@estado bit
as
insert into material values(@id,@nombre,@estado)

create proc EliminarMaterial
@id int
as
delete material where  id=@id and estado=1


----tipoCalzado---

create proc MostrarTipoCalzado
as
select*from tipoCalzado

create proc MostrarNombreTipoCalzado
@id int
as
select  nombre from tipoCalzado where id=@id and estado=1

create proc EditarTipoCalzado
@id int ,
@nombre varchar(100),
@estado bit
as
update tipoCalzado set id=@id, nombre=@nombre, estado=@estado where id=@id and estado=1

create proc InsertarTipoCalzado
@id int ,
@nombre varchar(100),
@estado bit
as
insert into tipoCalzado values(@id,@nombre,@estado)

create proc EliminartipoCalzado
@id int
as
delete tipoCalzado where  id=@id and estado=1


----tipoPago---
create proc MostrarTipoPago
as
select*from tipoPago

create proc MostrarNombreTipoPago
@id int
as
select  nombre from tipoPago where id=@id and estado=1

create proc EditarTipoPago
@id int ,
@nombre varchar(100),
@estado bit
as
update tipoPago set id=@id, nombre=@nombre, estado=@estado where id=@id and estado=1

create proc InsertartipoPago
@id int ,
@nombre varchar(100),
@estado bit
as
insert into tipoPago values(@id,@nombre,@estado)

create proc EliminartipoPago
@id int
as
delete tipoPago where  id=@id and estado=1
