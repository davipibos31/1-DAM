CREATE PROCEDURE `ejercicio16` (in nota int, out descripcion varchar(20))
BEGIN
	if (nota < 0 or nota > 10) then
		set descripcion := 'Nota inválida';
	elseif (nota < 5) then
		set descripcion := 'Insuficiente';
	elseif (nota < 6) then
		set descripcion := 'Aprovado';
	elseif (nota < 7) then
		set descripcion := 'Bien';
	elseif (nota < 9) then
		set descripcion := 'Notable';
	elseif (nota <= 10) then
		set descripcion := 'Sobresaliente';
	end if;
END