Drop database if exists sistema_de_comida;
Create database sistema_de_comida;
use sistema_de_comida;

CREATE TABLE Comida (
    idComida INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(50),
    Cantidad INT,
    Precio DOUBLE,
    Descripcion VARCHAR(100)
);

CREATE TABLE Bebidas (
    idBebidas INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(50),
    Cantidad INT,
    Precio DOUBLE,
    Descripcion VARCHAR(100)
);

CREATE TABLE Postres (
    idPostres INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(50),
    Cantidad INT,
    Precio DOUBLE,
    Descripcion VARCHAR(100)
);

CREATE TABLE Ticked (
    idTicked INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    DNI INT,
    idComida INT,
    idBebidas INT,
    idPostres INT,
    PrecioTotal DOUBLE,
    Estado VARCHAR(50),
    Mesa BOOLEAN,
    FOREIGN KEY (idComida) REFERENCES Comida(idComida),
    FOREIGN KEY (idBebidas) REFERENCES Bebidas(idBebidas),
    FOREIGN KEY (idPostres) REFERENCES Postres(idPostres)
);

CREATE TABLE calificacion (
    idComida INT,
    Valor INT,
    Cliente VARCHAR(21),
    FOREIGN KEY (idComida) REFERENCES Comida(idComida)
);
