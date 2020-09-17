-- MySQL dump 10.13  Distrib 5.6.23, for Win64 (x86_64)
--
-- Host: localhost    Database: dbhastanebts
-- ------------------------------------------------------
-- Server version	5.6.24-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `arizakayit`
--

DROP TABLE IF EXISTS `arizakayit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `arizakayit` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `arizageldigiyer` varchar(45) DEFAULT NULL,
  `domainismi` varchar(45) DEFAULT NULL,
  `model` varchar(45) DEFAULT NULL,
  `arizasi` varchar(45) DEFAULT NULL,
  `serino` varchar(45) DEFAULT NULL,
  `macadresi` varchar(45) DEFAULT NULL,
  `gelistarihi` varchar(45) DEFAULT NULL,
  `getiren` varchar(45) DEFAULT NULL,
  `teslimtarihi` varchar(45) DEFAULT NULL,
  `teslimeden` varchar(45) DEFAULT NULL,
  `degisenparca` varchar(45) DEFAULT NULL,
  `yapilanislem` varchar(45) DEFAULT NULL,
  `yerineverilenyedek` varchar(45) DEFAULT NULL,
  `anakartmodeli` varchar(45) DEFAULT NULL,
  `islemci` varchar(45) DEFAULT NULL,
  `ram` varchar(45) DEFAULT NULL,
  `ekrankarti` varchar(45) DEFAULT NULL,
  `dvd` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `arizakayit`
--

LOCK TABLES `arizakayit` WRITE;
/*!40000 ALTER TABLE `arizakayit` DISABLE KEYS */;
INSERT INTO `arizakayit` VALUES (3,'Poliklinik1','flhkdşskh','lşksdkhkd','şlkshfdkhkfd','şlkdfkşjkhş','3215323','19 Eylül 2016 Pazartesi','sadad','19 Eylül 2016 Pazartesi','gdkjfkh','hkghh','fghfh','gfhggh','hghglj','jkkşkjşj','kşjşkşjk','kşkkşkkşkk','kkkkkk'),(4,'saa','kşjegdsjfkasj','esdkjçhkxjg','mkslşhdfşjdsg','çengsdhnjs6w3q52','mndhfçfshdfdsh','21 Eylül 2016 Çarşamba','hkgfjdhsd','21 Eylül 2016 Çarşamba','gsdgfdsggsd','fhdjdhsgasfh','jjfhdfjgfd','jgfdfgdfsd','ffdhfdfhffdfdd','hfhfdfjgfjgffgfgg','gfggffg','gffgggf','ggfggffg'),(5,'poliklinik kan alma','poliklinik 145','beyaz tt','power sorunu','24152321','232.11.25.44','21 Eylül 2016 Çarşamba','recep','21 Eylül 2016 Çarşamba','recep','power','power değişimi','ram ve power','asus gt-552','intel i5','8gb ddr3 1333mhz','nvidia','var');
/*!40000 ALTER TABLE `arizakayit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cikis`
--

DROP TABLE IF EXISTS `cikis`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cikis` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `malzemeadi` varchar(45) DEFAULT NULL,
  `malzemecinsi` varchar(45) DEFAULT NULL,
  `malzemecikistarihi` varchar(45) DEFAULT NULL,
  `ustbirim` varchar(45) DEFAULT NULL,
  `altbirim` varchar(45) DEFAULT NULL,
  `malzemeadedi` varchar(45) DEFAULT NULL,
  `aciklama` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cikis`
--

LOCK TABLES `cikis` WRITE;
/*!40000 ALTER TABLE `cikis` DISABLE KEYS */;
INSERT INTO `cikis` VALUES (11,'asdawd','Ram','19.09.2016','İdari Birimler','Personel Şube','53','sdgdhsfdjgfdhasda'),(12,'asda','Ram','19.09.2016','İdari Birimler','Personel Şube','5','qwdqwd'),(13,'asda','Ram','22.09.2016','İdari Birimler','Mühendislik','6','asdqwdq'),(14,'ssss','Fan','22.09.2016','İdari Birimler','Personel Şube','5','ascqwd'),(15,'asdawd123','Ram','22.09.2016','İdari Birimler','Mühendislik','13313','2'),(16,'ssss','Fan','22.09.2016','İdari Birimler','Mühendislik','0','agsdasas'),(17,'asdawd','Ram','22.09.2016','Poliklinik','KBB','10','sdgafaf'),(18,'asdawd123','Ram','26.09.2016','İdari Birimler','Personel Şube','1127922','fdhçksdg'),(19,'safsdga','Ekran Kartı','26.09.2016','İdari Birimler','Personel Şube','2','sdfjhsgsf'),(20,'1333mhz 8gb ddr4','Ram','27.09.2016','İdari Birimler','Mühendislik','20','hrfdshfgsdfh'),(21,'fdj','İşlemci','27.09.2016','İdari Birimler','Mühendislik','25','hgfjdh'),(22,'dshdf','İşlemci','27.09.2016','İdari Birimler','Mühendislik','2','dshfsg'),(23,'dfjh','İşlemci','27.09.2016','Poliklinik','Genel Cerrahi Polikliniği','2','gjfdhsgf'),(24,'asff','Ekran Kartı','27.09.2016','İdari Birimler','Personel Şube','3','hghsfdh'),(25,'saaaa','Ekran Kartı','27.09.2016','İdari Birimler','Personel Şube','5','gfdhg'),(26,'8gb ddr3 1333mhz','Ekran Kartı','27.09.2016','Poliklinik','KBB','20','fsdhsd'),(27,'8gb ddr3 1333mhz','Ekran Kartı','27.09.2016','Poliklinik','KBB','5','gdjfsgsdssfd'),(28,'1333mhz 8gb ','Ram','28.09.2016','İdari Birimler','İdari Ve Mali İşler Müdürlüğü','10','fdhsdgadg');
/*!40000 ALTER TABLE `cikis` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `malzeme`
--

DROP TABLE IF EXISTS `malzeme`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `malzeme` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `malzemeadi` varchar(45) DEFAULT NULL,
  `malzemecinsi` varchar(45) DEFAULT NULL,
  `malzemeadedi` varchar(45) DEFAULT NULL,
  `malzemegiristarihi` varchar(45) DEFAULT NULL,
  `malzemeaciklama` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `malzeme`
--

LOCK TABLES `malzeme` WRITE;
/*!40000 ALTER TABLE `malzeme` DISABLE KEYS */;
/*!40000 ALTER TABLE `malzeme` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `uyegirisi`
--

DROP TABLE IF EXISTS `uyegirisi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `uyegirisi` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `kullaniciadi` varchar(45) DEFAULT NULL,
  `sifre` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `uyegirisi`
--

LOCK TABLES `uyegirisi` WRITE;
/*!40000 ALTER TABLE `uyegirisi` DISABLE KEYS */;
INSERT INTO `uyegirisi` VALUES (1,'fadli','123456'),(2,'admin','123456'),(3,'fatih','123456'),(7,'asdka','12d1'),(8,'dkqwdqk','12312');
/*!40000 ALTER TABLE `uyegirisi` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-09-30 13:26:27
