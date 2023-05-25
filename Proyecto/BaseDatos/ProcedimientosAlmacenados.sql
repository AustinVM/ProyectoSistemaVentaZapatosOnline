USE ProyectoTiendaZapatos
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------

	-- Procedimientos Almacenados

CREATE PROC SP_AgregarRol
	@Nombre VARCHAR (20),
	@Estado BIT
AS
	INSERT INTO Rol (Nombre, Estado) VALUES (@Nombre, @Estado)
GO

CREATE PROC SP_ConsultarRol
AS
	SELECT * FROM Rol
GO

CREATE PROC SP_ActualizarRol
	@Id INT,
	@Nombre VARCHAR (20),
	@Estado BIT
AS
	UPDATE Rol SET Nombre = @Nombre, Estado = @Estado WHERE Id = @Id
GO

CREATE PROC SP_EliminarRol
	@Id INT
AS
	DELETE FROM Rol WHERE Id = @Id
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------


CREATE PROC SP_AgregarUsuario
    @Usuario VARCHAR (50),
    @Contrasenia VARCHAR (100),
    @IdRol INT,
    @Estado BIT
AS
    INSERT INTO usuario (Usuario, Contrasenia, IdRol, Estado) VALUES (@Usuario, @Contrasenia, @IdRol, @Estado)
GO

CREATE PROC SP_ConsultarUsuario
AS
    SELECT * FROM Usuario
GO

CREATE PROC SP_ValidarUsuario
	@Usuario VARCHAR (50),
	@Contrasenia VARCHAR (100),
	@IdRol INT
AS
	SELECT Usuario, Contrasenia, IdRol FROM Usuario WHERE Usuario = @Usuario AND Estado = 1
GO

CREATE PROC SP_ActualizarUsuario
    @Usuario VARCHAR (50),
    @Contrasenia VARCHAR (100),
    @IdRol INT,
    @Estado BIT
AS
    UPDATE Usuario SET Usuario = @Usuario, Contrasenia = @Contrasenia, IdRol = @IdRol, Estado = @Estado WHERE Usuario = @Usuario
GO

CREATE PROC SP_EliminarUsuario
    @Usuario VARCHAR (50)
AS
    DELETE FROM Usuario WHERE Usuario = @Usuario
GO

CREATE PROC SP_RecuperarContrasenia
    @CorreoElectronico VARCHAR (50),
    @Contrasenia VARCHAR (100)
AS
	IF EXISTS (SELECT CorreoElectronico FROM Usuario WHERE CorreoElectronico = @CorreoElectronico)
	BEGIN
		SELECT * FROM Usuario WHERE CorreoElectronico = @CorreoElectronico
    	UPDATE Usuario SET Contrasenia = @Contrasenia WHERE CorreoElectronico = @CorreoElectronico
	END
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------


CREATE PROC SP_AniadirTipoDocumento
	@nombre VARCHAR (50),
	@estado BIT
AS
	INSERT INTO TipoDocumento (Nombre, Estado) VALUES (@nombre, @estado)
GO

CREATE PROC SP_ConsultarTipoDocumento
AS
	SELECT * FROM TipoDocumento
GO

CREATE PROC SP_ActualizarTipoDocumento
	@Id INT,
	@Nombre VARCHAR (50),
	@Estado BIT
AS
	UPDATE TipoDocumento SET Nombre = @Nombre, Estado = @Estado WHERE Id = @Id
GO

CREATE PROC SP_EliminarTipoDocumento
	@Id INT
AS
	DELETE FROM TipoDocumento WHERE Id = @Id
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------


CREATE PROC SP_AniadirIva
	@Iva VARCHAR (5),
	@Estado BIT
AS
	INSERT INTO Iva (Iva, Estado) VALUES (@Iva, @Estado)
GO

CREATE PROC SP_ConsultarIva
	@Iva VARCHAR (50),
	@Estado BIT
AS
	SELECT * FROM Iva WHERE Estado = @Estado
GO

CREATE PROC SP_ActualizarIva
	@Id INT,
	@Iva VARCHAR (5),
	@Estado BIT
AS
	UPDATE Iva SET Iva = @Iva, Estado = @Estado WHERE Id = @Id
GO

CREATE PROC SP_EliminarIva
	@Id INT
AS
	DELETE FROM Iva WHERE Id = @Id
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------


CREATE PROC SP_AniadirCategoriaCliente
	@Nombre VARCHAR (5),
	@Descripcion VARCHAR (100),
	@Descuento INT,
	@Estado BIT
