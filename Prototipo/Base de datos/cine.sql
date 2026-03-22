CREATE DATABASE  IF NOT EXISTS `cine` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `cine`;
-- MySQL dump 10.13  Distrib 8.0.43, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: cine
-- ------------------------------------------------------
-- Server version	9.4.0

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
-- Table structure for table `asiento`
--

DROP TABLE IF EXISTS `asiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `asiento` (
  `id_asiento` bigint NOT NULL AUTO_INCREMENT,
  `id_sala` bigint NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `estatus` enum('Libre','Reservado','Ocupado','Inhabilitado') DEFAULT 'Libre',
  PRIMARY KEY (`id_asiento`),
  KEY `idx_asiento_sala` (`id_sala`),
  CONSTRAINT `asiento_ibfk_1` FOREIGN KEY (`id_sala`) REFERENCES `sala` (`id_sala`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asiento`
--

LOCK TABLES `asiento` WRITE;
/*!40000 ALTER TABLE `asiento` DISABLE KEYS */;
INSERT INTO `asiento` VALUES (1,1,'A1','Libre'),(2,1,'A2','Libre'),(3,1,'A3','Libre'),(4,1,'A4','Libre'),(5,1,'A5','Libre');
/*!40000 ALTER TABLE `asiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `boleto`
--

DROP TABLE IF EXISTS `boleto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `boleto` (
  `id_boleto` bigint NOT NULL AUTO_INCREMENT,
  `tanda_id` bigint NOT NULL,
  `dueño_id` bigint NOT NULL,
  `fecha_compra` datetime DEFAULT CURRENT_TIMESTAMP,
  `asiento_id` bigint NOT NULL,
  `hash` varchar(255) NOT NULL,
  `metodo_pago` varchar(50) DEFAULT NULL,
  `monto` decimal(10,2) DEFAULT '0.00',
  PRIMARY KEY (`id_boleto`),
  UNIQUE KEY `hash` (`hash`),
  KEY `asiento_id` (`asiento_id`),
  KEY `idx_boleto_dueño` (`dueño_id`),
  KEY `idx_boleto_tanda` (`tanda_id`),
  CONSTRAINT `boleto_ibfk_1` FOREIGN KEY (`tanda_id`) REFERENCES `tandas` (`id_tanda`),
  CONSTRAINT `boleto_ibfk_2` FOREIGN KEY (`dueño_id`) REFERENCES `usuario` (`id`),
  CONSTRAINT `boleto_ibfk_3` FOREIGN KEY (`asiento_id`) REFERENCES `asiento` (`id_asiento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `boleto`
--

LOCK TABLES `boleto` WRITE;
/*!40000 ALTER TABLE `boleto` DISABLE KEYS */;
/*!40000 ALTER TABLE `boleto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `boletos`
--

DROP TABLE IF EXISTS `boletos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `boletos` (
  `id_boletos` bigint NOT NULL AUTO_INCREMENT,
  `nombre_cliente` varchar(45) DEFAULT NULL,
  `apellido_cliente` varchar(45) DEFAULT NULL,
  `correo_cliente` varchar(45) DEFAULT NULL,
  `metodo_pago` enum('Tarjeta de crédito','Tarjeta de débito','VISA','Mastercard') DEFAULT NULL,
  `precio` decimal(10,2) DEFAULT NULL,
  `id_pelicula` bigint DEFAULT NULL,
  `fecha_compra` datetime DEFAULT NULL,
  PRIMARY KEY (`id_boletos`),
  KEY `id_pelicula_idx` (`id_pelicula`),
  CONSTRAINT `id_pelicula` FOREIGN KEY (`id_pelicula`) REFERENCES `pelicula` (`id_pelicula`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `boletos`
--

LOCK TABLES `boletos` WRITE;
/*!40000 ALTER TABLE `boletos` DISABLE KEYS */;
INSERT INTO `boletos` VALUES (2,'Carlos','Rivera','carlosrivera12@gmail.com','VISA',23.00,22,'2025-12-14 17:09:42'),(3,'Aurora','Contreras','auroracontreras12@gmail.com','VISA',23.00,22,'2025-12-14 17:21:56'),(4,'Marcelo','Gonzales','marcelo12@gmail.com','VISA',78.50,22,'2025-12-14 18:11:27'),(5,'Maria','Mendoza','mariamendoza12@gmail.com','Mastercard',39.25,22,'2025-12-14 18:26:40'),(6,'Alberta','Gonzales','alberta14@gmail.com','Tarjeta de crédito',42.75,22,'2025-12-14 18:43:59'),(8,'Light','Gonsalez','lightgonsalez@gmail.com','Tarjeta de débito',17.25,22,'2025-12-19 14:13:22'),(9,'Lalo','Garza','lalogarza96@gmail.com','Tarjeta de crédito',17.25,22,'2025-12-19 14:28:01'),(10,'lalo','garza','lalogarza@gmail.com','Tarjeta de crédito',28.00,22,'2025-12-19 14:29:49'),(11,'juan','lopez','juanlopez@gmail.com','Tarjeta de débito',17.25,22,'2025-12-19 14:39:32'),(12,'lowein','gonzales','loweingonzales@gmail.com','Tarjeta de débito',34.50,22,'2025-12-19 14:51:08'),(13,'gusbenis','vargas','gusbenisvargas12@gmail.com','Tarjeta de crédito',17.25,22,'2025-12-19 14:52:34'),(14,'luanne','garcía','luanne12@gmail.com','VISA',23.00,22,'2025-12-19 14:54:00'),(15,'hector','reyes','hector12@gmail.com','Tarjeta de débito',17.25,22,'2025-12-19 14:57:02'),(16,'Dough','Jones','Doughjones26@outlook.com','VISA',17.25,22,'2025-12-19 16:46:04'),(17,'Gerundio','Lopez','gerundiolopez12@gmail.com','Mastercard',56.75,32,'2025-12-19 17:54:20'),(18,'Luis','Sobenis','luissobenis12@gmail.com','Tarjeta de débito',31.25,35,'2025-12-19 19:17:51'),(19,'Agapito','Martinez','agaa@proton.me','Tarjeta de débito',23.00,30,'2026-03-21 23:03:18');
/*!40000 ALTER TABLE `boletos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cartelera`
--

DROP TABLE IF EXISTS `cartelera`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cartelera` (
  `id_cartelera` bigint NOT NULL AUTO_INCREMENT,
  `estado` enum('Activa','Inactiva','Proxima') DEFAULT 'Proxima',
  `fecha_inicio` date DEFAULT NULL,
  `fecha_fin` date DEFAULT NULL,
  `id_pelicula` bigint NOT NULL,
  PRIMARY KEY (`id_cartelera`),
  KEY `id_pelicula` (`id_pelicula`),
  CONSTRAINT `cartelera_ibfk_1` FOREIGN KEY (`id_pelicula`) REFERENCES `pelicula` (`id_pelicula`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cartelera`
--

LOCK TABLES `cartelera` WRITE;
/*!40000 ALTER TABLE `cartelera` DISABLE KEYS */;
INSERT INTO `cartelera` VALUES (1,'Activa','2025-10-20','2025-11-20',1),(2,'Activa','2025-12-12','2025-12-18',22);
/*!40000 ALTER TABLE `cartelera` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `log_transacciones`
--

DROP TABLE IF EXISTS `log_transacciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `log_transacciones` (
  `id_log` bigint NOT NULL AUTO_INCREMENT,
  `tabla_afectada` varchar(64) DEFAULT NULL,
  `tipo_operacion` varchar(10) DEFAULT NULL,
  `usuario_db` varchar(100) DEFAULT NULL,
  `fecha` datetime DEFAULT CURRENT_TIMESTAMP,
  `detalle` text,
  PRIMARY KEY (`id_log`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log_transacciones`
--

LOCK TABLES `log_transacciones` WRITE;
/*!40000 ALTER TABLE `log_transacciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `log_transacciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pelicula`
--

DROP TABLE IF EXISTS `pelicula`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pelicula` (
  `id_pelicula` bigint NOT NULL AUTO_INCREMENT,
  `nombre` varchar(150) NOT NULL,
  `descripcion` varchar(392) DEFAULT NULL,
  `fecha_estreno` date DEFAULT NULL,
  `salida_cartelera` date DEFAULT NULL,
  `duracion` int DEFAULT NULL,
  `categoria` varchar(100) DEFAULT NULL,
  `clasificacion` varchar(50) DEFAULT NULL,
  `portada` varchar(255) DEFAULT NULL,
  `idioma` varchar(45) DEFAULT NULL,
  `estatus` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_pelicula`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pelicula`
--

LOCK TABLES `pelicula` WRITE;
/*!40000 ALTER TABLE `pelicula` DISABLE KEYS */;
INSERT INTO `pelicula` VALUES (1,'La Gran Función','Descripción corta','2025-10-20',NULL,125,'Acción','B',NULL,NULL,NULL),(22,'Capitán América: El primer vengador','Tras ser rechazado por el ejército, \r\nSteve Rogers se ofrece para una investigación secreta que lo convierte en el Capitán América, un superhéroe dedicado a defender los valores de su país y pelear por la libertad como la mejor arma contra el mal .Cuando el mal amenaza a todo el mundo, el soldado más grande va a la guerra contra HYDRA, la organización dirigida por el villano Red Skull.','2011-07-08','2011-07-26',156,'Superhéroes','B','C:\\Users\\carlj\\source\\repos\\Prototipo\\Prototipo\\Recursos gráficos\\Portadas\\Captain America- The First Avenger (2011).png','Español con subtítulos','No disponible'),(30,'John Wick 2','El legendario asesino John Wick se ve obligado a salir de su retiro por culpa de un exsocio que intenta controlar un siniestro grupo internacional de asesinos. Obligado a ayudarle por un juramento de sangre, John viaja a Roma para enfrentarse a algunos de los asesinos más letales del mundo.','2017-01-30','2017-02-08',122,'Acción','C','C:\\Users\\carlj\\source\\repos\\Prototipo\\Prototipo\\Recursos gráficos\\Portadas\\John Wick- Chapter 2 (2017).png','Español con subtítulos','No disponible'),(31,'Avatar: Fuego y Cenizas','Tercera entrega de la saga \"Avatar\". Presenta al Pueblo de las Cenizas, un clan Na\'vi no tan pacífico que utilizará la violencia si lo necesita para conseguir sus objetivos, aunque sea contra otros clanes.','2025-12-19','2026-01-08',195,'Aventuras','B','C:\\Users\\carlj\\source\\repos\\Prototipo\\Prototipo\\Recursos gráficos\\Portadas\\Avatar- Fire and Ash (2025).png','Español con subtítulos','En cartelera'),(32,'Five Night\'s at Freddy\'s 2','Ha transcurrido un año desde la pesadilla sobrenatural en la pizzería de Freddy Fazbear.  La historia de lo que ocurrió allí ha ido adquiriendo la talla de leyenda local, e incluso ha dado pie al primer “Faszfest”.  El exguarda de seguridad Mike y la agente de policía Vanessa han ocultado la verdad a Abby, la hermana de 11 años de Mike, acerca del destino de sus amigos animatrónicos. ','2025-12-15','2025-12-29',104,'Horror','B','C:\\Users\\carlj\\source\\repos\\Prototipo\\Prototipo\\Recursos gráficos\\Portadas\\Five Nights at Freddy\'s 2 (2025).png','Inglés con subtítulos','En cartelera'),(35,'Zootopia 2','Judy y Nick se encuentran tras la retorcida pista de un misterioso reptil que llega a Zootopia y pone patas arriba la metrópolis de los mamíferos. \r\nPara resolver el caso, Judy y Nick deben ir de incógnito a nuevas partes inesperadas de la ciudad, donde su creciente asociación se pone a prueba como nunca antes. ','2025-11-02','2025-12-29',107,'Comedia','A','C:\\Users\\carlj\\source\\repos\\Prototipo\\Prototipo\\Recursos gráficos\\Portadas\\Zootopia 2 (2025).png','Español','No disponible'),(36,'Sherlock Holmes (2009)','Es sherlock Holmes ¿Qué más esperas?','2010-07-15','2010-08-11',124,'Drama','B','C:\\Users\\carlj\\source\\repos\\Prototipo\\Prototipo\\Recursos gráficos\\Portadas\\Sherlock Holmes (2009).png','Español','No disponible');
/*!40000 ALTER TABLE `pelicula` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rol`
--

DROP TABLE IF EXISTS `rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rol` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rol`
--

LOCK TABLES `rol` WRITE;
/*!40000 ALTER TABLE `rol` DISABLE KEYS */;
INSERT INTO `rol` VALUES (1,'Cliente','Cliente estándar'),(2,'Admin','Administrador del sistema');
/*!40000 ALTER TABLE `rol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sala`
--

DROP TABLE IF EXISTS `sala`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sala` (
  `id_sala` bigint NOT NULL AUTO_INCREMENT,
  `tipo` varchar(100) DEFAULT NULL,
  `nombre` varchar(50) NOT NULL,
  `capacidad` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_sala`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sala`
--

LOCK TABLES `sala` WRITE;
/*!40000 ALTER TABLE `sala` DISABLE KEYS */;
INSERT INTO `sala` VALUES (1,'3D','Sala A',120),(2,'2D','Sala B',80);
/*!40000 ALTER TABLE `sala` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tandas`
--

DROP TABLE IF EXISTS `tandas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tandas` (
  `id_tanda` bigint NOT NULL AUTO_INCREMENT,
  `id_pelicula` bigint NOT NULL,
  `id_sala` bigint NOT NULL,
  `estado` enum('Programada','En Curso','Finalizada','Cancelada') DEFAULT 'Programada',
  `hora_inicio` time NOT NULL,
  `hora_fin` time DEFAULT NULL,
  `fecha` date NOT NULL,
  `precio` decimal(10,2) NOT NULL DEFAULT '0.00',
  `capacidad` int DEFAULT NULL,
  PRIMARY KEY (`id_tanda`),
  KEY `idx_tandas_pelicula` (`id_pelicula`),
  KEY `idx_tandas_sala` (`id_sala`),
  CONSTRAINT `tandas_ibfk_1` FOREIGN KEY (`id_pelicula`) REFERENCES `pelicula` (`id_pelicula`),
  CONSTRAINT `tandas_ibfk_2` FOREIGN KEY (`id_sala`) REFERENCES `sala` (`id_sala`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tandas`
--

LOCK TABLES `tandas` WRITE;
/*!40000 ALTER TABLE `tandas` DISABLE KEYS */;
INSERT INTO `tandas` VALUES (1,1,1,'Programada','18:30:00','20:35:00','2025-11-05',10.00,NULL);
/*!40000 ALTER TABLE `tandas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `apellido` varchar(100) NOT NULL,
  `rol_id` bigint NOT NULL,
  `correo` varchar(255) NOT NULL,
  `contraseña` varchar(255) NOT NULL,
  `creado_en` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `correo` (`correo`),
  KEY `rol_id` (`rol_id`),
  KEY `idx_usuario_correo` (`correo`),
  CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`rol_id`) REFERENCES `rol` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'Ana','Perez',1,'ana@example.com','$2y$...','2025-11-10 15:21:08'),(2,'Luis','Garcia',2,'luis@example.com','$2y$...','2025-11-10 15:21:08'),(3,'Gabriel','Gomez',1,'gabrielgomez12@gmail.com','gabrielpro12','2025-11-10 17:36:39'),(4,'Maximiliano','Gonzales',2,'maximilianogonzales12@gmail.com','maxielmejor','2025-12-19 03:29:59'),(5,'Luis','Sobenis',2,'luissobenis@gmail.com','1234','2025-12-19 19:07:12');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `v_asientos_disponibles`
--

DROP TABLE IF EXISTS `v_asientos_disponibles`;
/*!50001 DROP VIEW IF EXISTS `v_asientos_disponibles`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_asientos_disponibles` AS SELECT 
 1 AS `id_tanda`,
 1 AS `id_asiento`,
 1 AS `asiento_nombre`,
 1 AS `estatus`,
 1 AS `disponible`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `v_asientos_disponibles`
--

/*!50001 DROP VIEW IF EXISTS `v_asientos_disponibles`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_asientos_disponibles` AS select `t`.`id_tanda` AS `id_tanda`,`a`.`id_asiento` AS `id_asiento`,`a`.`nombre` AS `asiento_nombre`,`a`.`estatus` AS `estatus`,(case when exists(select 1 from `boleto` `b` where ((`b`.`tanda_id` = `t`.`id_tanda`) and (`b`.`asiento_id` = `a`.`id_asiento`))) then 0 else 1 end) AS `disponible` from (`tandas` `t` join `asiento` `a` on((`a`.`id_sala` = `t`.`id_sala`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-03-21 23:35:01
