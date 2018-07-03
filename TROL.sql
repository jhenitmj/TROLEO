CREATE DATABASE TROLEO
USE TROLEO
DROP DATABASE TROLEO
CREATE TABLE [USER]
(
CODU	INT PRIMARY KEY,
EMAIL	VARCHAR(100),
SENHA	VARCHAR(20) 
)

CREATE TABLE CLIENTE 
(
CODC	INT PRIMARY KEY,
NOME	VARCHAR(50),
VEICULO	VARCHAR(50),
PLACA	VARCHAR(20),
EMAIL	VARCHAR(100)
)

CREATE TABLE OLEO
(
CODO		INT PRIMARY KEY,
NOME		VARCHAR(100),
CATEGORIA	VARCHAR(50),
TPOLEO		VARCHAR(50),
FABRICANTE	VARCHAR(50),
VALOR		DECIMAL(8,2) 
)

CREATE TABLE STROLEO
(
CODS	INT PRIMARY KEY,
DATAS	DATETIME DEFAULT GETDATE(),
CODC INT REFERENCES CLIENTE,
CODO	INT REFERENCES OLEO,
QTDEL	INT	
)



bulk insert [USER]
from 'C:\Users\Particular\Documents\GitHub\ExercicioTrocaOleo-master\usuarios.txt'
with (codepage='ACP', fieldterminator = ';')


bulk insert CLIENTE
from 'C:\Users\Particular\Documents\GitHub\ExercicioTrocaOleo-master\Clientes.txt'
with (codepage='ACP', fieldterminator = ';')

bulk insert OLEO
from 'C:\Users\Particular\Documents\GitHub\ExercicioTrocaOleo-master\Oleos.txt'
with (codepage='ACP', fieldterminator = ';')

SELECT*FROM [USER]

