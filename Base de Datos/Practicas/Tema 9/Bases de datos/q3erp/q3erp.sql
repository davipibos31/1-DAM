-- Creación de la base de datos
CREATE DATABASE Q3ERP;
USE Q3ERP;
-- Creación de las tablas
CREATE TABLE `categorias` (
 `categoria_id` bigint(20) NOT NULL AUTO_INCREMENT,
 `categoria` varchar(32) CHARACTER SET utf8 DEFAULT NULL,
 PRIMARY KEY (`categoria_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;
CREATE TABLE `marcas` (
 `marca_id` bigint(20) NOT NULL AUTO_INCREMENT,
 `marca` varchar(32) CHARACTER SET utf8 DEFAULT NULL,
 PRIMARY KEY (`marca_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;
CREATE TABLE `productos` (
 `producto_id` bigint(20) NOT NULL AUTO_INCREMENT,
 `categoria_id` bigint(20) DEFAULT NULL,
 `marca_id` bigint(20) DEFAULT NULL,
 `codigo` int(11) DEFAULT NULL,
 `producto` varchar(32) CHARACTER SET utf8 DEFAULT NULL,
 `precio` decimal(10,2) DEFAULT NULL,
 `calidad` tinyint(1) DEFAULT NULL,
 `estrellas` char(5) DEFAULT NULL,
 PRIMARY KEY (`producto_id`),
 KEY `fk_productos_categorias_idx` (`categoria_id`),
 KEY `fk_productos_marcas_idx` (`marca_id`),
 CONSTRAINT `fk_productos_categorias` FOREIGN KEY (`categoria_id`) REFERENCES `categorias` (`categoria_id`) ON UPDATE
CASCADE,
 CONSTRAINT `fk_productos_marcas` FOREIGN KEY (`marca_id`) REFERENCES `marcas` (`marca_id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;
CREATE TABLE `log` (
 `log_id` int(11) NOT NULL AUTO_INCREMENT,
 `fecha` datetime DEFAULT NULL,
 `usuario` varchar(64) DEFAULT NULL,
 `descripcion` text,
 PRIMARY KEY (`log_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;
-- Inserción de datos
INSERT INTO categorias (categoria) VALUES
 (''),
 ('Portátiles'),
 ('PCs escritorio'),
 ('Impresoras'),
 ('Monitores'),
 ('Teclados'),
 ('Tarjetas vídeo'),
 ('Altavoces'),
 ('Micrófonos');
INSERT INTO marcas (marca) VALUES
 (''),
 ('Brother'),
 ('HP'),
 ('LG'),
 ('Logitech'),
 ('Lenovo'),
 ('Asus'),
 ('Dell'),
 ('Sansumg'),
 ('Gygabyte'),
 ('Epson'),
 ('Nvidia');
 
 
INSERT INTO productos VALUES (DEFAULT, 1, 1, 200, 'Ratón', 20, 1, '***');
INSERT INTO productos VALUES (DEFAULT, 2, 1, 300, 'Teclado', 30, 5, '*****');
INSERT INTO productos VALUES (DEFAULT, 2, 2, 400, 'Pantalla', 200, 3, '***');