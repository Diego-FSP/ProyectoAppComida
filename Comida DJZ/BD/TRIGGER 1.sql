DELIMITER $$

CREATE TRIGGER restar_stock_menu
AFTER INSERT ON Ticked
FOR EACH ROW
BEGIN
    DECLARE menuID INT;
    DECLARE cantidadPedida INT;

    -- Obtener el idMenu y cantidad desde Pedido
    SELECT idMenu, cantidad INTO menuID, cantidadPedida
    FROM Pedido
    WHERE idPedido = NEW.idPedido;

    -- Restar la cantidad del stock en Menu
    UPDATE Menu
    SET Cantidad = Cantidad - cantidadPedida
    WHERE idMenu = menuID;
END $$

DELIMITER ;


