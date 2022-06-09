Drop trigger if exists productos_BI_trigger3;
DELIMITER //
CREATE DEFINER=CURRENT_USER TRIGGER productos_BI_trigger3 before UPDATE ON productos FOR EACH ROW
BEGIN
declare descripcion text;
set descripcion := concat_ws(' ','update on productos. old: (', old.producto, old.precio, ')', 'new: (',new.producto, new.precio,')');
insert into log values (default, now(), current_user, descripcion);
END//
DELIMITER ;
select * from productos;
update productos set precio = 200 where producto_id = 1;
select * from log;