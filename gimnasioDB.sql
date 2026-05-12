CREATE DATABASE gimnasioDB
USE gimnasioDB
GO

CREATE TABLE Clientes(
   Identificacion int primary key,
   Nombre varchar(50),
   Apellido varchar(50),
   Edad int
);
GO
/* CREAR PROCEDIMIENTOS ALMACENADOS */
CREATE OR ALTER PROCEDURE sp_InsertarClientes
   @Id int,@Nombre varchar(50),@Apellido varchar(50),@Edad int
AS
   BEGIN
       IF NOT EXISTS (SELECT Identificacion FROM Clientes WHERE Identificacion=@Id)
           INSERT INTO Clientes VALUES(@Id,@Nombre,@Apellido,@Edad);
   END;
GO

-- BUSCAR
CREATE OR ALTER PROCEDURE sp_BuscarClientes
   @Id int
AS
   BEGIN
       SELECT * FROM Clientes WHERE Identificacion=@Id;
   END;
GO

-- ACTUALIZAR
CREATE OR ALTER PROCEDURE sp_ActualizarClientes
   @Id int,@Nombre varchar(50),@Apellido varchar(50),@Edad int
AS
   BEGIN
       IF EXISTS (SELECT Identificacion FROM Clientes WHERE Identificacion=@Id)
           UPDATE Clientes SET Nombre=@Nombre,Apellido=@Apellido,Edad=@Edad
           WHERE Identificacion=@Id;
   END;
GO

-- ELIMINAR
CREATE OR ALTER PROCEDURE sp_EliminarClientes
   @Id int
AS
   BEGIN
       IF EXISTS (SELECT Identificacion FROM Clientes WHERE Identificacion=@Id)
           DELETE FROM Clientes WHERE Identificacion=@Id;
   END;
GO

-- FILTRAR
CREATE OR ALTER PROCEDURE sp_FiltrarCliente
   @Texto varchar(100)
AS
   BEGIN
       SELECT * FROM Clientes c WHERE (@Texto IS NULL OR C.Identificacion LIKE
       '%' + @Texto + '%' OR C.Nombre LIKE '%' + @Texto + '%' OR C.Apellido LIKE
       '%' + @Texto + '%');
   END;
GO

-- OBTENER
CREATE OR ALTER PROCEDURE sp_ObtenerClientes
AS
BEGIN
    SELECT * FROM Clientes
END
GO

-- Estadistica
CREATE OR ALTER PROCEDURE sp_EstadisticaClientes
AS
BEGIN 
	SELECT Nombre, Edad
	FROM Clientes
	ORDER BY Apellido
END
GO

-- ELIMINAAR
USE master;
GO

-- Forcefully disconnect all users and set to single user mode
ALTER DATABASE gimnasioDB 
SET SINGLE_USER 
WITH ROLLBACK IMMEDIATE;
GO

-- Now drop it
DROP DATABASE gimnasioDB;
GO