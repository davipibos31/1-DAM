DROP DATABASE IF EXISTS citas;
CREATE DATABASE citas;
use citas;

CREATE TABLE aficion (
    codigo integer PRIMARY KEY AUTO_INCREMENT,
    descripcion character varying(20) NOT NULL
);

CREATE TABLE cita ( 
    id integer PRIMARY KEY AUTO_INCREMENT,
    fecha date,
    lugar character varying(15),
    CONSTRAINT cita_fecha_ck CHECK (fecha >= '2017-01-01')
);

CREATE TABLE encuesta (
    nom_usuario character varying(20) NOT NULL,
    cita integer NOT NULL,
    valoracion character varying(20)
);

CREATE TABLE formacion (
    nom_usuario character varying(20) NOT NULL,
    formacion character varying(30) NOT NULL
);

CREATE TABLE gusta (
    nom_usuario_1 character varying(20) NOT NULL,
    nom_usuario_2 character varying(20) NOT NULL
);

CREATE TABLE perfil (
    nom_usuario character varying(20) NOT NULL,
    email character varying(45) NOT NULL,
    foto character varying(45) DEFAULT 'img/default.jpg',
    fechanac date,
    sexo character(1),
    trabajo character varying(45),
    religion character varying(20)
);

CREATE TABLE practica (
    nom_usuario character varying(20) NOT NULL,
    aficion integer NOT NULL,
    frecuencia character varying(20),
    CONSTRAINT practica_frecuencia_ck CHECK ((frecuencia = 'todos los meses') OR (frecuencia = 'todas las semanas') OR (frecuencia = 'a diario'))
);

CREATE TABLE usuario (
    nom_usuario character varying(20) NOT NULL,
    nif character varying(9),
    pass character varying(10),
    telefono numeric(9,0),
    nombre character varying(45)
);

INSERT INTO aficion VALUES (1, 'lectura');
INSERT INTO aficion VALUES (2, 'baile');
INSERT INTO aficion VALUES (3, 'running');
INSERT INTO aficion VALUES (4, 'natacion');
INSERT INTO aficion VALUES (5, 'pintura');
INSERT INTO aficion VALUES (6, 'musica');
INSERT INTO aficion VALUES (7, 'equitacion');

INSERT INTO cita VALUES (1, '2017-09-03', 'Madrid');
INSERT INTO cita VALUES (2, '2017-10-10', 'Madrid');
INSERT INTO cita VALUES (3, '2017-10-15', 'Valladolid');
INSERT INTO cita VALUES (4, '2017-08-02', 'Madrid');
INSERT INTO cita VALUES (5, '2017-09-24', 'Toledo');
INSERT INTO cita VALUES (6, '2017-07-13', 'Avila');
INSERT INTO cita VALUES (7, '2017-10-08', 'Segovia');
INSERT INTO cita VALUES (8, '2017-04-06', 'Valladolid');
INSERT INTO cita VALUES (9, '2017-05-26', 'Madrid');

INSERT INTO encuesta VALUES ('emgonzalez', 1, 'mal');
INSERT INTO encuesta VALUES ('mrreyes', 1, 'regular');
INSERT INTO encuesta VALUES ('emgonzalez', 2, 'muy bien');
INSERT INTO encuesta VALUES ('sbortega', 2, 'bien');
INSERT INTO encuesta VALUES ('djrodrigo', 3, 'regular');
INSERT INTO encuesta VALUES ('rmsalazar', 3, 'regular');
INSERT INTO encuesta VALUES ('jgbermudez', 4, 'muy bien');
INSERT INTO encuesta VALUES ('stmedina', 4, 'muy bien');
INSERT INTO encuesta VALUES ('rvquiroga', 5, 'mal');
INSERT INTO encuesta VALUES ('esfigueroa', 5, 'mal');
INSERT INTO encuesta VALUES ('apruiz', 6, 'bien');
INSERT INTO encuesta VALUES ('vgmartinez', 6, 'muy bien');
INSERT INTO encuesta VALUES ('apruiz', 7, 'muy bien');
INSERT INTO encuesta VALUES ('vgmartinez', 7, 'muy bien');
INSERT INTO encuesta VALUES ('vprodriguez', 8, 'bien');
INSERT INTO encuesta VALUES ('cgramos', 8, 'bien');
INSERT INTO encuesta VALUES ('vprodriguez', 9, 'bien');
INSERT INTO encuesta VALUES ('cgramos', 9, 'muy bien');

