-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: comercio_buena
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
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `codigo` varchar(50) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `direccion` varchar(50) DEFAULT NULL,
  `cp` int DEFAULT NULL,
  `municipio` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`codigo`),
  KEY `municipio` (`municipio`),
  CONSTRAINT `cliente_ibfk_1` FOREIGN KEY (`municipio`) REFERENCES `municipio` (`codigo`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES ('1','Andrés','Calle Eleuterio Rincones 3',12001,'CSTLL'),('10','Antonio','Calle San Pedro 34',46901,'TRRNT'),('11','Eva','Calle Barcelona 23',46701,'GND'),('12','Isaac','Avenida Germanías',46981,'PTRN'),('13','Lucía','Calle General Elio 3',46005,'VLNC'),('14','Elena','Avenida Peris y Valero 32',46901,'TRRNT'),('15','Raquel','Calle Gutenberg 2',46701,'GND'),('16','Sofía','Avenida Marconi 23',46980,'PTRN'),('17','Marco','Calle Río Tajo 56',46500,'SGNT'),('18','Oliver','Calle Utiel 12',3001,'LCNT'),('19','Alba','Calle Jabonería Nueva 3',3203,'LCH'),('2','Jonás','Pasaje de la Constitución 1',12540,'VLLRL'),('20','Noemi','Plaza Centenar de la Ploma 88',3181,'TRRVJ'),('21','Narciso','Calle San Pancracio 17',3501,'BNDRM'),('22','Nadia','Calle Doctor Nicasio 43',3311,'RHL'),('23','Esteban','Calle Italia 3',3002,'LCNT'),('24','Ricardo','Calle San Eleuterio 65',3203,'LCH'),('25','María','Calle Menudencia 1',3181,'TRRVJ'),('26','Ernesto','Avenida del péndulo, 4',3181,'TRRVJ'),('3','Michel','Calle de Serrano 23',12530,'BRRN'),('4','Estanislao','Avenida de Alicante 45',12600,'VLLDX'),('5','Antolín','Plaza de Santa María 2',12500,'VNRZ'),('6','Arlette','Calle Málaga 23',12580,'BNCRL'),('7','Ernesto','Calle Revilla 23',12581,'BNCRL'),('8','Cintia','Plaza del Algarrobo 2',12002,'CSTLL'),('9','Vicente','Calle Severo Ochoa 12',12542,'VLLRL');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-03-24  9:27:17
