-- MySQL dump 10.13  Distrib 8.0.16, for macos10.14 (x86_64)
--
-- Host: localhost    Database: projekt
-- ------------------------------------------------------
-- Server version	8.0.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8mb4 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `found`
--

DROP TABLE IF EXISTS `found`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `found` (
  `id_u` int(11) NOT NULL,
  `id_k` int(11) NOT NULL,
  KEY `id_u` (`id_u`),
  KEY `id_k` (`id_k`),
  CONSTRAINT `found_ibfk_1` FOREIGN KEY (`id_u`) REFERENCES `users` (`id_u`),
  CONSTRAINT `found_ibfk_2` FOREIGN KEY (`id_k`) REFERENCES `kesze` (`id_k`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `found`
--

LOCK TABLES `found` WRITE;
/*!40000 ALTER TABLE `found` DISABLE KEYS */;
INSERT INTO `found` VALUES (1,2),(2,1);
/*!40000 ALTER TABLE `found` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kesze`
--

DROP TABLE IF EXISTS `kesze`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `kesze` (
  `id_k` int(11) NOT NULL AUTO_INCREMENT,
  `description` char(99) DEFAULT NULL,
  `hint` char(99) DEFAULT NULL,
  `id_l` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_k`),
  KEY `id_l` (`id_l`),
  CONSTRAINT `kesze_ibfk_1` FOREIGN KEY (`id_l`) REFERENCES `locations` (`id_l`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kesze`
--

LOCK TABLES `kesze` WRITE;
/*!40000 ALTER TABLE `kesze` DISABLE KEYS */;
INSERT INTO `kesze` VALUES (1,'Kesz nr 1','Podpowiedź 1',1),(2,'Kesz nr 2','Podpowiedź 2',2);
/*!40000 ALTER TABLE `kesze` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `locations`
--

DROP TABLE IF EXISTS `locations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `locations` (
  `id_l` int(11) NOT NULL AUTO_INCREMENT,
  `latitude` double DEFAULT NULL,
  `longtitude` double DEFAULT NULL,
  `difficulty` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_l`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `locations`
--

LOCK TABLES `locations` WRITE;
/*!40000 ALTER TABLE `locations` DISABLE KEYS */;
INSERT INTO `locations` VALUES (1,50.291282,18.680286,3),(2,50.290634,18.67508,4);
/*!40000 ALTER TABLE `locations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reputations`
--

DROP TABLE IF EXISTS `reputations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `reputations` (
  `id_u` int(11) DEFAULT NULL,
  `id_k` int(11) DEFAULT NULL,
  `id_l` int(11) DEFAULT NULL,
  `data` datetime DEFAULT NULL,
  `opinia` char(99) DEFAULT NULL,
  `id_r` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_r`),
  KEY `id_u` (`id_u`),
  KEY `id_k` (`id_k`),
  KEY `id_l` (`id_l`),
  CONSTRAINT `reputations_ibfk_1` FOREIGN KEY (`id_u`) REFERENCES `users` (`id_u`),
  CONSTRAINT `reputations_ibfk_2` FOREIGN KEY (`id_k`) REFERENCES `kesze` (`id_k`),
  CONSTRAINT `reputations_ibfk_3` FOREIGN KEY (`id_l`) REFERENCES `locations` (`id_l`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reputations`
--

LOCK TABLES `reputations` WRITE;
/*!40000 ALTER TABLE `reputations` DISABLE KEYS */;
INSERT INTO `reputations` VALUES (1,2,2,'2019-06-22 15:16:21','Opinia 1',1),(2,1,1,'2019-06-22 15:16:21','Opinia 2',2);
/*!40000 ALTER TABLE `reputations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `users` (
  `id_u` int(11) NOT NULL AUTO_INCREMENT,
  `first_name` char(20) DEFAULT NULL,
  `last_name` char(20) DEFAULT NULL,
  `reg_date` datetime DEFAULT NULL,
  `advancement` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_u`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'Patryk','Musiol','2019-06-22 15:01:21',5),(2,'Michał','Płonka','2019-06-22 15:01:21',1);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-06-22 15:24:45