AS
	INSERT INTO CategoriaCliente (Nombre, Descripcion, Descuento, Estado) VALUES (@Nombre, @Descripcion, @Descuento, @Estado)
GO

CREATE PROC SP_ConsultarCategoriaCliente
	@estado BIT
AS
	SELECT Nombre, Descripcion, Descuento FROM CategoriaCliente WHERE Estado = @Estado
GO

CREATE PROC SP_ActualizarCategoriaCliente
	@Id INT,
	@Nombre VARCHAR (5),
	@Descripcion VARCHAR (100),
	@Descuento INT,
	@Estado BIT
AS
	UPDATE CategoriaCliente SET Nombre = @Nombre, Descripcion = @Descripcion, Descuento = @Descuento, Estado = @Estado WHERE Id = @Id
GO

CREATE PROC SP_EliminarCategoriaCliente
	@Id INT
AS
	DELETE FROM CategoriaCliente WHERE Id = @Id
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_AgregarTipoCliente
	@Nombre VARCHAR (50),
	@Estado BIT
AS
	INSERT INTO TipoCliente (Nombre, Estado) VALUES (@Nombre, @Estado)
GO

CREATE PROC SP_ConsultarTipoCliente
AS
	SELECT * FROM TipoCliente
GO

CREATE PROC SP_ActualizarTipoCliente
	@Id INT,
	@Nombre VARCHAR (50),
	@Estado BIT
AS
	UPDATE TipoCliente SET Nombre = @Nombre, Estado = @Estado WHERE Id = @Id
GO

CREATE PROC SP_EliminarTipoCliente
	@Id INT
AS
	DELETE FROM TipoCliente WHERE Id = @Id
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_AgregarDepartamento
	@Nombre VARCHAR (50),
	@Estado BIT
AS
	INSERT INTO Departamento (Nombre, Estado) VALUES (@Nombre, @Estado)
GO

CREATE PROC SP_ConsultarDepartamento
AS
	SELECT * FROM Departamento
GO

CREATE PROC SP_ActualizarDepartamento
	@Id INT,
	@Nombre VARCHAR (50),
	@Estado BIT
AS
	UPDATE Departamento SET Nombre = @Nombre, Estado = @Estado WHERE Id = @Id
GO

CREATE PROC SP_EliminarDepartamento
	@Id INT
AS
	DELETE FROM Departamento WHERE Id = @Id
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_AgregarMunicipio
	@Nombre VARCHAR (50),
	@IdDepartamento INT,
	@Estado BIT
AS
	INSERT INTO Municipio (Nombre, IdDepartamento, Estado) VALUES (@Nombre, @IdDepartamento, @Estado)
GO

CREATE PROC SP_ConsultarMunicipio
AS
	SELECT * FROM Municipio
GO

CREATE PROC SP_ActualizarMunicipio
	@id INT,
	@Nombre VARCHAR (50),
	@IdDepartamento INT,
	@Estado BIT
AS
	UPDATE Municipio SET Nombre = @Nombre, IdDepartamento = @IdDepartamento, Estado = @Estado WHERE Id = @Id
GO

CREATE PROC SP_EliminarMunicipio
	@Id INT
AS
	DELETE FROM Departamento WHERE Id = @Id
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------



CREATE PROC SP_AgregarColor
	@Nombre VARCHAR (50),
	@Estado BIT
AS
	INSERT INTO Color (Nombre, Estado) VALUES (@Nombre, @Estado)
GO

CREATE PROC SP_ConsultarDepartamento
AS
	SELECT * FROM Color
GO

CREATE PROC SP_ActualizarColor
	@Id INT,
	@Nombre VARCHAR (50),
	@Estado BIT
AS
	UPDATE Color SET Nombre = @Nombre, Estado = @Estado WHERE Id = @Id
GO

CREATE PROC SP_EliminarColor
	@Id INT
AS
	DELETE FROM Color WHERE Id = @Id
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_AgregarTallas
	@Nombre VARCHAR (50),
	@Estado BIT
AS
	INSERT INTO Tallas (Nombre, Estado) VALUES (@Nombre, @Estado)
GO

CREATE PROC SP_ConsultarTallas
AS
	SELECT * FROM Tallas
GO

CREATE PROC SP_ActualizarTallas
	@Id INT,
	@Nombre VARCHAR (50),
	@Estado BIT
AS
	UPDATE Tallas SET Nombre = @Nombre, Estado = @Estado WHERE Id = @Id
GO

CREATE PROC SP_EliminarTallas
	@Id INT
