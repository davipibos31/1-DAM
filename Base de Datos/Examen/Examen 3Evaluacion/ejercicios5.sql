delimiter //
create trigger productos_precio before insert on productos for each row 
begin
	set new.precio_max := max(new.precio);
    if (new.precio < new.precio_max) then
		update new.precio_max SET new.precio_max = new.precio_max + 200;  
    end if;
end//
delimiter ;