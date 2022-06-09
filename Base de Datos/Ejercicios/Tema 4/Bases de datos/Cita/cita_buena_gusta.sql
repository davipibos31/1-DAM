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
-- Table structure for table `gusta`
--

DROP TABLE IF EXISTS `gusta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gusta` (
  `nom_usuario_1` varchar(20) NOT NULL,
  `nom_usuario_2` varchar(20) NOT NULL,
  PRIMARY KEY (`nom_usuario_1`,`nom_usuario_2`),
  KEY `nom_usuario_2` (`nom_usuario_2`),
  CONSTRAINT `gusta_ibfk_1` FOREIGN KEY (`nom_usuario_1`) REFERENCES `usuario` (`nom_usuario`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `gusta_ibfk_2` FOREIGN KEY (`nom_usuario_2`) REFERENCES `usuario` (`nom_usuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gusta`
--

LOCK TABLES `gusta` WRITE;
/*!40000 ALTER TABLE `gusta` DISABLE KEYS */;
INSERT INTO `gusta` VALUES ('djrodrigo','avmiranda'),('emgonzalez','cgramos'),('sggarcia','cgramos'),('vprodriguez','cgramos'),('jgbermudez','esfigueroa'),('rvquiroga','esfigueroa'),('apruiz','lpmedina'),('djrodrigo','lpmedina'),('emgonzalez','mrreyes'),('vprodriguez','mrreyes'),('djrodrigo','rmsalazar'),('vprodriguez','rmsalazar'),('rvquiroga','rshernandez'),('emgonzalez','sbortega'),('rvquiroga','sbortega'),('jgbermudez','stmedina'),('apruiz','vgmartinez'),('djrodrigo','vgmartinez'),('vprodriguez','vgmartinez');
/*!40000 ALTER TABLE `gusta` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-03-24  9:26:36
