CREATE DEFINER=`root`@`localhost` PROCEDURE `ejercicio19`()
BEGIN
declare contador int;
	declare valor_penultimo bigint;
    declare valor_ultimo bigint;
    declare valor_actual bigint;
    
    set contador := 0;
    
    set valor_penultimo := 0;
    set valor_ultimo := 0;
    set valor_actual := 0;
    
    repeat
		set valor_actual := valor_ultimo + valor_penultimo;
        insert into fibonacci values(valor_actual);
        
        if valor_actual = 0 then
			set valor_penultimo := 1;
		else
			set valor_penultimo := valor_ultimo;
            set valor_ultimo := valor_actual;
		end if;
        
        set contador := contador + 1;
	until contador = 50
    end repeat;
END