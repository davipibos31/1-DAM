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
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `nom_usuario` varchar(20) NOT NULL,
  `NIF` varchar(9) DEFAULT NULL,
  `pass` varchar(10) DEFAULT NULL,
  `telefono` decimal(9,0) DEFAULT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`nom_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES ('apruiz','65473823J','5knUQaSh',600892163,'Alberto Parra Ruiz'),('avmiranda','65473877K','a7KyiUFF',613252307,'Adriana Vazquez Miranda'),('cgramos','78932434F','myuDRHBx',601829464,'Claudia Garcia Ramos'),('djrodrigo','56703214D','BD6XJbuf',630928379,'David Jimenez Rodrigo'),('emgonzalez','78563401C','ggPtcs7I',675889203,'Eduardo Martin Gonzalez'),('esfigueroa','67895435H','OrRAdwQx',652939003,'Elisa Sanchez Figueroa'),('jgbermudez','90067312F','7ZLte16L',650220132,'Jose Gutierrez Bermudez'),('lpmedina','23145236L','GUkuV5rD',670897834,'Lucia Perez Medina'),('mrreyes','54389210D','M27GYCVU',679304123,'Maria Rodriguez Reyes'),('rmsalazar','54430287J','paVuW9lC',673940331,'Ruth Morales Salazar'),('rshernandez','67863211G','hmkghHl7',665783375,'Rocio Suarez Hernandez'),('rvquiroga','43214352H','L9HKbr08',610328956,'Roberto Vega Quiroga'),('sbortega','56323453G','4YCmJKFZ',680098033,'Sandra Blanco Ortega'),('sggarcia','22314780L','yrE7b679',608700931,'Saul Gomez Garcia'),('stmedina','56743284K','j6MEus4h',665110890,'Sonia Torres Medina'),('vgmartinez','55400892G','T6obZiQa',689932045,'Veronica Gonzalo Martinez'),('vprodriguez','45362734P','eoJTry5f',659434491,'Victor Perez Rodriguez');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
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
