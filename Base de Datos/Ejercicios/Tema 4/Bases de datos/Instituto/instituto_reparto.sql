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
-- Table structure for table `reparto`
--

DROP TABLE IF EXISTS `reparto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reparto` (
  `alumno` varchar(9) NOT NULL,
  `grupo` varchar(2) DEFAULT NULL,
  PRIMARY KEY (`alumno`),
  CONSTRAINT `reparto_ibfk_1` FOREIGN KEY (`alumno`) REFERENCES `alumno` (`DNI`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reparto`
--

LOCK TABLES `reparto` WRITE;
/*!40000 ALTER TABLE `reparto` DISABLE KEYS */;
INSERT INTO `reparto` VALUES ('10937582A','1A'),('22314780L','2A'),('23145236L','1B'),('34104567J','2B'),('43214352H','2A'),('45326478P','1B'),('45673195B','1A'),('54323465R','1B'),('54389210D','1A'),('54676638V','2B'),('56323453G','2A'),('56436785N','1B'),('56640176R','1B'),('56703214D','1A'),('56743284K','2A'),('65473823J','2A'),('65473877K','2A'),('67392863B','1A'),('67863211G','2A'),('67884320V','2B'),('67895435H','2A'),('67908723N','1B'),('68875034D','2B'),('68902134C','1A'),('70119023S','1B'),('73902451B','1A'),('76548932M','1B'),('76589023T','2B'),('76657403J','2B'),('76893452G','2B'),('76899345F','2B'),('76899654C','2B'),('78392053A','1A'),('78543289P','1B'),('78563401C','1A'),('78932434F','1A'),('80778905S','2B'),('80987689T','2B'),('90067312F','2A'),('90765402M','1B');
/*!40000 ALTER TABLE `reparto` ENABLE KEYS */;
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
