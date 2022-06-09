
select alumno.nombre, alumno.apellido1, alumno.apellido2, count(matricula.asignatura) from alumno join asignatura left join matricula on matricula.asignatura = asignatura.codigo and matricula.alumno = alumno.DNI group by alumno having count(matricula.asignatura) < 5;