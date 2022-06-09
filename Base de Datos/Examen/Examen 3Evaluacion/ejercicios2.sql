delimiter //
create trigger num_alumnos_update before update on grupo for each row 
begin
	update num_alumnos SET num_alumnos = num_alumnos + 1;  
end//
delimiter ;
