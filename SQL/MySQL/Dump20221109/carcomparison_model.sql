-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: localhost    Database: carcomparison
-- ------------------------------------------------------
-- Server version	8.0.26

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
-- Table structure for table `model`
--

DROP TABLE IF EXISTS `model`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `model` (
  `MName` varchar(50) NOT NULL,
  PRIMARY KEY (`MName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `model`
--

LOCK TABLES `model` WRITE;
/*!40000 ALTER TABLE `model` DISABLE KEYS */;
INSERT INTO `model` VALUES ('1 Series'),('108'),('2'),('2 Series'),('2008'),('208 GTi'),('3'),('3 Series'),('3008'),('301'),('308'),('4 Series'),('408'),('5 Series'),('500'),('500e'),('500L'),('500X'),('508'),('6'),('6 Series'),('7 Series'),('8 Series'),('A-Class'),('A1'),('A3'),('A4'),('A4 allroad'),('A5'),('A6'),('A7'),('A8'),('B-Class'),('C-Class'),('C1'),('C40'),('Ceed'),('Clio'),('Cooper SE'),('Corsa'),('CX-3'),('Doblo'),('e-208'),('E-Class'),('e-tron'),('EcoSport'),('Fiesta'),('Focus'),('Freemont'),('G-Class'),('i3'),('iX'),('Ka'),('Kona'),('Kuga'),('Leon'),('Logan'),('Megane'),('Model 3'),('Model S'),('Mondeo'),('Mustang'),('Panda'),('Polo'),('Polo Vivo Dune'),('Punto'),('Q2'),('Q3'),('Q3 Sportback'),('Q5'),('Q7'),('Q8'),('Qashqai'),('R8'),('RS 3'),('RS 4'),('RS 5'),('RS 6'),('RS 7'),('RS Q3'),('RS Q8'),('S1'),('S3'),('S5'),('S6'),('S7'),('SQ2'),('SQ5'),('Taycan 4'),('Tipo'),('Tourneo Connect'),('TT'),('V60');
/*!40000 ALTER TABLE `model` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-09 15:34:24
