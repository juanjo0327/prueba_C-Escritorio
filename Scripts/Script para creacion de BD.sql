CREATE DATABASE prueba_Clientes

use prueba_Clientes

-- =============================================
-- Autor: Juan Jose Salas Zamudio
-- Fecha: 07/12/2023
-- Descripción General: SCRIPTS PARA LA CREACION DE LA BD prueba_Clientes
-- CREACION DE LOS PROCEDIMIENTOS PARA AGREGAR, MODIFICAR, BUSCAR y ELIMINAR CLIENTES 
-- =============================================

CREATE table Clientes(
codigo INT not null,
nombre varchar(200) not null,
rfc varchar(15) not null,
calle varchar(50) not null,
numero_exterior varchar(50) not null,
numero_interior varchar(50) not null,
colonia varchar(100) not null,
poblacion varchar(200) not null,
codigo_postal varchar(10) not null,
fecha_alta datetime not null,
limite_credito money not null,
activo bit not null,
CONSTRAINT pk_Clientes Primary Key (codigo)
)

--PROCEDIMIENTO PARA AGREGAR CLIENTE
CREATE PROCEDURE agregarCliente
		@codigo INT,
		@nombre varchar(200),
		@rfc varchar(15),
		@calle varchar(50),
		@numero_exterior varchar(50),
		@numero_interior varchar(50),
		@colonia varchar(100),
		@poblacion varchar(200),
		@codigo_postal varchar(10),
		@fecha_alta datetime,
		@limite_credito money,
		@activo bit
AS
BEGIN
    INSERT INTO [dbo].[Clientes]
           ([codigo]
           ,[nombre]
           ,[rfc]
           ,[calle]
           ,[numero_exterior]
           ,[numero_interior]
           ,[colonia]
           ,[poblacion]
           ,[codigo_postal]
           ,[fecha_alta]
           ,[limite_credito]
           ,[activo]) 
		VALUES
           (@codigo, @nombre, @rfc, @calle, @numero_exterior, @numero_interior, @colonia, @poblacion, @codigo_postal, GETDATE(), @limite_credito, 1)
END;

--PROCEDIMIENTO PARA OBTENER CLIENTES
CREATE PROCEDURE obtenerClientes
AS
BEGIN
	SELECT * FROM CLIENTES;
END;

--PROCEDIMIENTO PARA MODIFICAR CLIENTES
CREATE PROCEDURE proc_modificarClientes 
				 @codigo INT
				,@nombre VARCHAR(200)
				,@rfc VARCHAR(15)
				,@calle VARCHAR(50)
				,@numeroExterior VARCHAR(50)
				,@numeroInterior varchar(50)
				,@colonia VARCHAR(100)
				,@poblacion VARCHAR(200)
				,@codigoPostal varchar(10)
				,@limite_credito money

AS
BEGIN
UPDATE Clientes 
	SET nombre = @nombre
		,rfc = @rfc
		,calle = @calle
		,numero_exterior = @numeroExterior
		,numero_interior = @numeroInterior
		,colonia = @colonia
		,poblacion = @poblacion
		,codigo_postal = @codigoPostal
		,limite_credito = @limite_credito
	WHERE codigo = @codigo;
END;

--PROCEDIMIENTO PARA ELIMINAR CLIENTE
CREATE PROCEDURE proc_eliminarCliente
				@codigo INT
AS
BEGIN
DELETE FROM Clientes WHERE codigo = @codigo
UPDATE Clientes set activo = 0 WHERE codigo = @codigo;
END;