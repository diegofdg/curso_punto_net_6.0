-- Mala practica
SELECT u.*, (SELECT * FROM Users_Roles WHERE IdUser = u.Id) FROM Users u

-- Otra mala practica
SELECT u.*, ur.*, (SELECT * FROM Roles WHERE Id = ur.IdRole)
FROM Users u
INNER JOIN
Users_Roles ur
ON u.Id = ur.IdUser

--Esta es otra mala practica
SELECT * FROM Users
--Crear bucle para recorrer los usuarios
SELECT * FROM Users_Roles WHERE IdUser = i
--Crear bucle dentro del bucle para recorrer Users_Roles
SELECT * FROM Roles WHERE Id = i

-- Asi se hace
SELECT *
FROM Users u
INNER JOIN
Users_Roles ur
ON u.Id = ur.IdUser
INNER JOIN
Roles r
ON ur.IdRole = r.Id
