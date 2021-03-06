-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: localhost    Database: cine
-- ------------------------------------------------------
-- Server version	8.0.22

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
-- Table structure for table `cine`
--

DROP DATABASE IF EXISTS `cine`;
CREATE DATABASE `cine`;
USE `cine`;
DROP TABLE IF EXISTS `cine`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cine` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `ciudad` varchar(50) DEFAULT NULL,
  `provincia` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cine`
--

LOCK TABLES `cine` WRITE;
/*!40000 ALTER TABLE `cine` DISABLE KEYS */;
INSERT INTO `cine` VALUES (1,'Cines Vistahermosa','C/ Pedro Medario 3','Alicante','Alicante'),(2,'Cines El Salvador','C/ De la Pasa 10','Elche','Alicante'),(3,'Cines Ruzafa','C/ Alan Brito 1','Valencia','Valencia'),(4,'Cines Corea','C/ Edgar Gajo 45','Gandía','Valencia'),(5,'Cines Benlloch','C/ Susana Torio 6','Castellón de la Plana','Castellón'),(6,'Cines Benicasim','C/ Germán Zana 23','Benicasim','Castellón');
/*!40000 ALTER TABLE `cine` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compra`
--

DROP TABLE IF EXISTS `compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `compra` (
  `socio` char(9) NOT NULL,
  `entrada` int NOT NULL,
  `descuento_aplicado` decimal(4,2) DEFAULT NULL,
  PRIMARY KEY (`socio`,`entrada`),
  KEY `entrada` (`entrada`),
  CONSTRAINT `compra_ibfk_1` FOREIGN KEY (`entrada`) REFERENCES `entrada` (`id`),
  CONSTRAINT `compra_ibfk_2` FOREIGN KEY (`socio`) REFERENCES `socio` (`dni`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compra`
--

LOCK TABLES `compra` WRITE;
/*!40000 ALTER TABLE `compra` DISABLE KEYS */;
INSERT INTO `compra` VALUES ('12340000A',154,0.05),('12340000A',535,0.05),('12340000A',559,0.15),('12340000A',841,0.05),('12340000A',896,0.15),('12345678A',144,0.00),('12345678A',257,0.00),('21500123P',19,0.05),('21500123P',43,0.15),('21500123P',84,0.05),('21500123P',133,0.05),('21500123P',157,0.05),('21500123P',236,0.10),('21500123P',385,0.10),('21500123P',397,0.15),('21500123P',474,0.10),('21500123P',643,0.15),('21500123P',739,0.10),('21500123P',822,0.05),('39485729G',57,0.15),('39485729G',75,0.15),('39485729G',169,0.15),('39485729G',202,0.15),('39485729G',266,0.15),('39485729G',384,0.15),('39485729G',541,0.15),('39485729G',574,0.15),('39485729G',585,0.15),('39485729G',786,0.15),('43240000B',69,0.05),('43240000B',818,0.05),('45123467L',298,0.00),('45123467L',623,0.05),('48756900R',240,0.10),('48756900R',260,0.10),('48756900R',295,0.10),('48756900R',411,0.10),('56789209F',315,0.15),('56789209F',856,0.15),('80805553C',379,0.10),('80805553C',393,0.05),('80805553C',469,0.15),('80805553C',713,0.10),('91283712Z',206,0.10),('91283712Z',352,0.10),('91283712Z',432,0.10),('91283712Z',602,0.10);
/*!40000 ALTER TABLE `compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `entrada`
--

DROP TABLE IF EXISTS `entrada`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `entrada` (
  `id` int NOT NULL AUTO_INCREMENT,
  `sesion` int NOT NULL,
  `precio_final` decimal(4,2) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `sesion` (`sesion`),
  CONSTRAINT `entrada_ibfk_1` FOREIGN KEY (`sesion`) REFERENCES `sesion` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=918 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `entrada`
--

LOCK TABLES `entrada` WRITE;
/*!40000 ALTER TABLE `entrada` DISABLE KEYS */;
INSERT INTO `entrada` VALUES (1,1,6.00),(2,1,6.00),(3,1,6.00),(4,1,6.00),(5,2,7.50),(6,2,7.50),(7,2,7.50),(8,2,7.50),(9,2,7.50),(10,3,4.50),(11,3,4.50),(12,3,4.50),(13,3,4.50),(14,3,4.50),(15,3,4.50),(16,3,4.50),(17,3,4.50),(18,3,4.50),(19,3,4.28),(20,3,4.50),(21,4,7.50),(22,4,7.50),(23,4,7.50),(24,4,7.50),(25,4,7.50),(26,4,7.50),(27,4,7.50),(28,4,7.50),(29,4,7.50),(30,4,7.50),(31,4,7.50),(32,4,7.50),(33,4,7.50),(34,4,7.50),(35,4,7.50),(36,4,7.50),(37,4,7.50),(38,4,7.50),(39,4,7.50),(40,5,6.00),(41,5,6.00),(42,5,6.00),(43,5,5.10),(44,5,6.00),(45,5,6.00),(46,5,6.00),(47,5,6.00),(48,5,6.00),(49,5,6.00),(50,5,6.00),(51,5,6.00),(52,5,6.00),(53,5,6.00),(54,5,6.00),(55,5,6.00),(56,5,6.00),(57,6,5.10),(58,6,6.00),(59,6,6.00),(60,6,6.00),(61,6,5.70),(62,6,6.00),(63,6,6.00),(64,6,6.00),(65,6,6.00),(66,6,6.00),(67,6,6.00),(68,6,6.00),(69,6,5.70),(70,6,6.00),(71,7,7.50),(72,7,7.50),(73,7,7.50),(74,7,7.50),(75,7,6.38),(76,7,7.50),(77,7,7.50),(78,7,7.50),(79,7,7.50),(80,7,7.50),(81,7,7.50),(82,7,7.50),(83,7,7.50),(84,8,7.13),(85,8,7.50),(86,8,7.50),(87,8,7.50),(88,8,7.50),(89,8,7.50),(90,8,7.50),(91,8,7.50),(92,8,7.50),(93,8,7.50),(94,8,7.50),(95,8,7.50),(96,8,7.50),(97,9,6.00),(98,9,6.00),(99,9,6.00),(100,9,6.00),(101,9,6.00),(102,9,6.00),(103,9,6.00),(104,10,6.00),(105,10,6.00),(106,10,6.00),(107,10,6.00),(108,10,6.00),(109,10,6.00),(110,10,6.00),(111,10,6.00),(112,10,6.00),(113,10,6.00),(114,10,6.00),(115,10,6.00),(116,10,6.00),(117,11,6.00),(118,11,6.00),(119,11,6.00),(120,11,6.00),(121,11,6.00),(122,11,6.00),(123,11,6.00),(124,11,6.00),(125,11,6.00),(126,11,6.00),(127,12,6.00),(128,12,6.00),(129,12,6.00),(130,12,6.00),(131,12,6.00),(132,12,6.00),(133,12,5.70),(134,12,6.00),(135,12,6.00),(136,12,6.00),(137,12,6.00),(138,12,6.00),(139,12,6.00),(140,13,7.50),(141,13,7.50),(142,13,7.50),(143,13,7.50),(144,13,7.50),(145,13,7.50),(146,13,7.50),(147,13,7.50),(148,13,7.50),(149,13,7.50),(150,13,7.50),(151,14,6.00),(152,14,6.00),(153,14,6.00),(154,14,5.70),(155,15,4.50),(156,15,4.50),(157,15,4.07),(158,15,4.50),(159,15,4.50),(160,15,4.50),(161,15,4.50),(162,15,4.50),(163,15,4.50),(164,16,6.00),(165,16,6.00),(166,16,6.00),(167,16,6.00),(168,16,6.00),(169,16,5.10),(170,16,NULL),(171,16,6.00),(172,16,6.00),(173,16,6.00),(174,17,7.50),(175,17,7.50),(176,17,7.50),(177,17,7.50),(178,17,7.50),(179,17,7.50),(180,17,7.50),(181,17,7.50),(182,17,7.50),(183,18,4.50),(184,18,4.50),(185,18,4.50),(186,18,4.50),(187,18,4.50),(188,18,4.50),(189,18,4.50),(190,18,4.50),(191,18,4.50),(192,18,4.50),(193,18,4.50),(194,18,4.50),(195,18,NULL),(196,18,4.50),(197,18,4.50),(198,18,4.50),(199,18,4.50),(200,18,4.50),(201,18,4.50),(202,18,3.83),(203,18,4.50),(204,19,7.50),(205,19,7.50),(206,19,6.75),(207,19,7.50),(208,19,7.50),(209,19,7.50),(210,19,7.50),(211,19,7.50),(212,19,7.50),(213,19,7.50),(214,19,7.50),(215,19,7.50),(216,19,7.50),(217,19,7.50),(218,19,7.50),(219,19,7.50),(220,19,7.50),(221,19,7.50),(222,19,7.50),(223,19,7.50),(224,19,7.50),(225,19,7.50),(226,20,6.00),(227,20,6.00),(228,20,6.00),(229,20,6.00),(230,20,6.00),(231,20,6.00),(232,20,6.00),(233,20,6.00),(234,20,6.00),(235,20,6.00),(236,20,5.40),(237,20,6.00),(238,20,6.00),(239,20,6.00),(240,20,5.40),(241,20,6.00),(242,20,6.00),(243,20,6.00),(244,20,6.00),(245,20,6.00),(246,20,6.00),(247,20,6.00),(248,20,6.00),(249,20,6.00),(250,20,6.00),(251,20,6.00),(252,21,6.00),(253,21,6.00),(254,21,6.00),(255,21,6.00),(256,21,6.00),(257,21,6.00),(258,21,6.00),(259,21,6.00),(260,21,5.40),(261,21,6.00),(262,21,6.00),(263,21,6.00),(264,21,6.00),(265,21,6.00),(266,21,5.10),(267,21,6.00),(268,21,6.00),(269,21,6.00),(270,21,6.00),(271,21,6.00),(272,22,7.50),(273,22,7.50),(274,22,7.50),(275,22,7.50),(276,22,7.50),(277,22,7.50),(278,22,7.50),(279,22,7.50),(280,22,7.50),(281,22,7.50),(282,22,7.50),(283,22,7.50),(284,22,7.50),(285,22,7.50),(286,22,7.50),(287,22,7.50),(288,23,7.50),(289,23,7.50),(290,23,7.50),(291,23,7.50),(292,23,7.50),(293,23,7.50),(294,23,7.50),(295,23,6.75),(296,23,7.50),(297,23,7.50),(298,23,7.50),(299,23,7.50),(300,23,7.50),(301,23,7.50),(302,23,7.50),(303,23,7.50),(304,23,7.50),(305,24,6.00),(306,24,6.00),(307,24,6.00),(308,24,6.00),(309,24,6.00),(310,24,6.00),(311,24,6.00),(312,24,6.00),(313,24,6.00),(314,24,6.00),(315,24,5.10),(316,24,6.00),(317,24,6.00),(318,24,6.00),(319,24,6.00),(320,24,6.00),(321,24,6.00),(322,24,6.00),(323,25,6.00),(324,25,6.00),(325,25,6.00),(326,25,6.00),(327,25,6.00),(328,25,6.00),(329,25,6.00),(330,25,6.00),(331,25,6.00),(332,25,6.00),(333,25,6.00),(334,25,6.00),(335,25,6.00),(336,25,6.00),(337,25,6.00),(338,25,6.00),(339,25,6.00),(340,25,6.00),(341,25,6.00),(342,25,6.00),(343,25,6.00),(344,25,6.00),(345,25,6.00),(346,25,6.00),(347,25,6.00),(348,25,6.00),(349,26,6.00),(350,26,6.00),(351,26,6.00),(352,26,5.40),(353,26,6.00),(354,26,6.00),(355,26,6.00),(356,26,6.00),(357,26,6.00),(358,26,6.00),(359,26,6.00),(360,26,6.00),(361,26,6.00),(362,26,6.00),(363,26,6.00),(364,26,6.00),(365,27,4.50),(366,27,4.50),(367,27,4.50),(368,27,4.50),(369,27,4.50),(370,27,4.50),(371,27,4.50),(372,27,4.50),(373,27,4.50),(374,27,4.50),(375,27,4.50),(376,27,4.50),(377,27,4.50),(378,27,4.50),(379,27,4.05),(380,27,4.50),(381,27,4.50),(382,27,4.50),(383,27,4.50),(384,27,3.83),(385,27,4.05),(386,27,4.50),(387,27,4.50),(388,27,4.50),(389,28,6.00),(390,28,6.00),(391,28,6.00),(392,28,6.00),(393,28,5.70),(394,28,6.00),(395,28,6.00),(396,28,6.00),(397,28,5.10),(398,28,6.00),(399,28,6.00),(400,28,6.00),(401,28,6.00),(402,28,6.00),(403,28,6.00),(404,28,6.00),(405,28,6.00),(406,28,6.00),(407,28,6.00),(408,28,6.00),(409,28,6.00),(410,28,6.00),(411,28,5.40),(412,28,6.00),(413,28,6.00),(414,28,6.00),(415,28,6.00),(416,28,6.00),(417,28,6.00),(418,28,6.00),(419,29,4.50),(420,29,4.50),(421,29,4.50),(422,29,4.50),(423,29,4.50),(424,29,4.50),(425,29,4.50),(426,29,4.50),(427,29,4.50),(428,29,4.50),(429,29,4.50),(430,29,4.50),(431,29,4.50),(432,29,4.05),(433,29,4.50),(434,29,4.50),(435,29,4.50),(436,30,6.00),(437,30,6.00),(438,30,6.00),(439,30,6.00),(440,30,6.00),(441,30,6.00),(442,30,6.00),(443,30,6.00),(444,30,6.00),(445,30,6.00),(446,30,6.00),(447,30,6.00),(448,30,6.00),(449,31,4.50),(450,31,4.50),(451,31,4.50),(452,31,4.50),(453,31,4.50),(454,31,4.50),(455,31,4.50),(456,31,4.50),(457,31,4.50),(458,31,4.50),(459,31,4.50),(460,31,4.50),(461,32,4.50),(462,32,4.50),(463,32,4.50),(464,32,4.50),(465,32,4.50),(466,32,4.50),(467,32,NULL),(468,32,4.50),(469,32,3.83),(470,33,6.00),(471,33,6.00),(472,33,NULL),(473,33,6.00),(474,33,5.40),(475,33,6.00),(476,33,6.00),(477,33,6.00),(478,33,6.00),(479,33,6.00),(480,33,6.00),(481,33,6.00),(482,33,6.00),(483,33,6.00),(484,34,4.50),(485,34,4.50),(486,34,4.50),(487,34,4.50),(488,34,4.50),(489,34,4.50),(490,34,4.50),(491,34,4.50),(492,34,4.50),(493,34,4.50),(494,34,4.50),(495,34,4.50),(496,34,4.50),(497,34,4.50),(498,34,4.50),(499,34,4.50),(500,34,4.50),(501,34,4.50),(502,34,4.50),(503,34,4.50),(504,34,4.50),(505,34,4.50),(506,34,4.50),(507,34,4.50),(508,34,4.50),(509,34,4.50),(510,34,4.50),(511,34,4.50),(512,34,4.50),(513,34,4.50),(514,35,7.50),(515,35,7.50),(516,35,7.50),(517,35,7.50),(518,35,7.50),(519,35,7.50),(520,35,7.50),(521,35,7.50),(522,35,7.50),(523,35,7.50),(524,35,7.50),(525,35,7.50),(526,35,7.50),(527,35,7.50),(528,35,7.50),(529,35,7.50),(530,35,7.50),(531,35,7.50),(532,35,7.50),(533,35,7.50),(534,35,7.50),(535,35,7.13),(536,35,7.50),(537,35,7.50),(538,35,7.50),(539,35,7.50),(540,35,7.50),(541,36,5.10),(542,36,6.00),(543,36,6.00),(544,36,6.00),(545,36,NULL),(546,36,6.00),(547,36,6.00),(548,36,6.00),(549,36,6.00),(550,36,6.00),(551,36,6.00),(552,36,6.00),(553,36,6.00),(554,36,6.00),(555,36,6.00),(556,36,6.00),(557,36,6.00),(558,36,6.00),(559,37,6.38),(560,37,7.50),(561,37,7.50),(562,37,7.50),(563,37,7.50),(564,37,7.50),(565,37,7.50),(566,37,7.50),(567,37,7.50),(568,37,7.50),(569,37,7.50),(570,37,7.50),(571,37,7.50),(572,37,7.50),(573,37,7.50),(574,37,6.38),(575,37,7.50),(576,37,7.50),(577,37,7.50),(578,37,7.50),(579,38,6.00),(580,38,6.00),(581,38,6.00),(582,38,6.00),(583,38,6.00),(584,38,6.00),(585,38,5.10),(586,38,6.00),(587,38,6.00),(588,38,6.00),(589,38,6.00),(590,38,6.00),(591,38,6.00),(592,38,6.00),(593,38,6.00),(594,38,6.00),(595,38,6.00),(596,38,6.00),(597,39,6.00),(598,39,6.00),(599,39,6.00),(600,39,6.00),(601,39,6.00),(602,39,5.40),(603,39,6.00),(604,39,6.00),(605,39,6.00),(606,39,6.00),(607,39,6.00),(608,39,6.00),(609,39,6.00),(610,39,6.00),(611,39,6.00),(612,39,6.00),(613,39,6.00),(614,39,6.00),(615,40,7.50),(616,40,7.50),(617,40,7.50),(618,40,7.50),(619,40,7.50),(620,40,7.50),(621,40,7.50),(622,40,7.50),(623,40,7.13),(624,40,7.50),(625,40,7.50),(626,40,7.50),(627,40,7.50),(628,40,7.50),(629,40,7.50),(630,40,7.50),(631,40,7.50),(632,40,7.50),(633,40,7.50),(634,40,7.50),(635,44,6.00),(636,44,6.00),(637,44,6.00),(638,44,6.00),(639,44,6.00),(640,44,6.00),(641,44,6.00),(642,44,6.00),(643,44,5.10),(644,44,6.00),(645,44,6.00),(646,45,4.50),(647,45,4.50),(648,45,4.50),(649,45,4.50),(650,45,4.50),(651,45,4.50),(652,45,4.50),(653,45,4.50),(654,45,4.50),(655,45,4.50),(656,45,4.50),(657,45,4.50),(658,45,4.50),(659,45,4.50),(660,46,10.00),(661,46,10.00),(662,46,10.00),(663,46,10.00),(664,46,10.00),(665,46,10.00),(666,46,10.00),(667,46,10.00),(668,46,10.00),(669,46,10.00),(670,46,10.00),(671,46,10.00),(672,46,10.00),(673,46,10.00),(674,46,10.00),(675,47,4.50),(676,47,4.50),(677,47,4.50),(678,47,4.50),(679,47,4.50),(680,47,4.50),(681,47,4.50),(682,47,4.50),(683,47,4.50),(684,47,4.50),(685,47,4.50),(686,47,4.50),(687,47,4.50),(688,47,4.50),(689,47,4.50),(690,47,4.50),(691,47,4.50),(692,47,4.50),(693,47,4.50),(694,48,8.00),(695,48,8.00),(696,48,8.00),(697,48,8.00),(698,48,8.00),(699,48,8.00),(700,48,8.00),(701,48,8.00),(702,48,8.00),(703,48,8.00),(704,48,8.00),(705,48,8.00),(706,48,8.00),(707,48,8.00),(708,49,7.00),(709,49,7.00),(710,49,7.00),(711,49,7.00),(712,49,7.00),(713,49,6.30),(714,49,7.00),(715,49,7.00),(716,49,7.00),(717,49,7.00),(718,49,7.00),(719,49,7.00),(720,49,7.00),(721,49,7.00),(722,49,7.00),(723,50,6.00),(724,50,6.00),(725,50,6.00),(726,50,6.00),(727,50,6.00),(728,50,6.00),(729,50,6.00),(730,50,6.00),(731,50,6.00),(732,50,6.00),(733,50,6.00),(734,50,6.00),(735,50,6.00),(736,50,6.00),(737,50,6.00),(738,51,4.50),(739,51,4.05),(740,51,4.50),(741,51,4.50),(742,51,4.50),(743,51,4.50),(744,51,4.50),(745,51,4.50),(746,51,4.50),(747,51,4.50),(748,51,4.50),(749,51,4.50),(750,51,4.50),(751,51,4.50),(752,51,4.50),(753,51,4.50),(754,51,4.50),(755,52,6.00),(756,52,6.00),(757,52,6.00),(758,52,6.00),(759,52,6.00),(760,52,6.00),(761,52,6.00),(762,52,6.00),(763,52,6.00),(764,52,6.00),(765,52,6.00),(766,52,6.00),(767,53,NULL),(768,53,6.00),(769,53,6.00),(770,53,6.00),(771,53,6.00),(772,53,6.00),(773,53,6.00),(774,53,6.00),(775,53,6.00),(776,53,6.00),(777,53,6.00),(778,53,6.00),(779,53,6.00),(780,53,6.00),(781,53,6.00),(782,54,5.00),(783,54,5.00),(784,54,5.00),(785,54,5.00),(786,54,4.25),(787,54,5.00),(788,54,5.00),(789,54,5.00),(790,54,5.00),(791,54,5.00),(792,54,5.00),(793,54,5.00),(794,54,5.00),(795,54,5.00),(796,54,5.00),(797,54,5.00),(798,55,6.00),(799,55,6.00),(800,55,6.00),(801,55,6.00),(802,55,6.00),(803,55,6.00),(804,55,6.00),(805,55,6.00),(806,55,6.00),(807,55,6.00),(808,55,6.00),(809,55,6.00),(810,55,6.00),(811,55,6.00),(812,56,5.00),(813,56,5.00),(814,56,5.00),(815,56,5.00),(816,56,5.00),(817,56,5.00),(818,56,4.75),(819,56,5.00),(820,56,5.00),(821,56,5.00),(822,56,4.75),(823,56,5.00),(824,56,5.00),(825,56,5.00),(826,56,5.00),(827,57,6.00),(828,57,6.00),(829,57,6.00),(830,57,6.00),(831,57,6.00),(832,57,6.00),(833,57,6.00),(834,57,6.00),(835,57,6.00),(836,57,6.00),(837,57,6.00),(838,57,6.00),(839,57,6.00),(840,57,6.00),(841,57,5.70),(842,57,6.00),(843,58,6.00),(844,58,6.00),(845,58,6.00),(846,58,6.00),(847,58,NULL),(848,58,6.00),(849,58,6.00),(850,58,6.00),(851,58,NULL),(852,58,6.00),(853,58,6.00),(854,58,6.00),(855,58,6.00),(856,58,5.10),(857,59,6.00),(858,59,6.00),(859,59,6.00),(860,59,6.00),(861,59,6.00),(862,59,6.00),(863,59,6.00),(864,59,6.00),(865,59,6.00),(866,59,6.00),(867,59,6.00),(868,59,6.00),(869,59,6.00),(870,59,6.00),(871,59,6.00),(872,59,6.00),(873,59,6.00),(874,59,6.00),(875,59,6.00),(876,60,5.00),(877,60,5.00),(878,60,5.00),(879,60,5.00),(880,60,5.00),(881,60,5.00),(882,60,5.00),(883,60,5.00),(884,60,5.00),(885,60,5.00),(886,60,5.00),(887,60,5.00),(888,60,5.00),(889,60,5.00),(890,60,5.00),(891,60,5.00),(892,60,5.00),(893,60,5.00),(894,60,5.00),(895,60,5.00),(896,60,4.25),(897,60,5.00),(898,60,5.00),(899,60,5.00),(900,60,5.00),(901,60,5.00),(902,60,5.00),(903,60,5.00),(904,60,5.00),(905,60,5.00),(906,60,5.00),(907,60,5.00),(908,60,5.00),(909,60,5.00),(910,60,5.00),(911,60,5.00),(912,60,5.00),(913,60,5.00),(914,60,5.00),(915,60,5.00),(916,60,5.00),(917,60,5.00);
/*!40000 ALTER TABLE `entrada` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipa`
--

DROP TABLE IF EXISTS `equipa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `equipa` (
  `sala` int NOT NULL,
  `equipamiento` int NOT NULL,
  PRIMARY KEY (`sala`,`equipamiento`),
  KEY `equipamiento` (`equipamiento`),
  CONSTRAINT `equipa_ibfk_1` FOREIGN KEY (`sala`) REFERENCES `sala` (`id`),
  CONSTRAINT `equipa_ibfk_2` FOREIGN KEY (`equipamiento`) REFERENCES `equipamiento` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipa`
--

LOCK TABLES `equipa` WRITE;
/*!40000 ALTER TABLE `equipa` DISABLE KEYS */;
INSERT INTO `equipa` VALUES (1,1),(6,1),(7,1),(12,1),(19,1),(22,1),(7,2),(19,2),(1,3),(6,3),(7,3),(8,3),(12,3),(15,3),(19,3),(20,3),(21,3),(22,3),(6,4),(19,4);
/*!40000 ALTER TABLE `equipa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipamiento`
--

DROP TABLE IF EXISTS `equipamiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `equipamiento` (
  `id` int NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipamiento`
--

LOCK TABLES `equipamiento` WRITE;
/*!40000 ALTER TABLE `equipamiento` DISABLE KEYS */;
INSERT INTO `equipamiento` VALUES (1,'Sonido Dolby Atmos'),(2,'Butacas XXL'),(3,'Proyector 3D'),(4,'IMAX');
/*!40000 ALTER TABLE `equipamiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pelicula`
--

DROP TABLE IF EXISTS `pelicula`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pelicula` (
  `id` int NOT NULL AUTO_INCREMENT,
  `titulo` varchar(50) DEFAULT NULL,
  `genero` varchar(50) DEFAULT NULL,
  `duracion` int DEFAULT NULL,
  `edad_minima` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pelicula`
--

LOCK TABLES `pelicula` WRITE;
/*!40000 ALTER TABLE `pelicula` DISABLE KEYS */;
INSERT INTO `pelicula` VALUES (1,'Regreso al futuro','Ciencia ficción',116,7),(2,'El padrino','Drama',180,13),(3,'Avengers','Acción',180,7),(4,'Interstellar','Ciencia Ficción',169,7),(5,'El resplandor','Terror',146,18),(6,'8 Millas','Musical',110,18),(7,'Dejame salir','Terror',160,18),(8,'Terminator 2','Acción',150,16),(9,'Torrente','Comedia',97,18),(10,'The Irishman','Drama',209,16),(11,'Winx Club 3D: La aventura mágica','Fantasía',87,7),(12,'Maquia, una historia de amor inmortal','Drama',115,16),(13,'Nuevos Mutantes','Superheroes',90,12),(14,'The Irishman','Drama',209,16),(19,'Avatar','Ciencia ficción',162,7),(20,'Blade Runner','Ciencia Ficción',117,16),(21,'Lego Las Aventuras de Clutch Powers','Aventuras',82,3),(22,'Black hawk down','Acción',116,18);
/*!40000 ALTER TABLE `pelicula` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sala`
--

DROP TABLE IF EXISTS `sala`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sala` (
  `id` int NOT NULL AUTO_INCREMENT,
  `cine` int NOT NULL,
  `numero` int DEFAULT NULL,
  `aforo` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `cine` (`cine`),
  CONSTRAINT `sala_ibfk_1` FOREIGN KEY (`cine`) REFERENCES `cine` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sala`
--

LOCK TABLES `sala` WRITE;
/*!40000 ALTER TABLE `sala` DISABLE KEYS */;
INSERT INTO `sala` VALUES (1,1,1,100),(2,1,2,70),(3,1,3,70),(4,1,4,50),(5,1,5,50),(6,2,1,120),(7,2,2,100),(8,2,3,70),(9,2,4,70),(10,2,5,50),(11,2,6,50),(12,3,1,100),(13,3,2,55),(14,3,3,45),(15,4,1,70),(16,4,2,70),(17,4,3,50),(18,4,4,50),(19,5,1,150),(20,5,2,75),(21,5,3,50),(22,6,1,75),(23,6,2,70),(24,6,3,50),(25,6,4,45);
/*!40000 ALTER TABLE `sala` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sesion`
--

DROP TABLE IF EXISTS `sesion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sesion` (
  `id` int NOT NULL AUTO_INCREMENT,
  `sala` int NOT NULL,
  `pelicula` int NOT NULL,
  `fecha` date DEFAULT NULL,
  `hora` time DEFAULT NULL,
  `precio_base` decimal(4,2) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `sala` (`sala`),
  KEY `pelicula` (`pelicula`),
  CONSTRAINT `sesion_ibfk_1` FOREIGN KEY (`sala`) REFERENCES `sala` (`id`),
  CONSTRAINT `sesion_ibfk_2` FOREIGN KEY (`pelicula`) REFERENCES `pelicula` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sesion`
--

LOCK TABLES `sesion` WRITE;
/*!40000 ALTER TABLE `sesion` DISABLE KEYS */;
INSERT INTO `sesion` VALUES (1,3,7,'2021-02-08','21:30:00',6.00),(2,1,1,'2021-02-07','18:00:00',7.50),(3,1,2,'2021-02-10','17:00:00',4.50),(4,12,11,'2021-08-07','18:00:00',7.50),(5,18,2,'2021-02-09','21:30:00',6.00),(6,25,12,'2021-02-09','19:30:00',6.00),(7,18,3,'2021-03-18','18:00:00',7.50),(8,20,4,'2021-03-18','22:30:00',7.50),(9,8,4,'2021-02-08','21:30:00',6.00),(10,5,6,'2021-02-09','19:30:00',6.00),(11,8,5,'2020-08-15','19:30:00',6.00),(12,4,5,'2020-08-13','21:30:00',6.00),(13,3,5,'2020-08-17','18:00:00',7.50),(14,1,6,'2021-02-09','21:30:00',6.00),(15,1,6,'2021-02-10','16:30:00',4.50),(16,2,1,'2020-01-12','17:30:00',6.00),(17,19,8,'2021-01-12','18:00:00',7.50),(18,14,8,'2021-01-17','21:30:00',4.50),(19,22,10,'2021-02-12','22:30:00',7.50),(20,9,14,'2021-02-08','19:30:00',6.00),(21,24,13,'2021-02-08','19:30:00',6.00),(22,7,5,'2021-10-10','20:30:00',7.50),(23,9,8,'2021-10-10','22:30:00',7.50),(24,5,4,'2021-02-09','19:30:00',6.00),(25,3,1,'2021-02-09','21:30:00',6.00),(26,1,4,'2021-05-27','19:30:00',6.00),(27,5,6,'2021-07-30','16:30:00',4.50),(28,5,11,'2021-02-15','19:30:00',6.00),(29,13,2,'2021-02-17','16:30:00',4.50),(30,1,3,'2021-02-09','19:30:00',6.00),(31,2,4,'2021-02-10','16:30:00',4.50),(32,4,11,'2021-06-16','19:30:00',4.50),(33,16,6,'2021-03-08','19:30:00',6.00),(34,1,8,'2021-02-10','16:30:00',4.50),(35,2,3,'2021-02-12','18:00:00',7.50),(36,20,1,'2021-02-08','19:30:00',6.00),(37,21,4,'2021-02-07','18:00:00',7.50),(38,1,1,'2021-03-15','19:30:00',6.00),(39,2,1,'2021-03-15','21:30:00',6.00),(40,24,1,'2021-01-24','19:30:00',7.50),(41,10,3,'2021-02-09','19:30:00',6.00),(44,1,13,'2021-03-23','19:30:00',6.00),(45,2,8,'2021-03-24','21:30:00',4.50),(46,2,14,'2021-12-20','20:00:00',10.00),(47,1,14,'2021-12-20','18:00:00',4.50),(48,10,3,'2021-05-05','18:25:00',8.00),(49,25,8,'2021-06-14','19:15:00',7.00),(50,7,21,'2021-02-23','19:30:00',6.00),(51,21,7,'2021-02-10','21:30:00',4.50),(52,1,1,'2020-05-11','21:30:00',6.00),(53,1,2,'2021-05-13','21:30:00',6.00),(54,5,4,'2021-02-14','16:30:00',5.00),(55,14,3,'2021-01-12','19:30:00',6.00),(56,5,4,'2021-02-14','16:30:00',5.00),(57,10,1,'2021-02-19','19:30:00',6.00),(58,10,1,'2021-02-19','19:30:00',6.00),(59,14,3,'2021-01-12','19:30:00',6.00),(60,5,4,'2021-02-14','16:30:00',5.00);
/*!40000 ALTER TABLE `sesion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `socio`
--

DROP TABLE IF EXISTS `socio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `socio` (
  `dni` char(9) NOT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `apellidos` varchar(100) DEFAULT NULL,
  `descuento_actual` decimal(2,2) DEFAULT NULL,
  PRIMARY KEY (`dni`),
  CONSTRAINT `socio_chk_1` CHECK (((`descuento_actual` >= 0) and (`descuento_actual` <= 0.2)))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `socio`
--

LOCK TABLES `socio` WRITE;
/*!40000 ALTER TABLE `socio` DISABLE KEYS */;
INSERT INTO `socio` VALUES ('12340000A','Carla','Smith',0.20),('12345678A','Willyam','Gumshoe Adams',0.15),('12345678G','Jose','Martínez',0.05),('12345678Z','Antonio','Vázquez',0.15),('12546789F','Pepito','García',0.10),('19274917D','Pepe','Lopez Hernández',0.10),('21500123P','Laura','Sánchez Perez',0.20),('39485729G','Rodrigo','Caramanzano Verdí',0.10),('43240000B','Andrés','Fuster Alonso',0.20),('45123467L','Felipe','Luis',0.05),('48756900R','Marco','García',0.10),('56789209F','Figo','García Gutierrez',0.15),('80805553C','Paco','Ramune Kioto',0.20),('87665432C','Matias','González Ramírez',0.10),('91283712Z','Pepe','Ruíz',0.05),('98765432K','Mike','Peterson Jackson',0.20);
/*!40000 ALTER TABLE `socio` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-03-15 11:58:22
