USE ProyectoTiendaZapatos
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------

	-- Procedimientos Almacenados

CREATE PROC SP_AgregarRol
	@nombre VARCHAR (20),
	@estado BIT
AS
	INSERT INTO rol (nombre, estado) VALUES (@nombre, @estado)
GO

CREATE PROC SP_ConsultarRol
AS
	SELECT * FROM rol
GO

CREATE PROC SP_ActualizarRol
	@id INT,
	@nombre VARCHAR (20),
	@estado BIT
AS
	UPDATE rol SET nombre = @nombre, estado = @estado WHERE id = @id
GO

CREATE PROC SP_EliminarRol
	@id INT
AS
	DELETE FROM rol WHERE id = @id
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------
select*from usuario

CREATE PROC SP_AgregarUsuario
    @usuario VARCHAR (50),
    @contrasenia VARCHAR (100),
    @ID_rol INT,
    @estado BIT
AS
    INSERT INTO usuario (Usuario, Contrasenia, IdRol, Estado) VALUES (@usuario, @contrasenia, @ID_rol, @estado)
GO

/* CREATE PROC ConsultarUsuario
    @usuario VARCHAR (50),
    @contrasenia VARCHAR (100),
    @ID_rol INT,
    @estado BIT
AS */





CREATE PROC SP_ConsultarUsuario
AS
    SELECT * FROM usuario
GO

CREATE PROC ValidarUsuario
	@Usuario VARCHAR (50),
	@contrasenia VARCHAR (100),
	@id_Rol INT
AS
	SELECT usuario, contrasenia, IdRol FROM usuario WHERE usuario = @usuario AND Estado = 1
GO

CREATE PROC SP_ActualizarUsuario
    @usuario VARCHAR (50),
    @contrasenia VARCHAR (100),
    @ID_rol INT,
    @estado BIT
AS
    UPDATE usuario SET usuario = @usuario, contrasenia = @contrasenia, IdRol = @ID_rol, Estado = @estado WHERE usuario = @usuario
GO

CREATE PROC SP_EliminarUsuario
    @usuario VARCHAR (50)
AS
    DELETE FROM usuario WHERE usuario = @usuario
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------


CREATE PROC SP_AniadirTipoDocumento
	@nombre VARCHAR (50),
	@estado BIT
AS
	INSERT INTO tipoDocumento (Nombre, Estado) VALUES (@nombre, @estado)
GO

CREATE PROC SP_ConsultarTipoDocumento
	@nombre VARCHAR (50),
	@estado BIT
AS
	SELECT * FROM tipoDocumento WHERE estado = @estado
GO

CREATE PROC SP_ActualizarTipoDocumento
	@id INT,
	@nombre VARCHAR (50),
	@estado BIT
AS
	UPDATE tipoDocumento SET nombre = @nombre, estado = @estado WHERE id = @id
GO

CREATE PROC SP_EliminarTipoDocumento
	@id INT
AS
	DELETE FROM tipoDocumento WHERE id = @id
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------


CREATE PROC SP_AniadirIva
	@iva VARCHAR (5),
	@estado BIT
AS
	INSERT INTO iva (iva, estado) VALUES (@iva, @estado)
GO

CREATE PROC SP_ConsultarIva
	@iva VARCHAR (50),
	@estado BIT
AS
	SELECT * FROM iva WHERE estado = @estado
GO

CREATE PROC SP_ActualizarIva
	@id INT,
	@iva VARCHAR (5),
	@estado BIT
AS
	UPDATE iva SET iva = @iva, estado = @estado WHERE id = @id
GO

CREATE PROC SP_EliminarIva
	@id INT
AS
	DELETE FROM iva WHERE id = @id
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------


CREATE PROC SP_AniadirCategoria
	@nombre VARCHAR (5),
	@descripcion VARCHAR (100),
	@descuento INT,
	@estado BIT
AS
	INSERT INTO categoria (nombre, descripcion, descuento, estado) VALUES (@nombre, @descripcion, @descuento, @estado)
GO

CREATE PROC SP_ConsultarCategoria
	@estado BIT
AS
	SELECT nombre, descripcion, descuento FROM categoria WHERE estado = @estado
GO

CREATE PROC SP_ActualizarCategoria
	@id INT,
	@nombre VARCHAR (5),
	@descripcion VARCHAR (100),
	@descuento INT,
	@estado BIT
AS
	UPDATE categoria SET nombre = @nombre, descripcion = @descripcion, descuento = @descuento, estado = @estado WHERE id = @id