AS
	DELETE FROM Tallas WHERE Id = @Id
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_AgregarColeccion
	@Nombre VARCHAR (50),
	@Epoca VARCHAR (50),
	@Estado BIT
AS
	INSERT INTO Coleccion (Nombre, Epoca, Estado) VALUES (@Nombre, @Epoca, @Estado)
GO

CREATE PROC SP_ConsultarColeccion
AS
	SELECT * FROM Coleccion
GO

CREATE PROC SP_ActualizarColeccion
	@Id INT,
	@Nombre VARCHAR (50),
	@Epoca VARCHAR (50),
	@Estado BIT
AS
	UPDATE Coleccion SET Nombre = @Nombre, Epoca = @Epoca, Estado = @Estado WHERE Id = @Id
GO

CREATE PROC SP_EliminarColeccion
	@Id INT
AS
	DELETE FROM Coleccion WHERE Id = @Id
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_AgregarMaterial
	@Nombre VARCHAR (50),
	@Estado BIT
AS
	INSERT INTO Material (Nombre, Estado) VALUES (@Nombre, @Estado)
GO

CREATE PROC SP_ConsultarMaterial
AS
	SELECT * FROM Material
GO

CREATE PROC SP_ActualizarMaterial
	@Id INT,
	@Nombre VARCHAR (50),
	@Estado BIT
AS
	UPDATE Material SET Nombre = @Nombre, Estado = @Estado WHERE Id = @Id
GO

CREATE PROC SP_EliminarMaterial
	@Id INT
AS
	DELETE FROM Material WHERE Id = @Id
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_AgregarTipoCalzado
	@Nombre VARCHAR (50),
	@Estado BIT
AS
	INSERT INTO TipoCalzado (Nombre, Estado) VALUES (@Nombre, @Estado)
GO

CREATE PROC SP_ConsultarTipoCalzado
AS
	SELECT * FROM TipoCalzado
GO

CREATE PROC SP_ActualizarTipoCalzado
	@Id INT,
	@Nombre VARCHAR (50),
	@Estado BIT
AS
	UPDATE TipoCalzado SET Nombre = @Nombre, Estado = @Estado WHERE Id = @Id
GO

CREATE PROC SP_EliminarTipoCalzado
	@Id INT
AS
	DELETE FROM TipoCalzado WHERE Id = @Id
GO

-----------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_AgregarTipoPago
	@Nombre VARCHAR (50),
	@Estado BIT
AS
	INSERT INTO TipoPago (Nombre, Estado) VALUES (@Nombre, @Estado)
GO

CREATE PROC SP_ConsultarTipoPago
AS
	SELECT * FROM TipoPago
GO

CREATE PROC SP_ActualizarTipoPago
	@Id INT,
	@Nombre VARCHAR (50),
	@Estado BIT
AS
	UPDATE TipoPago SET Nombre = @Nombre, Estado = @Estado WHERE Id = @Id
GO

CREATE PROC SP_EliminarTipoPago
	@Id INT
AS
	DELETE FROM TipoPago WHERE Id = @Id
GO

-----------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------


select*from Producto


CREATE PROC SP_AgregarProducto
    @NombreProducto VARCHAR (50),
    @IdColor INT ,
    @IdColeccion INT,
	@IdMaterial INT,
	@IdTipoCalzado INT,
	@ImagenProducto VARBINARY(MAX),
	@Estado BIT
AS
    INSERT INTO producto (NombreProducto, IdColor, IdColeccion, IdMaterial, IdTipoCalzado, ImagenProducto, Estado) VALUES (@NombreProducto, @IdColor, @IdColeccion, @IdMaterial, @IdTipoCalzado, @ImagenProducto, @Estado)
GO

CREATE PROC SP_ActualizarProducto
	@Id INT,
    @NombreProducto VARCHAR (50),
    @IdColor INT ,
    @IdColeccion INT,
	@IdMaterial INT,
	@IdTipoCalzado INT,
	@ImagenProducto VARBINARY(MAX),
	@Estado BIT
AS
	UPDATE Producto SET NombreProducto = @NombreProducto, IdColor = @IdColor, IdColeccion = @IdColeccion, IdMaterial = @IdMaterial, IdTipoCalzado = @IdTipoCalzado, ImagenProducto = @ImagenProducto, Estado = @Estado where Id=@Id
GO
Drop proc Sp_ActualizarProducto

CREATE PROC SP_EliminarProducto
	@Id INT
AS
	delete from Producto where Id=@Id
GO

-------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------