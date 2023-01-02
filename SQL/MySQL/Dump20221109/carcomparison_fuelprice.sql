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
-- Table structure for table `fuelprice`
--

DROP TABLE IF EXISTS `fuelprice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fuelprice` (
  `FPId` int NOT NULL AUTO_INCREMENT,
  `FuelName` varchar(10) NOT NULL,
  `Date` datetime DEFAULT NULL,
  `Price` float NOT NULL,
  PRIMARY KEY (`FPId`),
  KEY `FuelName` (`FuelName`),
  CONSTRAINT `fuelprice_ibfk_1` FOREIGN KEY (`FuelName`) REFERENCES `fueltype` (`FuelName`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fuelprice`
--

LOCK TABLES `fuelprice` WRITE;
/*!40000 ALTER TABLE `fuelprice` DISABLE KEYS */;
INSERT INTO `fuelprice` VALUES (1,'Benzin','2022-08-31 00:00:00',16.36),(2,'Benzin','2022-07-31 00:00:00',17.19),(3,'Benzin','2022-06-30 00:00:00',18.69),(4,'Benzin','2022-05-31 00:00:00',18.69),(5,'El','2022-08-31 00:00:00',3.37),(6,'El','2022-07-31 00:00:00',1.89),(7,'El','2022-06-30 00:00:00',1.59),(8,'El','2022-05-31 00:00:00',1.24);
/*!40000 ALTER TABLE `fuelprice` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-09 15:34:34
