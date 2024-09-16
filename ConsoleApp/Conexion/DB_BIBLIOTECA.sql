--DROP DATABASE DB_BIBLIOTECA

CREATE DATABASE DB_BIBLIOTECA
GO

USE DB_BIBLIOTECA;
GO

CREATE TABLE [PERSONAS]
(
	[ID] INT NOT NULL IDENTITY (1, 1),
	[CEDULA] NVARCHAR(100) NOT NULL UNIQUE,
	[NOMBRE] NVARCHAR(100) NOT NULL,
	CONSTRAINT [PK_PERSONAS] PRIMARY KEY CLUSTERED ([ID]),

)
GO

CREATE TABLE [USUARIOS]
(
	[ID] INT NOT NULL IDENTITY (1, 1),
	[USUARIO] NVARCHAR(100) NOT NULL UNIQUE,
	[CONTRASEŅA] NVARCHAR(100) NOT NULL,
	[PERSONA] INT NOT NULL,
	CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED ([ID]),
	CONSTRAINT [FK_USUARIOS_PERSONAS] FOREIGN KEY ([PERSONA]) REFERENCES [PERSONAS] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION
)
GO

CREATE TABLE [PRESTAMOS]
(
	[ID] INT NOT NULL IDENTITY (1, 1),
	[NUMERO] NVARCHAR(100) NOT NULL UNIQUE,
	[FECHA] DATETIME NOT NULL,
	[USUARIO] INT NOT NULL,
	CONSTRAINT [PK_PRESTAMOS] PRIMARY KEY CLUSTERED ([ID]),
	CONSTRAINT [FK_PRESTAMOS_USUARIOS] FOREIGN KEY ([USUARIO]) REFERENCES [USUARIOS] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION
)
GO

CREATE TABLE [NOTAS]
(
	[ID] INT NOT NULL IDENTITY (1, 1),
	[DESCRIPCION] NVARCHAR(500) NOT NULL,
	[PRESTAMO] INT NOT NULL,
	CONSTRAINT [PK_NOTAS] PRIMARY KEY CLUSTERED ([ID]),
	CONSTRAINT [FK_NOTAS_PRESTAMOS] FOREIGN KEY ([PRESTAMO]) REFERENCES [PRESTAMOS] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION
)
GO

CREATE TABLE [ESTADOS]
(
	[ID] INT NOT NULL IDENTITY (1, 1),
	[NOMBRE] NVARCHAR(50) NOT NULL UNIQUE,
	CONSTRAINT [PK_ESTADOS] PRIMARY KEY CLUSTERED ([ID])
)
GO

CREATE TABLE [LIBROS]
(
	[ID] INT NOT NULL IDENTITY (1, 1),
	[NOMBRE] NVARCHAR(100) NOT NULL UNIQUE,
	[AUTOR] NVARCHAR(100) NOT NULL,
	[ESTADO] INT NOT NULL,
	CONSTRAINT [PK_LIBROS] PRIMARY KEY CLUSTERED ([ID]),
	CONSTRAINT [FK_LIBROS_ESTADOS] FOREIGN KEY ([ESTADO]) REFERENCES [ESTADOS] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION
)
GO

CREATE TABLE [PRESTAMOSLIBROS]
(
	[ID] INT NOT NULL IDENTITY (1, 1),
	[PRESTAMO] INT NOT NULL,
	[LIBRO] INT NOT NULL,
	CONSTRAINT [PK_PRESTAMOSLIBROS] PRIMARY KEY CLUSTERED ([ID]),
	CONSTRAINT [FK_PRESTAMOSLIBROS_PRESTAMOS] FOREIGN KEY ([PRESTAMO]) REFERENCES [PRESTAMOS] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION,
	CONSTRAINT [FK_PRESTAMOSLIBROS_LIBROS] FOREIGN KEY ([LIBRO]) REFERENCES [LIBROS] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION
)
GO
