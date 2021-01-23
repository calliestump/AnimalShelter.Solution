CREATE DATABASE  IF NOT EXISTS `callie_stump_animalShelter` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `callie_stump_animalShelter`;
-- MySQL dump 10.13  Distrib 8.0.15, for macos10.14 (x86_64)
--
-- Host: localhost    Database: callie_stump_animalShelter
-- ------------------------------------------------------
-- Server version	8.0.15

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__EFMigrationsHistory`
--

DROP TABLE IF EXISTS `__EFMigrationsHistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__EFMigrationsHistory`
--

LOCK TABLES `__EFMigrationsHistory` WRITE;
/*!40000 ALTER TABLE `__EFMigrationsHistory` DISABLE KEYS */;
INSERT INTO `__EFMigrationsHistory` VALUES ('20210122231919_Initial','2.2.4-servicing-10062'),('20210122234326_DogField','2.2.4-servicing-10062'),('20210122235034_removeImage','2.2.4-servicing-10062'),('20210123002027_Other','2.2.4-servicing-10062'),('20210123002313_OtherFinal','2.2.4-servicing-10062'),('20210123003252_ModelUpdate','2.2.4-servicing-10062'),('20210123003709_Final','2.2.4-servicing-10062');
/*!40000 ALTER TABLE `__EFMigrationsHistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Cats`
--

DROP TABLE IF EXISTS `Cats`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `Cats` (
  `CatId` int(11) NOT NULL AUTO_INCREMENT,
  `catName` varchar(20) NOT NULL,
  `catGender` varchar(6) NOT NULL,
  `catAge` varchar(25) NOT NULL,
  `catBreed` varchar(50) NOT NULL,
  `catDescription` varchar(500) NOT NULL,
  `catFixed` varchar(3) NOT NULL DEFAULT '',
  PRIMARY KEY (`CatId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Cats`
--

LOCK TABLES `Cats` WRITE;
/*!40000 ALTER TABLE `Cats` DISABLE KEYS */;
INSERT INTO `Cats` VALUES (1,'Sage','Female','1 year, 5 months','Maine Coon','Sage is a friendly cat that really enjoys being around people. She is very loving and will give you all the cuddles you desire.','Yes'),(2,'Appa','Male','8 months','Somali','Appa is a fun energetic kitten that loves to play. Absolute sweetheart.','No'),(3,'Bailey','Female','9 years, 3 months','Domestic Shorthair','Bailey is a sweet and gentle cat who would make an amazing companion.','Yes');
/*!40000 ALTER TABLE `Cats` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Dogs`
--

DROP TABLE IF EXISTS `Dogs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `Dogs` (
  `DogId` int(11) NOT NULL AUTO_INCREMENT,
  `dogName` varchar(20) NOT NULL,
  `dogGender` varchar(6) NOT NULL,
  `dogAge` varchar(25) NOT NULL,
  `dogBreed` varchar(50) NOT NULL,
  `dogDescription` varchar(500) NOT NULL,
  `dogFixed` varchar(3) NOT NULL DEFAULT '',
  PRIMARY KEY (`DogId`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Dogs`
--

LOCK TABLES `Dogs` WRITE;
/*!40000 ALTER TABLE `Dogs` DISABLE KEYS */;
INSERT INTO `Dogs` VALUES (1,'Joel','Male','2 years, 1 month','Great Dane','Joel is a sweetheart that absolutely loves to play. He is great with kids and is a perfect fit to make a family complete.','No'),(2,'Roswell','Male','4 years, 3 months','Pitbull, Terrier','Roswell is a fun energetic dog that loves to run around. He is a perfect dog to venture with and take on outdoor trips.','Yes'),(3,'Stone','Female','10 years, 3 months','Retriever, Labrador','Stone is an absolute sweetheart. She is very gentle with people and would make a perfect companion.','Yes'),(5,'Star','Female','10 years, 3 months','German Shepard','Star is super loving shepard. She is very gentle with people and would make a perfect companion','Yes');
/*!40000 ALTER TABLE `Dogs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Others`
--

DROP TABLE IF EXISTS `Others`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `Others` (
  `OtherId` int(11) NOT NULL AUTO_INCREMENT,
  `otherName` varchar(20) NOT NULL,
  `otherFixed` varchar(7) NOT NULL,
  `otherGender` varchar(6) NOT NULL,
  `otherAge` varchar(25) NOT NULL,
  `otherBreed` varchar(50) DEFAULT NULL,
  `otherDescription` varchar(500) NOT NULL,
  `otherSpecies` varchar(20) NOT NULL DEFAULT '',
  PRIMARY KEY (`OtherId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Others`
--

LOCK TABLES `Others` WRITE;
/*!40000 ALTER TABLE `Others` DISABLE KEYS */;
INSERT INTO `Others` VALUES (1,'Oreo','Unknown','Male','1 year',NULL,'Oreo is light in color and is very good with human contact. He really enjoys people.','Rabbit'),(2,'Smaug','Yes','Female','3 years, 3 months',NULL,'Smaug has beautiful colors and loves to run around. He is a gorgeous bearded dragon and would make a great addition to a family.','Bearded Dragon'),(3,'Bernie','Yes','Female','2 years, 1 month','Short Hair','Bernie is darker in color and has beautiful silky fur. He loves to be around people and would make a perfect addition for a family.','Rabbit');
/*!40000 ALTER TABLE `Others` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-01-22 19:47:25
