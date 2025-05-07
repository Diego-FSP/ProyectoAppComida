<<<<<<< HEAD
-- Inserción de tipos de menú
INSERT INTO TipoM (Nombre)
VALUES 
('Comida'),   -- IDTipoM = 1
('Bebida'),   -- IDTipoM = 2
('Postre');   -- IDTipoM = 3
=======
-- Inserción de Menu
INSERT INTO Menu (idMenu, Nombre, Cantidad, Precio, Descripcion)
VALUES 
(1,'Empanadas', 30, 900.00, 'Carne cortada'),
(2,'Pollo Broster', 10, 1800.00, 'Crujiente y jugoso'),
(3,'Hamburguesa', 15, 1200.00, 'Clásica con queso'),
(4,'Salchipapa', 20, 1000.00, 'Papas con salchichas'),
(5,'Puré c/Milanesa', 12, 1700.00, 'Con salsa o sin salsa');
>>>>>>> 3bb8df26bf0fc04954a09ccd048fb61bc9d4b1de

-- Inserción de Menu (todos con tipo 'Comida' → IDTipo = 1)
INSERT INTO Menu (Nombre, Cantidad, Precio, Descripcion, IDTipo)
VALUES 
('Empanadas', 30, 900.00, 'Carne cortada', 1),
('Pollo Broster', 10, 1800.00, 'Crujiente y jugoso', 1),
('Hamburguesa', 15, 1200.00, 'Clásica con queso', 1),
('Salchipapa', 20, 1000.00, 'Papas con salchichas', 1),
('Puré c/Milanesa', 12, 1700.00, 'Con salsa o sin salsa', 1);
-- Paso 1: Insertar un pedido
INSERT INTO Pedido (PrecioTotal, idMenu, cantidad)
VALUES (1200.00, 3, 1);  -- esto crea un nuevo pedido con un ID nuevo

-- Paso 2: Consultar los idPedido válidos
SELECT idPedido FROM Pedido;  -- esto te muestra todos los IDs válidos

-- Paso 3: Insertar en Ticked usando un idPedido existente
INSERT INTO Ticked (idPedido, Nombre, mesa, hora)
VALUES (1, 'Luis Fernández', FALSE, NOW());  -- solo si el 1 existe en Pedido

