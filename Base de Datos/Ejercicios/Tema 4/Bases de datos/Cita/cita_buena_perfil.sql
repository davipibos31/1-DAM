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
-- Table structure for table `perfil`
--

DROP TABLE IF EXISTS `perfil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `perfil` (
  `nom_usuario` varchar(20) NOT NULL,
  `email` varchar(45) NOT NULL,
  `foto` varchar(45) DEFAULT 'img/default.jpg',
  `fechNac` date DEFAULT NULL,
  `sexo` char(1) DEFAULT NULL,
  `trabajo` varchar(45) DEFAULT NULL,
  `religion` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`nom_usuario`),
  UNIQUE KEY `email` (`email`),
  CONSTRAINT `perfil_ibfk_1` FOREIGN KEY (`nom_usuario`) REFERENCES `usuario` (`nom_usuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perfil`
--

LOCK TABLES `perfil` WRITE;
/*!40000 ALTER TABLE `perfil` DISABLE KEYS */;
INSERT INTO `perfil` VALUES ('apruiz','apruiz@webcitas.com','img/M/apruiz.jpg','1987-05-29','M','Policía','Islam'),('avmiranda','avmiranda@webcitas.com','img/F/avmiranda.jpg','1990-06-14','F','Administrativo','Cristianismo'),('cgramos','cgramos@webcitas.com','img/F/cgramos.jpg','1989-04-05','F',NULL,'Ateo'),('djrodrigo','djrodrigo@webcitas.com','img/M/djrodrigo.jpg','1992-02-06','M','Camarero','Ateo'),('emgonzalez','emgonzalez@webcitas.com','img/M/emgonzalez.jpg','1990-04-20','M','Profesor','Cristianismo'),('esfigueroa','esfigueroa@webcitas.com','img/F/esfigueroa.jpg','1990-11-17','F','Administrativo','Islam'),('jgbermudez','jgbermudez@webcitas.com','img/M/jgbermudez.jpg','1990-08-24','M','Ingeniero','Ateo'),('lpmedina','lpmedina@webcitas.com','img/F/lpmedina.jpg','1986-07-13','F',NULL,'Ateo'),('mrreyes','mrreyes@webcitas.com','img/F/mrreyes.jpg','1987-11-03','F','Medico','Cristianismo'),('rmsalazar','rmsalazar@webcitas.com','img/F/rmsalazar.jpg','1984-09-25','F','Peluquera','Cristianismo'),('rshernandez','rshernandez@webcitas.com','img/F/rshernandez.jpg','1988-06-02','F','Enfermera','Cristianismo'),('rvquiroga','rvquiroga@webcitas.com','img/M/rvquiroga.jpg','1988-12-28','M','Medico','Islam'),('sbortega','sbortega@webcitas.com','img/F/sbortega.jpg','1990-05-15','F','Profesor','Cristianismo'),('sggarcia','sggarcia@webcitas.com','img/M/sggarcia.jpg','1991-06-02','M',NULL,'Ateo'),('stmedina','stmedina@webcitas.com','img/F/stmedina.jpg','1987-01-10','F','Policía','Cristianismo'),('vgmartinez','vgmartinez@webcitas.com','img/F/vgmartinez.jpg','1986-02-24','F','Peluquera','Ateo'),('vprodriguez','vprodriguez@webcitas.com','img/M/vprodriguez.jpg','1993-11-06','M','Fotografo','Ateo');
/*!40000 ALTER TABLE `perfil` ENABLE KEYS */;
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