INSERT INTO formacion VALUES ('emgonzalez', 'Magisterio');
INSERT INTO formacion VALUES ('mrreyes', 'Graduado en Medicina');
INSERT INTO formacion VALUES ('djrodrigo', 'Graduado en Historia');
INSERT INTO formacion VALUES ('cgramos', 'Graduado en Filosofia');
INSERT INTO formacion VALUES ('jgbermudez', 'Ingeniero Industrial');
INSERT INTO formacion VALUES ('sbortega', 'Matemáticas');
INSERT INTO formacion VALUES ('rshernandez', 'Graduado en Enfermería');
INSERT INTO formacion VALUES ('esfigueroa', 'FP Sup Administrativo');
INSERT INTO formacion VALUES ('rvquiroga', 'Graduado en Medicina');
INSERT INTO formacion VALUES ('apruiz', 'Bachillerato');
INSERT INTO formacion VALUES ('stmedina', 'Ingeniero Informática');
INSERT INTO formacion VALUES ('avmiranda', 'FP Sup Administrativo');
INSERT INTO formacion VALUES ('sggarcia', 'Bachillerato');
INSERT INTO formacion VALUES ('lpmedina', 'Graduado en Geografia');
INSERT INTO formacion VALUES ('vgmartinez', 'FP Sup Estetica');
INSERT INTO formacion VALUES ('rmsalazar', 'FP Sup Estetica');
INSERT INTO formacion VALUES ('vprodriguez', 'FP Sup Fotografia');

INSERT INTO gusta VALUES ('emgonzalez', 'mrreyes');
INSERT INTO gusta VALUES ('emgonzalez', 'cgramos');
INSERT INTO gusta VALUES ('emgonzalez', 'sbortega');
INSERT INTO gusta VALUES ('djrodrigo', 'avmiranda');
INSERT INTO gusta VALUES ('djrodrigo', 'lpmedina');
INSERT INTO gusta VALUES ('djrodrigo', 'vgmartinez');
INSERT INTO gusta VALUES ('djrodrigo', 'rmsalazar');
INSERT INTO gusta VALUES ('jgbermudez', 'esfigueroa');
INSERT INTO gusta VALUES ('jgbermudez', 'stmedina');
INSERT INTO gusta VALUES ('rvquiroga', 'sbortega');
INSERT INTO gusta VALUES ('rvquiroga', 'rshernandez');
INSERT INTO gusta VALUES ('rvquiroga', 'esfigueroa');
INSERT INTO gusta VALUES ('apruiz', 'lpmedina');
INSERT INTO gusta VALUES ('apruiz', 'vgmartinez');
INSERT INTO gusta VALUES ('sggarcia', 'cgramos');
INSERT INTO gusta VALUES ('vprodriguez', 'mrreyes');
INSERT INTO gusta VALUES ('vprodriguez', 'cgramos');
INSERT INTO gusta VALUES ('vprodriguez', 'vgmartinez');
INSERT INTO gusta VALUES ('vprodriguez', 'rmsalazar');

INSERT INTO perfil VALUES ('emgonzalez', 'emgonzalez@webcitas.com', 'img/M/emgonzalez.jpg', '1990-04-20', 'M', 'Profesor', 'Cristianismo');
INSERT INTO perfil VALUES ('mrreyes', 'mrreyes@webcitas.com', 'img/F/mrreyes.jpg', '1987-11-03', 'F', 'Medico', 'Cristianismo');
INSERT INTO perfil VALUES ('djrodrigo', 'djrodrigo@webcitas.com', 'img/M/djrodrigo.jpg', '1992-02-06', 'M', 'Camarero', 'Ateo');
INSERT INTO perfil VALUES ('cgramos', 'cgramos@webcitas.com', 'img/F/cgramos.jpg', '1989-04-05', 'F', NULL, 'Ateo');
INSERT INTO perfil VALUES ('jgbermudez', 'jgbermudez@webcitas.com', 'img/M/jgbermudez.jpg', '1990-08-24', 'M', 'Ingeniero', 'Ateo');
INSERT INTO perfil VALUES ('sbortega', 'sbortega@webcitas.com', 'img/F/sbortega.jpg', '1990-05-15', 'F', 'Profesor', 'Cristianismo');
INSERT INTO perfil VALUES ('rshernandez', 'rshernandez@webcitas.com', 'img/F/rshernandez.jpg', '1988-06-02', 'F', 'Enfermera', 'Cristianismo');
INSERT INTO perfil VALUES ('esfigueroa', 'esfigueroa@webcitas.com', 'img/F/esfigueroa.jpg', '1990-11-17', 'F', 'Administrativo', 'Islam');
INSERT INTO perfil VALUES ('rvquiroga', 'rvquiroga@webcitas.com', 'img/M/rvquiroga.jpg', '1988-12-28', 'M', 'Medico', 'Islam');
INSERT INTO perfil VALUES ('avmiranda', 'avmiranda@webcitas.com', 'img/F/avmiranda.jpg', '1990-06-14', 'F', 'Administrativo', 'Cristianismo');
INSERT INTO perfil VALUES ('sggarcia', 'sggarcia@webcitas.com', 'img/M/sggarcia.jpg', '1991-06-02', 'M', NULL, 'Ateo');
INSERT INTO perfil VALUES ('lpmedina', 'lpmedina@webcitas.com', 'img/F/lpmedina.jpg', '1986-07-13', 'F', NULL, 'Ateo');
INSERT INTO perfil VALUES ('vgmartinez', 'vgmartinez@webcitas.com', 'img/F/vgmartinez.jpg', '1986-02-24', 'F', 'Peluquera', 'Ateo');
INSERT INTO perfil VALUES ('rmsalazar', 'rmsalazar@webcitas.com', 'img/F/rmsalazar.jpg', '1984-09-25', 'F', 'Peluquera', 'Cristianismo');
INSERT INTO perfil VALUES ('vprodriguez', 'vprodriguez@webcitas.com', 'img/M/vprodriguez.jpg', '1993-11-06', 'M', 'Fotografo', 'Ateo');
INSERT INTO perfil VALUES ('apruiz', 'apruiz@webcitas.com', 'img/M/apruiz.jpg', '1987-05-29', 'M', 'Policía', 'Islam');
INSERT INTO perfil VALUES ('stmedina', 'stmedina@webcitas.com', 'img/F/stmedina.jpg', '1987-01-10', 'F', 'Policía', 'Cristianismo');

