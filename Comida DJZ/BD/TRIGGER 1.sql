DROP TRIGGER IF EXISTS restar_stock_ticked;

DELIMITER $$

CREATE TRIGGER restar_stock_ticked
AFTER INSERT ON Ticked
FOR EACH ROW
BEGIN
    -- Descontar stock de comida
    IF NEW.idMenu IS NOT NULL THEN
        UPDATE Menu
        SET Cantidad = Cantidad - 1
        WHERE idMenu = NEW.idMenu;
    END IF;
END $$

DELIMITER ;
