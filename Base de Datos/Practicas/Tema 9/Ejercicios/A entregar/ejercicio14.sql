Drop trigger if exists productos_BI_trigger4;
DELIMITER //
CREATE DEFINER=CURRENT_USER TRIGGER productos_BI_trigger4 after DELETE ON categorias FOR EACH ROW
BEGIN
declare descripcion text;
set descripcion := concat_ws(' ','delete on categorias. old: (', old.categoria, ')');
insert into log values (default, now(), current_user, descripcion);
END//
DELIMITER ;
select * from categorias;
select * from log;