GO

CREATE PROC SP_EliminarCategoria
	@id INT
AS
	DELETE FROM categoria WHERE id = @id
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------



-----------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------





CREATE PROC SP_AgregarTipoCliente
	@nombre VARCHAR (50),
	@estado BIT
AS
	INSERT INTO tipoCliente (nombre, estado) VALUES (@nombre, @estado)
GO

CREATE PROC SP_ConsultarTipoCliente
	@nombre VARCHAR (50),
	@estado BIT
AS
	SELECT * FROM tipoCliente WHERE estado = @estado
GO

CREATE PROC SP_ActualizarTipoCliente
	@id INT,
	@nombre VARCHAR (50),
	@estado BIT
AS
	UPDATE tipoCliente SET nombre = @nombre, estado = @estado WHERE id = @id
GO

CREATE PROC SP_EliminarTipoCliente
	@id INT
AS
	DELETE FROM tipoCliente WHERE id = @id
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_AgregarDepartamento
	@nombre VARCHAR (50),
	@estado BIT
AS
	INSERT INTO Departamento (nombre, estado) VALUES (@nombre, @estado)
GO

CREATE PROC SP_ConsultarDepartamento
	@nombre VARCHAR (50),
	@estado BIT
AS
	SELECT * FROM Departamento WHERE estado = @estado
GO

CREATE PROC SP_ActualizarDepartamento
	@id INT,
	@nombre VARCHAR (50),
	@estado BIT
AS
	UPDATE Departamento SET nombre = @nombre, estado = @estado WHERE id = @id
GO

CREATE PROC SP_EliminarDepartamento
	@id INT
AS
	DELETE FROM Departamento WHERE id = @id
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_AgregarMunicipio
	@nombre VARCHAR (50),
	@id_Departamento INT,
	@estado BIT
AS
	INSERT INTO Municipio (Nombre, IdDepartamento, Estado) VALUES (@nombre, @id_Departamento, @estado)
GO

CREATE PROC SP_ConsultarMunicipio
	@nombre VARCHAR (50),
	@estado BIT
AS
	SELECT * FROM Municipio WHERE Estado = @estado
GO

CREATE PROC SP_ActualizarMunicipio
	@id INT,
	@nombre VARCHAR (50),
	@id_Departamento INT,
	@estado BIT
AS
	UPDATE Municipio SET Nombre = @nombre, IdDepartamento = @id_Departamento, Estado = @estado WHERE Id = @id
GO

CREATE PROC SP_EliminarMunicipio
	@id INT
AS
	DELETE FROM Departamento WHERE id = @id
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------
--procedimientos creados jonathan 
CREATE PROC SP_ConsultarColor
AS
	SELECT * FROM Color
GO


----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_ConsultarMaterial
AS
	SELECT * FROM Material
GO


----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------
CREATE PROC SP_ConsultarColeccion
AS
	SELECT * FROM Coleccion
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------


CREATE PROC SP_ConsultarTipoCalzado
AS
	SELECT * FROM TipoCalzado
GO

-----------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_AgregarProducto
    @NombreProducto VARCHAR (50),
    @IdColor INT ,
    @IdColeccion INT,
	@IdMaterial INT,
	@IdTipoCalzado INT,
	@Estado bit,
	@ImagenProducto varbinary(max)


AS
    INSERT INTO producto (NombreProducto, IdColor, IdColeccion, IdMaterial,IdTipoCalzado,Estado,ImagenProducto) VALUES (@NombreProducto,@IdColor , @IdColeccion,@IdMaterial,@IdTipoCalzado,@Estado,@ImagenProducto )
GO
 select*from Producto

-----------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------
--EDITAR PRODUC
create proc SP_ActualizarProducto
	@Id INT,
	@NombreProducto VARCHAR (50),
    @IdColor INT ,
    @IdColeccion INT,
	@IdMaterial INT,
	@IdTipoCalzado INT,
	@Estado bit,
	@ImagenProducto varbinary(max)


AS
    UPDATE  producto SET NombreProducto=@NombreProducto,IdColor=@IdColor, IdColeccion=@IdColeccion, IdMaterial=@IdMaterial,IdTipoCalzado=@IdTipoCalzado,Estado=@Estado, ImagenProducto=@ImagenProducto WHERE Id = @Id
GO

-------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------
--CONSULTAR PROC

create proc ConsultarProducto
AS
SELECT * FROM producto
GO