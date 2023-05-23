

CREATE TABLE Usuarios (
	IdUsuario INT PRIMARY KEY IDENTITY,
	Email VARCHAR(100) UNIQUE NOT NULL,
	Senha VARCHAR (255) NOT NULL)

CREATE TABLE Classes(
	IdClasse INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(100) UNIQUE NOT NULL,
	Descricao VARCHAR(255))

CREATE TABLE Personagens(
	IdPersonagens INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(50) UNIQUE NOT NULL,
	Descricao VARCHAR(255),
	IdUsuario INT FOREIGN KEY REFERENCES Usuarios(IdUsuario),
	IdClasse INT FOREIGN KEY REFERENCES Classes(IdClasse))

CREATE TABLE Habilidades(
	IdHabilidade INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(100) UNIQUE NOT NULL,
	Descricao VARCHAR(255))

CREATE TABLE ClassesHabilidades(
IdHabilidade INT UNIQUE FOREIGN KEY REFERENCES Habilidades(IdHabilidade),
IdClasse INT FOREIGN KEY REFERENCES Classes(IdClasse))





--DML
INSERT INTO Usuarios (Senha, Email) VALUES(12345, 'email@email.com')
INSERT INTO Classes VALUES('Barbaro', 'Guerreiro agressivo estilo tank')
INSERT INTO Habilidades VALUES('Fúria', 'Aumenta poder de ataque, mas reduz armadura'), ('Instinto Selvagem', 'Aumento em um curto período sua velocidade e reflexo')
INSERT INTO Personagens VALUES(	'DeBug', 'Grande herói do reino Ued', 1, 1)
INSERT INTO ClassesHabilidades VALUES(1,1), (2,1)

INSERT INTO Usuarios VALUES('email2@email.com', 12345)
INSERT INTO Classes VALUES('Monge', 'Guerreiro especializado em artes marciais e meditação')
INSERT INTO Habilidades VALUES('Soco Rápido', 'Realiza ataques rápidos e precisos com as mãos'), ('Chute Giratório', 'Desfere um poderoso chute giratório, causando dano em área')
INSERT INTO Personagens VALUES(	'BitBug', 'Possível reencarnação do lendário BigBug', 4, 4)
INSERT INTO ClassesHabilidades VALUES(2,2), (3,2)


--DQL
SELECT * FROM Usuarios
SELECT * FROM Classes
SELECT * FROM Habilidades
SELECT * FROM Personagens
JOIN CLASSES
ON Personagens.IdClasse = Classes.IdClasse
SELECT * FROM ClassesHabilidades

SELECT PP.Nome 'name.personagem' , CC.Nome 'name.classe' FROM Personagens PP
join Classes CC
ON PP.IdClasse = CC.IdClasse

UPDATE Usuarios
SET Senha = 54321
WHERE IdUsuario = 1


