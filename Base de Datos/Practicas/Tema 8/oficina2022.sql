-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: oficina
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
-- Table structure for table `departamento`
--

DROP TABLE IF EXISTS `departamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `departamento` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamento`
--

LOCK TABLES `departamento` WRITE;
/*!40000 ALTER TABLE `departamento` DISABLE KEYS */;
INSERT INTO `departamento` VALUES (1,'Matemáticas'),(2,'Inglés'),(3,'Informática'),(4,'Dibujo'),(5,'Filosofía');
/*!40000 ALTER TABLE `departamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `despacho`
--

DROP TABLE IF EXISTS `despacho`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `despacho` (
  `codigo` char(4) NOT NULL,
  `telefono` varchar(12) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `despacho`
--

LOCK TABLES `despacho` WRITE;
/*!40000 ALTER TABLE `despacho` DISABLE KEYS */;
INSERT INTO `despacho` VALUES ('DP01','960856563'),('DP02','960856564'),('DP03','960856565');
/*!40000 ALTER TABLE `despacho` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleado` (
  `id` smallint NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `despacho` char(4) DEFAULT NULL,
  `departamento` int NOT NULL,
  `salario` decimal(10,2) DEFAULT '1200.00',
  PRIMARY KEY (`id`),
  UNIQUE KEY `despacho` (`despacho`),
  KEY `empleado_departamento_fk` (`departamento`),
  CONSTRAINT `empleado_departamento_fk` FOREIGN KEY (`departamento`) REFERENCES `departamento` (`id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `empleado_despacho_fk` FOREIGN KEY (`despacho`) REFERENCES `despacho` (`codigo`) ON DELETE CASCADE ON UPDATE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
INSERT INTO `empleado` VALUES (1,'Juan',NULL,3,1200.00),(2,'Sonia',NULL,5,1200.00),(3,'Martín',NULL,2,1200.00),(4,'Boris',NULL,2,2500.00),(5,'Laura',NULL,1,1200.00),(9,'Pedro','DP01',2,1200.00),(10,'Sonia','DP02',2,1200.00),(11,'Lucía','DP03',1,1200.00);
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reserva`
--

DROP TABLE IF EXISTS `reserva`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reserva` (
  `id` smallint NOT NULL AUTO_INCREMENT,
  `empleado` smallint NOT NULL,
  `sala_reuniones` char(4) NOT NULL,
  `fecha_inicio` date DEFAULT NULL,
  `fecha_fin` date DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `reserva_empleado_fk` (`empleado`),
  KEY `reserva_sala_reuniones_fk` (`sala_reuniones`),
  CONSTRAINT `reserva_empleado_fk` FOREIGN KEY (`empleado`) REFERENCES `empleado` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `reserva_sala_reuniones_fk` FOREIGN KEY (`sala_reuniones`) REFERENCES `sala_reuniones` (`codigo`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `fecha_fin_ck` CHECK ((`fecha_fin` > `fecha_inicio`))
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reserva`
--

LOCK TABLES `reserva` WRITE;
/*!40000 ALTER TABLE `reserva` DISABLE KEYS */;
INSERT INTO `reserva` VALUES (1,1,'SR01','2020-10-10','2021-10-10');
/*!40000 ALTER TABLE `reserva` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sala_reuniones`
--

DROP TABLE IF EXISTS `sala_reuniones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sala_reuniones` (
  `codigo` char(4) NOT NULL,
  `metros` decimal(4,1) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sala_reuniones`
--

LOCK TABLES `sala_reuniones` WRITE;
/*!40000 ALTER TABLE `sala_reuniones` DISABLE KEYS */;
INSERT INTO `sala_reuniones` VALUES ('SR01',20.5),('SR02',30.0),('SR03',20.0),('SR04',25.0);
/*!40000 ALTER TABLE `sala_reuniones` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-03-15 10:31:45
