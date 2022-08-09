CREATE TABLE Persons (
	Id int NOT NULL,
	LastName vachar(255) NOT NULL,
	FirstName vachar(255),
	Age int CHECK (Age>=18),
	ModifiedDate datetime
);

SELECT * FROM Persons
WHERE FirstName = 'Roberto'


SELECT * FROM Persons
WHERE ModifiedDate >= '2013-01-01' AND ModifiedDate < '2014-01-01'

SELECT * FROM Persons
--WHERE LastName = 'Bradley' AND LastName = 'Wood' AND LastName = 'Brown'
WHERE LastName IN ('Bradley', 'Wood', 'Brown')

SELECT * FROM Persons
WHERE FirstName LIKE 'Amanda'

SELECT * FROM Persons
WHERE FirstName LIKE 'A%'

SELECT * FROM Persons
ORDER BY FirstName DESC

SELECT * FROM Persons
ORDER BY LastName ASC

SELECT * FROM Persons
ORDER BY LastName DESC, FirstName ASC

SELECT COUNT (Id FROM Persons) --Cuenta la cantidad de registros