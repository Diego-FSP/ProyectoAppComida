-- Inserción de comidas
INSERT INTO Comida (Nombre, Cantidad, Precio, Descripcion)
VALUES 
('Empanadas', 30, 900.00, 'Carne cortada'),
('Pollo Broster', 10, 1800.00, 'Crujiente y jugoso'),
('Hamburguesa', 15, 1200.00, 'Clásica con queso'),
('Salchipapa', 20, 1000.00, 'Papas con salchichas'),
('Puré c/Milanesa', 12, 1700.00, 'Con salsa o sin salsa');

-- Inserción de ticket (usando idComida = 3 que corresponde a 'Hamburguesa')
INSERT INTO Ticked (Nombre, Apellido, DNI, idComida, PrecioTotal, Estado, Mesa)
VALUES ('Luis', 'Fernández', 45678912, 3, 900.00, 'Pagado', FALSE);

-- Inserción de calificación para la comida con idComida = 3
INSERT INTO Calificacion (idComida, Valor, Cliente)
VALUES (3, 5, 'Luis Fernández');
