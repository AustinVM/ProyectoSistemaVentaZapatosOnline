CREATE DATABASE ProyectoTiendaZapatos
GO

USE ProyectoTiendaZapatos
GO

ALTER AUTHORIZATION ON DATABASE::ProyectoTiendaZapatos TO sa
GO
	-- Tablas

CREATE TABLE Rol (
	Id INT IDENTITY ( 1 , 1 ) PRIMARY KEY,
	Nombre VARCHAR (20) NOT NULL,
	Estado BIT NOT NULL DEFAULT 1 CHECK (Estado IN (0, 1))
);
GO

CREATE TABLE Usuario (
	id INT IDENTITY ( 1 , 1 ) PRIMARY KEY,
	Usuario VARCHAR (50) NOT NULL UNIQUE,
	CorreoElectronico VARCHAR (50) NOT NULL UNIQUE,
	Contrasenia VARCHAR (100) NOT NULL,
	IdRol INT NOT NULL FOREIGN KEY REFERENCES Rol (Id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (ISNUMERIC(IdRol) = 1 AND IdRol > 0),
	Estado BIT NOT NULL DEFAULT 1 CHECK (Estado IN (0, 1))
);
GO

CREATE TABLE TipoDocumento (
	Id INT IDENTITY ( 1 , 1 ) PRIMARY KEY,
	Nombre VARCHAR (20) NOT NULL,
	Estado BIT NOT NULL DEFAULT 1 CHECK (Estado IN (0, 1))
);
GO

CREATE TABLE Iva (
	Id INT IDENTITY (1, 1) PRIMARY KEY,
	Iva VARCHAR (20) NOT NULL CHECK (ISNUMERIC(Iva) = 1),
	Estado BIT NOT NULL DEFAULT 1 CHECK (Estado IN (0, 1))
);
GO

CREATE TABLE CategoriaCliente (
	Id INT IDENTITY (1,1) PRIMARY KEY,
	Nombre VARCHAR (5) NOT NULL,
	Descripcion VARCHAR (100),
	Descuento INT NOT NULL,
	Estado BIT NOT NULL DEFAULT 1 CHECK (estado IN (0, 1))
);
GO

CREATE TABLE TipoCliente (
	Id INT IDENTITY ( 1 , 1 ) PRIMARY KEY,
	Nombre VARCHAR (20) NOT NULL,
	Estado BIT NOT NULL DEFAULT 1 CHECK (Estado IN (0, 1))
);
GO

CREATE TABLE Departamento (
	Id INT IDENTITY ( 1 , 1 ) PRIMARY KEY,
	Nombre VARCHAR (20) NOT NULL,
	Estado BIT NOT NULL DEFAULT 1 CHECK (Estado IN (0, 1))
);
GO

CREATE TABLE Municipio (
	Id INT IDENTITY (1,1) PRIMARY KEY,
	Nombre VARCHAR (100) NOT NULL,
	IdDepartamento INT NOT NULL FOREIGN KEY REFERENCES Departamento (Id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (IdDepartamento > 0),
	Estado BIT NOT NULL DEFAULT 1 CHECK (Estado IN (0, 1))
);
GO

CREATE TABLE Color (
	Id INT IDENTITY ( 1 , 1 ) PRIMARY KEY,
	Nombre VARCHAR (20) NOT NULL,
	Estado BIT NOT NULL DEFAULT 1 CHECK (Estado IN (0, 1))
);
GO

CREATE TABLE Tallas (
	Id INT IDENTITY ( 1 , 1 ) PRIMARY KEY,
	Nombre VARCHAR (5) NOT NULL CHECK (ISNUMERIC(Nombre) = 1),
	Estado BIT NOT NULL DEFAULT 1 CHECK (Estado IN (0, 1))
);
GO

CREATE TABLE Coleccion (
	Id INT IDENTITY (1,1) PRIMARY KEY,
	Nombre VARCHAR (100) NOT NULL,
	Epoca VARCHAR (50) NOT NULL,
	Estado BIT NOT NULL DEFAULT 1 CHECK (Estado IN (0, 1))
);
GO

CREATE TABLE Material (
	Id INT IDENTITY ( 1 , 1 ) PRIMARY KEY,
	Nombre VARCHAR (50) NOT NULL,
	Estado BIT NOT NULL DEFAULT 1 CHECK (Estado IN (0, 1))
);
GO

CREATE TABLE TipoCalzado (
	Id INT IDENTITY ( 1 , 1 ) PRIMARY KEY,
	Nombre VARCHAR (50) NOT NULL,
	Estado BIT NOT NULL DEFAULT 1 CHECK (Estado IN (0, 1))
);
GO

CREATE TABLE TipoPago (
	Id INT IDENTITY ( 1 , 1 ) PRIMARY KEY,
	Nombre VARCHAR (20) NOT NULL,
	Estado BIT NOT NULL DEFAULT 1 CHECK (Estado IN (0, 1))
);
GO

CREATE TABLE Cliente (
	NumId VARCHAR (20) PRIMARY KEY,
	IdTipoDocumento INT NOT NULL FOREIGN KEY REFERENCES TipoDocumento (Id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (IdTipoDocumento > 0),
	Nombres VARCHAR (100) NOT NULL,
	Apellidos VARCHAR (100) NOT NULL,
	FechaNacimiento DATE NOT NULL CHECK (FechaNacimiento < CONVERT(DATE, GETDATE())),
	Direccion VARCHAR (100) NOT NULL,
	Telefono VARCHAR (10) UNIQUE NOT NULL,
	CorreoElectronico VARCHAR (100) UNIQUE NOT NULL,
	Contrasenia VARCHAR (100) NOT NULL,
	IdTipoCliente INT NOT NULL FOREIGN KEY REFERENCES TipoCliente (Id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (IdTipoCliente > 0),
	IdMunicipio INT NOT NULL FOREIGN KEY REFERENCES Municipio (Id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (IdMunicipio > 0),
	IdCategoria INT NOT NULL FOREIGN KEY REFERENCES CategoriaCliente (Id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (IdCategoria > 0),
	Estado BIT NOT NULL DEFAULT 1 CHECK (Estado IN (0, 1))
);
GO

CREATE TABLE Empresa (
	NumIdCliente VARCHAR (20) NOT NULL FOREIGN KEY REFERENCES Cliente (NumId) ON DELETE NO ACTION ON UPDATE CASCADE UNIQUE CHECK (ISNUMERIC(NumIdCliente) = 1),
	Nit VARCHAR (20) NOT NULL UNIQUE CHECK (ISNUMERIC(Nit) = 1),
	PRIMARY KEY (NumIdCliente, NIT),
	NombreEmpresa VARCHAR (100) NOT NULL,
	DireccionBodega VARCHAR (100) NOT NULL,
	Estado BIT NOT NULL DEFAULT 1 CHECK (Estado IN (0, 1))
);
GO

CREATE TABLE Producto (
	Id INT IDENTITY (1,1) PRIMARY KEY,
	NombreProducto VARCHAR (100) NOT NULL,
	Descripcion VARCHAR (100) NOT NULL,
	IdColor INT NOT NULL FOREIGN KEY REFERENCES Color (Id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (IdColor > 0),
	IdColeccion INT NOT NULL FOREIGN KEY REFERENCES Coleccion (Id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (IdColeccion > 0),
	IdMaterial INT NOT NULL FOREIGN KEY REFERENCES Material (Id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (IdMaterial > 0),
	IdTipoCalzado INT NOT NULL FOREIGN KEY REFERENCES TipoCalzado (Id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (IdTipoCalzado > 0),
	ImagenProducto VARBINARY(MAX) NOT NULL,
	Estado BIT NOT NULL DEFAULT 1 CHECK (Estado IN (0, 1))
);
GO

CREATE TABLE Producto_Talla (
	id INT IDENTITY (1,1) PRIMARY KEY,
	IdProducto INT NOT NULL FOREIGN KEY REFERENCES Producto (Id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (IdProducto > 0),
	IdTalla INT NOT NULL FOREIGN KEY REFERENCES Tallas (Id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (IdTalla > 0),	
	ValorUnitario INT NOT NULL CHECK (ValorUnitario > 0),
	Stock SMALLINT NOT NULL CHECK (Stock > 0),
	Estado BIT NOT NULL DEFAULT 1 CHECK (Estado IN (0, 1))
);
GO

CREATE TABLE Pedido (
	Id INT IDENTITY (1,1) PRIMARY KEY,
	NumIdCliente VARCHAR (20) NOT NULL FOREIGN KEY REFERENCES Cliente (NumId) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (ISNUMERIC(NumIdCliente) = 1),
	IdProducto_talla INT NOT NULL FOREIGN KEY REFERENCES Producto_Talla (Id) ON DELETE NO ACTION ON UPDATE CASCADE UNIQUE CHECK (idProducto_talla > 0),
	CantidadPedido SMALLINT NOT NULL CHECK (CantidadPedido > 0),
	Estado BIT NOT NULL DEFAULT 1 CHECK (Estado IN ( 0 , 1))
);
GO

CREATE TABLE DetallesFactura (
	Id INT IDENTITY (1,1) PRIMARY KEY,
	IdPedido INT NOT NULL FOREIGN KEY REFERENCES Pedido (Id) ON DELETE NO ACTION ON UPDATE CASCADE UNIQUE CHECK (IdPedido > 0),
	Descripcion VARCHAR (100),
	IdTipoPago INT NOT NULL FOREIGN KEY REFERENCES TipoPago (Id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (IdTipoPago > 0),
	IdIva INT NOT NULL FOREIGN KEY REFERENCES Iva (Id) ON DELETE NO ACTION ON UPDATE CASCADE CHECK (IdIva > 0),
	Subtotal INT NOT NULL CHECK (Subtotal > 0),
	Total INT NOT NULL CHECK (Total > 0)
);
GO

CREATE TABLE Factura (
	Id INT IDENTITY (1,1) PRIMARY KEY,
	FechaExpedicion DATETIME NOT NULL CHECK (FechaExpedicion >= CONVERT(DATE, GETDATE())),
	NumIdCliente VARCHAR (20) NOT NULL FOREIGN KEY REFERENCES Cliente (NumId) CHECK (ISNUMERIC(NumIdCliente) = 1),
	IdDetallesFactura INT NOT NULL FOREIGN KEY REFERENCES DetallesFactura (Id) UNIQUE CHECK (IdDetallesFactura > 0),
	IdMunicipio INT NOT NULL FOREIGN KEY REFERENCES Municipio (Id) CHECK (IdMunicipio > 0)
);
GO



CREATE PROCEDURE SP_CONSULTAR
    @CONSULTA NVARCHAR(MAX),
    @TABLA NVARCHAR(MAX),
    @CONDICION NVARCHAR(MAX)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX)

	IF (@CONSULTA != '*')
		BEGIN -- Construir la consulta SQL completa
			SET @sql = N'SELECT ' + QUOTENAME(@CONSULTA) + ' FROM ' + @TABLA + ' WHERE ' + @CONDICION
			-- Ejecutar la consulta
			EXEC sp_executesql @sql
		END
	ELSE
		BEGIN
			SET @sql = N'SELECT ' + @CONSULTA + ' FROM ' + @TABLA + ' WHERE ' + @CONDICION
			-- Ejecutar la consulta
			EXEC sp_executesql @sql
		END    
END
GO

CREATE PROCEDURE SP_CONSULTAR
    @CONSULTA NVARCHAR(MAX),
    @TABLA NVARCHAR(MAX),
    @CONDICION NVARCHAR(MAX)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX)

    -- Validar que el nombre de la tabla sea un identificador válido
    IF OBJECT_ID(@TABLA) IS NULL
    BEGIN
        RAISERROR('La tabla especificada no existe.', 16, 1)
        RETURN
    END

    -- Escapar el nombre de las columnas para evitar la inyección SQL
    SET @CONSULTA = REPLACE(REPLACE(@CONSULTA, '[', ''), ']', '')
    SET @CONSULTA = REPLACE(@CONSULTA, ',', '],[')
    SET @CONSULTA = '[' + @CONSULTA + ']'

    -- Escapar la condición de filtrado para evitar la inyección SQL
    SET @CONDICION = REPLACE(@CONDICION, '''', '''''')
    SET @CONDICION = REPLACE(@CONDICION, '--', '')
    SET @CONDICION = REPLACE(@CONDICION, ';', '')

    -- Construir la consulta SQL completa
    SET @sql = N'SELECT ' + @CONSULTA + ' FROM ' + QUOTENAME(@TABLA) + ' WHERE ' + @CONDICION 

    -- Ejecutar la consulta
    EXEC sp_executesql @sql
END

