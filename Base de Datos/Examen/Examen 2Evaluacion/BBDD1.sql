CREATE TABLE fabricantes (
  codigo INTEGER,
  nombre VARCHAR(255) NOT NULL,
  PRIMARY KEY (codigo)   
);

CREATE TABLE productos (
  codigo INTEGER,
  nombre VARCHAR(255) NOT NULL ,
  precio DECIMAL NOT NULL ,
  fabricante INTEGER NOT NULL,
  PRIMARY KEY (codigo), 
  FOREIGN KEY (fabricante) REFERENCES fabricantes(codigo)
) ENGINE=INNODB;

INSERT INTO fabricantes(codigo,nombre) VALUES(1,'Sony');
INSERT INTO fabricantes(codigo,nombre) VALUES(2,'Creative Labs');
INSERT INTO fabricantes(codigo,nombre) VALUES(3,'Hewlett-Packard');
INSERT INTO fabricantes(codigo,nombre) VALUES(4,'Iomega');
INSERT INTO fabricantes(codigo,nombre) VALUES(5,'Fujitsu');
INSERT INTO fabricantes(codigo,nombre) VALUES(6,'Winchester');

INSERT INTO productos(codigo,nombre,precio,fabricante) VALUES(1,'Hard drive',240,5);
INSERT INTO productos(codigo,nombre,precio,fabricante) VALUES(2,'Memory',120,6);
INSERT INTO productos(codigo,nombre,precio,fabricante) VALUES(3,'ZIP drive',150,4);
INSERT INTO productos(codigo,nombre,precio,fabricante) VALUES(4,'Floppy disk',5,6);
INSERT INTO productos(codigo,nombre,precio,fabricante) VALUES(5,'Monitor',240,1);
INSERT INTO productos(codigo,nombre,precio,fabricante) VALUES(6,'DVD drive',180,2);
INSERT INTO productos(codigo,nombre,precio,fabricante) VALUES(7,'CD drive',90,2);
INSERT INTO productos(codigo,nombre,precio,fabricante) VALUES(8,'Printer',270,3);
INSERT INTO productos(codigo,nombre,precio,fabricante) VALUES(9,'Toner cartridge',66,3);
INSERT INTO productos(codigo,nombre,precio,fabricante) VALUES(10,'DVD burner',180,2);

