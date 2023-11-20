CREATE TABLE Roles (
    Id INTEGER NOT NULL AUTO_INCREMENT, 
    Role VARCHAR(50) NOT NULL,
    PRIMARY KEY(Id)
) ENGINE = InnoDB; 

CREATE TABLE Utilisateur (
    id INTEGER NOT NULL AUTO_INCREMENT,
    role_id INTEGER NOT NULL,
    nom VARCHAR(250) NOT NULL,
    prenom VARCHAR(250) NOT NULL,
    email VARCHAR(200) NOT NULL,
    service VARCHAR(150) NOT NULL,
    poste VARCHAR(100) NOT NULL,
    matricule varchar(10) NOT NULL,
    PRIMARY KEY(id),
    FOREIGN KEY(role_id) references Roles(id)
) ENGINE = InnoDB; 


CREATE TABLE BonTravail (
    id INTEGER NOT NULL AUTO_INCREMENT,
    numero INTEGER ,
    date datetime NOT NULL,
    datelimite datetime NOT NULL,
    priorite INTEGER NOT NULL,
    etat INTEGER NOT NULL,
    zone VARCHAR(250),
    souszone VARCHAR(250),
    created_at datetime NOT NULL,
    updated_at datetime NOT NULL,
    PRIMAR KEY(id)
);

-- Insert rows into roles
INSERT INTO Roles  (role) VALUES ('Administrateur');
INSERT INTO Roles  (role) VALUES ('Responsable');
INSERT INTO Roles  (role) VALUES ('Technicien');
INSERT INTO Roles  (role) VALUES ('Demandeur');

-- Insert rows into utilisateur
INSERT  INTO utilisateurs (role_id,nom,prenom,email,service,poste,matricule) 
        VALUES (4,'Robsona','Tsiory Andriantsoa','t.robson@lacoste.com','Directeur des systèmes information','Directeur des systèmes infromation','EMP1029');


-------------------------------- sql server --------------------------------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
USE BonTravail
GO
CREATE TABLE [dbo].[roles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[role] [varchar](MAX) NOT NULL,
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[roles] ADD PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
USE BonTravail
GO
CREATE TABLE utilisateurs (
    [id] [int] IDENTITY(1,1) NOT NULL,
    [role_id] [int] NOT NULL,
    [nom] [varchar](MAX) NOT NULL,
    [prenom] [varchar](MAX) NOT NULL,
    [email] [varchar](MAX) NOT NULL,
    [service] [varchar](MAX) NOT NULL,
    [poste] [varchar](100) NOT NULL,
    [matricule] [varchar](MAX) NOT NULL
    [etat] [bit] NOT NULL DEFAULT 0
)  ON [PRIMARY]
GO
ALTER TABLE [dbo].[utilisateurs] ADD PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE utilisateurs ADD CONSTRAINT FK_Utilisateurs_Roles FOREIGN KEY (role_id) REFERENCES roles(id);
GO