INSERT INTO practica VALUES ('emgonzalez', 1, 'todos los meses');
INSERT INTO practica VALUES ('emgonzalez', 2, 'todas las semanas');
INSERT INTO practica VALUES ('emgonzalez', 3, 'a diario');
INSERT INTO practica VALUES ('mrreyes', 3, 'a diario');
INSERT INTO practica VALUES ('djrodrigo', 2, 'todas las semanas');
INSERT INTO practica VALUES ('djrodrigo', 4, 'todos los meses');
INSERT INTO practica VALUES ('cgramos', 4, 'a diario');
INSERT INTO practica VALUES ('jgbermudez', 2, 'a diario');
INSERT INTO practica VALUES ('jgbermudez', 4, 'a diario');
INSERT INTO practica VALUES ('jgbermudez', 1, 'a diario');
INSERT INTO practica VALUES ('sbortega', 3, 'a diario');
INSERT INTO practica VALUES ('rshernandez', 1, 'todas las semanas');
INSERT INTO practica VALUES ('esfigueroa', 1, 'a diario');
INSERT INTO practica VALUES ('esfigueroa', 4, 'a diario');
INSERT INTO practica VALUES ('rvquiroga', 5, 'todos los meses');
INSERT INTO practica VALUES ('rvquiroga', 6, 'todas las semanas');
INSERT INTO practica VALUES ('rvquiroga', 2, 'todas las semanas');
INSERT INTO practica VALUES ('apruiz', 7, 'todos los meses');
INSERT INTO practica VALUES ('stmedina', 7, 'todas las semanas');
INSERT INTO practica VALUES ('avmiranda', 7, 'todas las semanas');
INSERT INTO practica VALUES ('sggarcia', 7, 'a diario');
INSERT INTO practica VALUES ('sggarcia', 2, 'todos los meses');
INSERT INTO practica VALUES ('lpmedina', 3, 'a diario');
INSERT INTO practica VALUES ('lpmedina', 1, 'todas las semanas');
INSERT INTO practica VALUES ('vgmartinez', 5, 'todas las semanas');
INSERT INTO practica VALUES ('rmsalazar', 6, 'todos los meses');
INSERT INTO practica VALUES ('rmsalazar', 2, 'todas las semanas');
INSERT INTO practica VALUES ('rmsalazar', 7, 'todas las semanas');
INSERT INTO practica VALUES ('vprodriguez', 3, 'todas las semanas');

