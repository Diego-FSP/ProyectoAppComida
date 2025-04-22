DROP TABLE IF EXISTS calificacion;
DROP TABLE IF EXISTS ticked;
DROP TABLE IF EXISTS Comida;

-- Tabla: Comida
CREATE TABLE Comida (
    idComida INT PRIMARY KEY,
    Nombre VARCHAR(21),
    imagen BLOB, -- datebit no existe; asumo que es imagen binaria
    cantidad INT,
    Precio DOUBLE,
    mesa BOOLEAN,
    descripcion VARCHAR(21)
);

-- Tabla: ticked
CREATE TABLE ticked (
    idTicked INT PRIMARY KEY,
    Nombre VARCHAR(21),
    Apellido VARCHAR(21),
    DNI INT,
    idComida INT,
    PrecioTotal DOUBLE,
    Estado VARCHAR(21),
    mesa BOOLEAN,
    FOREIGN KEY (idComida) REFERENCES Comida(idComida)
);

-- Tabla: calificacion
CREATE TABLE calificacion (
    idComida INT,
    Valor INT,
    cliente VARCHAR(21),
    FOREIGN KEY (idComida) REFERENCES Comida(idComida)
);
