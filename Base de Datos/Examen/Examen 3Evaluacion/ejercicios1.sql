delimiter //
create trigger num_alumnos_insert before insert on grupo for each row 
begin
	update num_alumnos SET num_alumnos = num_alumnos + 1;  
end//
delimiter ;
