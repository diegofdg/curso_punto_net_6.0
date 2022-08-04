-- Comando para crear una base de datos nueva
CREATE DATABASE Agenda

-- Comando para seleccionar base de datos
USE Agenda

-- Comando para eliminar base de datos
DROP DATABASE Agenda

-- Comando para crear una tabla
CREATE TABLE Personas(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(50) NOT NULL,
	Apellido VARCHAR(50) NOT NULL
);

-- Comando para modificar una tabla (agregar un campo)
ALTER TABLE Personas
ADD Edad INT NOT NULL;

-- Comando para modificar una tabla (eliminar un campo)
ALTER TABLE Personas
DROP COLUMN Edad;


-- Comando para insertar un registro en una tabla
INSERT INTO Personas (Nombre, Apellido, Edad) VALUES ('Ruben', 'Benegas',26);

-- Comando para modificar un registro de la tabla
UPDATE Personas
SET Nombre = 'Juan',
	Apellido = 'Perez',
	Edad = 25
WHERE Id = 1

-- Comando para eliminar (no reinicia el contador de los Ids)
DELETE FROM Personas
WHERE Id = 1

-- Comando para vaciar una tabla (reinicia el contador de los Ids)
TRUNCATE TABLE Personas

-- Comando de consulta
SELECT Id, Nombre + ' ' + Apellido as Descripcion FROM Personas
WHERE Nombre = 'Juan'