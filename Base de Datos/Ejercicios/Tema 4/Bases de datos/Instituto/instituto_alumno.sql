-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: instituto
-- ------------------------------------------------------
-- Server version	8.0.27

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `alumno`
--

DROP TABLE IF EXISTS `alumno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `alumno` (
  `DNI` varchar(9) NOT NULL,
  `nombre` varchar(20) DEFAULT NULL,
  `apellido1` varchar(20) DEFAULT NULL,
  `apellido2` varchar(20) DEFAULT NULL,
  `fechNac` date DEFAULT NULL,
  PRIMARY KEY (`DNI`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alumno`
--

LOCK TABLES `alumno` WRITE;
/*!40000 ALTER TABLE `alumno` DISABLE KEYS */;
INSERT INTO `alumno` VALUES ('10937582A','Eduardo','González','García','1998-01-01'),('22314780L','Elias','Rodriguez','Hernandez','1998-05-09'),('23145236L','Cintia','Rodriguez','Medina','1999-05-20'),('34104567J','Raul','Diaz','Silva','1999-01-09'),('43214352H','Rebeca','Blanco','Gonzalez','1998-05-30'),('45326478P','Arturo','Garcia','Gomez','1999-03-06'),('45673195B','Enrique','Suarez','Molina','1998-05-12'),('54323465R','Gloria','Martínez','Fernandez','1999-05-18'),('54389210D','Alejandro','Ledesma','Escobar','1998-08-06'),('54676638V','Matias','Mejía','Zambrano','1999-06-07'),('56323453G','Beatriz','Bermudez','Campo','1998-11-03'),('56436785N','Elvira','Hernandez','Sanchez','1999-11-14'),('56640176R','Felipe','Sanchez','Garcia','1999-06-17'),('56703214D','Bruno','Torres','Moreno','1998-10-14'),('56743284K','Marcos','Perez','Gutierrez','1998-04-17'),('65473823J','Catalina','Ortega','Caballero','1998-03-02'),('65473877K','Carmen','Castillo','Moreno','1998-03-22'),('67392863B','Cesar','Gomez','Sanchez','1998-01-04'),('67863211G','Gustavo','Jimenez','Ortiz','1998-07-13'),('67884320V','Raquel','Ortiz','Carvajal','1999-03-11'),('67895435H','Amanda','Martínez','Rojas','1998-08-24'),('67908723N','Delia','Salazar','Gutierrez','1999-01-03'),('68875034D','Carlos','Fuentes','Cruz','1999-04-24'),('68902134C','Aaron','Quiroga','Vazquez','1998-03-21'),('70119023S','Guillermo','Fuentes','Vega','1999-11-29'),('73902451B','Elisa','Fernandez','Medina','1998-02-07'),('76548932M','Diana','Reyes','Martínez','1999-05-01'),('76589023T','Celia','Gutierrez','Vera','1999-08-01'),('76657403J','Sergio','Soto','Carrasco','1999-01-04'),('76893452G','Saul','Garcia','Cardenas','1999-09-13'),('76899345F','Tatiana','Garrido','Medina','1999-10-09'),('76899654C','Sonia','Mendoza','Castro','1999-06-18'),('78392053A','Elena','Rodriguez','Perez','1998-01-04'),('78543289P','Esmeralda','Fernandez','Reyes','1999-03-25'),('78563401C','David','Romero','Vega','1998-02-18'),('78932434F','Felix','Ramos','Ortega','1998-11-09'),('80778905S','Blanca','Ramos','Lopez','1999-12-04'),('80987689T','Maite','Nuñez','Bermudez','1999-12-31'),('90067312F','Azucena','Morales','Lopez','1998-12-17'),('90765402M','Adrian','Jimenez','Figueroa','1999-02-17');
/*!40000 ALTER TABLE `alumno` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-03-24  9:28:39
