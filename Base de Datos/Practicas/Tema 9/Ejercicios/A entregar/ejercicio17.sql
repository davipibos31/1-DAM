CREATE DEFINER=`root`@`localhost` PROCEDURE `ejercicio17`(in nota int, out descripcion varchar(20))
BEGIN
	case when (nota < 0 or nota > 10) then
		set descripcion := 'Nota inválida';
	when (nota < 5) then
		set descripcion := 'Insuficiente';
	when (nota < 6) then
		set descripcion := 'Aprovado';
	when (nota < 7) then
		set descripcion := 'Bien';
	when (nota < 9) then
		set descripcion := 'Notable';
	when (nota <= 10) then
		set descripcion := 'Sobresaliente';
	end case;
END