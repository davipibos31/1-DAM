Drop trigger if exists productos_BI_trigger;
DELIMITER //
CREATE DEFINER=CURRENT_USER TRIGGER productos_BI_trigger BEFORE INSERT ON productos FOR EACH ROW
BEGIN
 -- Instrucciones asociadas al trigger
 IF (NEW.precio < 0) THEN
	SET New.precio := 0;
 END IF;
END//
DELIMITER ;