INSERT INTO usuario VALUES ('emgonzalez', '78563401C', 'ggPtcs7I', 675889203, 'Eduardo Martin Gonzalez');
INSERT INTO usuario VALUES ('mrreyes', '54389210D', 'M27GYCVU', 679304123, 'Maria Rodriguez Reyes');
INSERT INTO usuario VALUES ('djrodrigo', '56703214D', 'BD6XJbuf', 630928379, 'David Jimenez Rodrigo');
INSERT INTO usuario VALUES ('cgramos', '78932434F', 'myuDRHBx', 601829464, 'Claudia Garcia Ramos');
INSERT INTO usuario VALUES ('jgbermudez', '90067312F', '7ZLte16L', 650220132, 'Jose Gutierrez Bermudez');
INSERT INTO usuario VALUES ('sbortega', '56323453G', '4YCmJKFZ', 680098033, 'Sandra Blanco Ortega');
INSERT INTO usuario VALUES ('rshernandez', '67863211G', 'hmkghHl7', 665783375, 'Rocio Suarez Hernandez');
INSERT INTO usuario VALUES ('esfigueroa', '67895435H', 'OrRAdwQx', 652939003, 'Elisa Sanchez Figueroa');
INSERT INTO usuario VALUES ('rvquiroga', '43214352H', 'L9HKbr08', 610328956, 'Roberto Vega Quiroga');
INSERT INTO usuario VALUES ('apruiz', '65473823J', '5knUQaSh', 600892163, 'Alberto Parra Ruiz');
INSERT INTO usuario VALUES ('stmedina', '56743284K', 'j6MEus4h', 665110890, 'Sonia Torres Medina');
INSERT INTO usuario VALUES ('avmiranda', '65473877K', 'a7KyiUFF', 613252307, 'Adriana Vazquez Miranda');
INSERT INTO usuario VALUES ('sggarcia', '22314780L', 'yrE7b679', 608700931, 'Saul Gomez Garcia');
INSERT INTO usuario VALUES ('lpmedina', '23145236L', 'GUkuV5rD', 670897834, 'Lucia Perez Medina');
INSERT INTO usuario VALUES ('vgmartinez', '55400892G', 'T6obZiQa', 689932045, 'Veronica Gonzalo Martinez');
INSERT INTO usuario VALUES ('rmsalazar', '54430287J', 'paVuW9lC', 673940331, 'Ruth Morales Salazar');
INSERT INTO usuario VALUES ('vprodriguez', '45362734P', 'eoJTry5f', 659434491, 'Victor Perez Rodriguez');



ALTER TABLE encuesta
    ADD CONSTRAINT encuesta_nom_usuario_cita_pk PRIMARY KEY (nom_usuario, cita);

ALTER TABLE formacion
    ADD CONSTRAINT formacion_nom_usuario_formacion_pk PRIMARY KEY (nom_usuario, formacion);

ALTER TABLE gusta
    ADD CONSTRAINT gusta_nusu1_nusu2_pk PRIMARY KEY (nom_usuario_1, nom_usuario_2);

ALTER TABLE perfil
    ADD CONSTRAINT perfil_email_uk UNIQUE (email);

ALTER TABLE perfil
    ADD CONSTRAINT perfil_nom_usuario_pk PRIMARY KEY (nom_usuario);

ALTER TABLE practica
    ADD CONSTRAINT practica_nom_usuario_aficion_pk PRIMARY KEY (nom_usuario, aficion);

ALTER TABLE usuario
    ADD CONSTRAINT usuario_nif_uk UNIQUE (nif);

ALTER TABLE usuario
    ADD CONSTRAINT usuario_nom_usuario_pk PRIMARY KEY (nom_usuario);

ALTER TABLE formacion
    ADD CONSTRAINT formacion_nom_usuario_fk FOREIGN KEY (nom_usuario) REFERENCES usuario(nom_usuario) ON UPDATE CASCADE ON DELETE CASCADE;

ALTER TABLE gusta
    ADD CONSTRAINT gusta_nom_usuario_1_fk FOREIGN KEY (nom_usuario_1) REFERENCES usuario(nom_usuario) ON UPDATE CASCADE ON DELETE CASCADE;



ALTER TABLE gusta
    ADD CONSTRAINT gusta_nom_usuario_2_fk FOREIGN KEY (nom_usuario_2) REFERENCES usuario(nom_usuario) ON UPDATE CASCADE ON DELETE CASCADE;



ALTER TABLE perfil
    ADD CONSTRAINT perfil_nom_usuario_fk FOREIGN KEY (nom_usuario) REFERENCES usuario(nom_usuario) ON UPDATE CASCADE ON DELETE CASCADE;



ALTER TABLE practica
    ADD CONSTRAINT practica_aficion_fk FOREIGN KEY (aficion) REFERENCES aficion(codigo) ON UPDATE CASCADE ON DELETE CASCADE;



ALTER TABLE practica
    ADD CONSTRAINT practica_nom_usuario_fk FOREIGN KEY (nom_usuario) REFERENCES usuario(nom_usuario) ON UPDATE CASCADE ON DELETE CASCADE;



ALTER TABLE encuesta
    ADD CONSTRAINT reunion_cita_fk FOREIGN KEY (cita) REFERENCES cita(id) ON UPDATE CASCADE ON DELETE CASCADE;



ALTER TABLE encuesta
    ADD CONSTRAINT reunion_nom_usuario_fk FOREIGN KEY (nom_usuario) REFERENCES usuario(nom_usuario) ON UPDATE CASCADE ON DELETE CASCADE;



