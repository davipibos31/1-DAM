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
-- Table structure for table `ensenya`
--

DROP TABLE IF EXISTS `ensenya`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ensenya` (
  `profesor` varchar(9) NOT NULL,
  `asignatura` int NOT NULL,
  `grupo` varchar(2) NOT NULL,
  PRIMARY KEY (`profesor`,`asignatura`,`grupo`),
  KEY `asignatura` (`asignatura`),
  CONSTRAINT `ensenya_ibfk_1` FOREIGN KEY (`profesor`) REFERENCES `profesor` (`DNI`),
  CONSTRAINT `ensenya_ibfk_2` FOREIGN KEY (`asignatura`) REFERENCES `asignatura` (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ensenya`
--

LOCK TABLES `ensenya` WRITE;
/*!40000 ALTER TABLE `ensenya` DISABLE KEYS */;
INSERT INTO `ensenya` VALUES ('55400892G',1,'1A'),('55400892G',1,'1B'),('54430287J',2,'2A'),('54430287J',2,'2B'),('76566708T',3,'1A'),('76566708T',3,'1B'),('78896563A',4,'2A'),('78896563A',4,'2B'),('11900567T',5,'1A'),('11900567T',6,'2A'),('45362734P',7,'1A'),('45362734P',7,'1B'),('78905435S',8,'2A'),('78905435S',8,'2B'),('78934567M',9,'1A'),('78934567M',10,'2A'),('67743002D',11,'1B'),('67743002D',12,'2B'),('76686546D',13,'1B'),('76686546D',14,'2B');
/*!40000 ALTER TABLE `ensenya` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-03-24  9:28:40
