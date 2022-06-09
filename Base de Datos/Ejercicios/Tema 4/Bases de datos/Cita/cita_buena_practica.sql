-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: cita_buena
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
-- Table structure for table `practica`
--

DROP TABLE IF EXISTS `practica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `practica` (
  `nom_usuario` varchar(20) NOT NULL,
  `aficion` int NOT NULL,
  `frecuencia` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`nom_usuario`,`aficion`),
  KEY `aficion` (`aficion`),
  CONSTRAINT `practica_ibfk_1` FOREIGN KEY (`nom_usuario`) REFERENCES `usuario` (`nom_usuario`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `practica_ibfk_2` FOREIGN KEY (`aficion`) REFERENCES `aficion` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `practica`
--

LOCK TABLES `practica` WRITE;
/*!40000 ALTER TABLE `practica` DISABLE KEYS */;
INSERT INTO `practica` VALUES ('apruiz',7,'todos los meses'),('avmiranda',7,'todas las semanas'),('cgramos',4,'a diario'),('djrodrigo',2,'todas las semanas'),('djrodrigo',4,'todos los meses'),('emgonzalez',1,'todos los meses'),('emgonzalez',2,'todas las semanas'),('emgonzalez',3,'a diario'),('esfigueroa',1,'a diario'),('esfigueroa',4,'a diario'),('jgbermudez',1,'a diario'),('jgbermudez',2,'a diario'),('jgbermudez',4,'a diario'),('lpmedina',1,'todas las semanas'),('lpmedina',3,'a diario'),('mrreyes',3,'a diario'),('rmsalazar',2,'todas las semanas'),('rmsalazar',6,'todos los meses'),('rmsalazar',7,'todas las semanas'),('rshernandez',1,'todas las semanas'),('rvquiroga',2,'todas las semanas'),('rvquiroga',5,'todos los meses'),('rvquiroga',6,'todas las semanas'),('sbortega',3,'a diario'),('sggarcia',2,'todos los meses'),('sggarcia',7,'a diario'),('stmedina',7,'todas las semanas'),('vgmartinez',5,'todas las semanas'),('vprodriguez',3,'todas las semanas');
/*!40000 ALTER TABLE `practica` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-03-24  9:26:35
