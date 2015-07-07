-- MySQL dump 10.13  Distrib 5.6.23, for Win32 (x86)
--
-- Host: 127.0.0.1    Database: db_mmarket_v1
-- ------------------------------------------------------
-- Server version	5.6.17

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
-- Table structure for table `rh_m_canton`
--

DROP TABLE IF EXISTS `rh_m_canton`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rh_m_canton` (
  `id_canton` int(11) NOT NULL,
  `nombre` varchar(25) NOT NULL,
  `RH_M_CIUDAD_idRH_M_CIUDAD` int(11) NOT NULL,
  `RH_M_CIUDAD_RH_M_PROVINCIA_idRH_M_PROVINCIA` int(11) NOT NULL,
  PRIMARY KEY (`id_canton`,`RH_M_CIUDAD_idRH_M_CIUDAD`,`RH_M_CIUDAD_RH_M_PROVINCIA_idRH_M_PROVINCIA`),
  KEY `fk_RH_M_CANTON_RH_M_CIUDAD1_idx` (`RH_M_CIUDAD_idRH_M_CIUDAD`,`RH_M_CIUDAD_RH_M_PROVINCIA_idRH_M_PROVINCIA`),
  CONSTRAINT `fk_RH_M_CANTON_RH_M_CIUDAD1` FOREIGN KEY (`RH_M_CIUDAD_idRH_M_CIUDAD`, `RH_M_CIUDAD_RH_M_PROVINCIA_idRH_M_PROVINCIA`) REFERENCES `rh_m_ciudad` (`id_ciudad`, `RH_M_PROVINCIA_idRH_M_PROVINCIA`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rh_m_canton`
--

LOCK TABLES `rh_m_canton` WRITE;
/*!40000 ALTER TABLE `rh_m_canton` DISABLE KEYS */;
/*!40000 ALTER TABLE `rh_m_canton` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rh_m_cargo`
--

DROP TABLE IF EXISTS `rh_m_cargo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rh_m_cargo` (
  `id_cargo` int(11) NOT NULL,
  `descripcion` varchar(25) NOT NULL,
  PRIMARY KEY (`id_cargo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rh_m_cargo`
--

LOCK TABLES `rh_m_cargo` WRITE;
/*!40000 ALTER TABLE `rh_m_cargo` DISABLE KEYS */;
/*!40000 ALTER TABLE `rh_m_cargo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rh_m_ciudad`
--

DROP TABLE IF EXISTS `rh_m_ciudad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rh_m_ciudad` (
  `id_ciudad` int(11) NOT NULL,
  `nombre` varchar(25) NOT NULL,
  `RH_M_PROVINCIA_idRH_M_PROVINCIA` int(11) NOT NULL,
  PRIMARY KEY (`id_ciudad`,`RH_M_PROVINCIA_idRH_M_PROVINCIA`),
  KEY `fk_RH_M_CIUDAD_RH_M_PROVINCIA1_idx` (`RH_M_PROVINCIA_idRH_M_PROVINCIA`),
  CONSTRAINT `fk_RH_M_CIUDAD_RH_M_PROVINCIA1` FOREIGN KEY (`RH_M_PROVINCIA_idRH_M_PROVINCIA`) REFERENCES `rh_m_provincia` (`id_provincia`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rh_m_ciudad`
--

LOCK TABLES `rh_m_ciudad` WRITE;
/*!40000 ALTER TABLE `rh_m_ciudad` DISABLE KEYS */;
/*!40000 ALTER TABLE `rh_m_ciudad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rh_m_departamento`
--

DROP TABLE IF EXISTS `rh_m_departamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rh_m_departamento` (
  `id_departamento` int(11) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  PRIMARY KEY (`id_departamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rh_m_departamento`
--

LOCK TABLES `rh_m_departamento` WRITE;
/*!40000 ALTER TABLE `rh_m_departamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `rh_m_departamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rh_m_direccion`
--

DROP TABLE IF EXISTS `rh_m_direccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rh_m_direccion` (
  `id_direccion` int(11) NOT NULL,
  `calle_principal` varchar(45) DEFAULT NULL,
  `calle_secundaria` varchar(45) DEFAULT NULL,
  `referencia` varchar(45) DEFAULT NULL,
  `RH_M_TIPO_DIRECCION_idRH_M_TIPO_DIRECCION` int(11) NOT NULL,
  `RH_M_PROVINCIA_idRH_M_PROVINCIA` int(11) NOT NULL,
  `RH_M_EMPLEADO_id_empleado` int(11) NOT NULL,
  PRIMARY KEY (`id_direccion`,`RH_M_TIPO_DIRECCION_idRH_M_TIPO_DIRECCION`,`RH_M_PROVINCIA_idRH_M_PROVINCIA`),
  KEY `fk_RH_M_DIRECCION_RH_M_TIPO_DIRECCION1_idx` (`RH_M_TIPO_DIRECCION_idRH_M_TIPO_DIRECCION`),
  KEY `fk_RH_M_DIRECCION_RH_M_PROVINCIA1_idx` (`RH_M_PROVINCIA_idRH_M_PROVINCIA`),
  KEY `fk_RH_M_DIRECCION_RH_M_EMPLEADO1_idx` (`RH_M_EMPLEADO_id_empleado`),
  CONSTRAINT `fk_RH_M_DIRECCION_RH_M_TIPO_DIRECCION1` FOREIGN KEY (`RH_M_TIPO_DIRECCION_idRH_M_TIPO_DIRECCION`) REFERENCES `rh_m_tipo_direccion` (`id_tipo_direccion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_RH_M_DIRECCION_RH_M_PROVINCIA1` FOREIGN KEY (`RH_M_PROVINCIA_idRH_M_PROVINCIA`) REFERENCES `rh_m_provincia` (`id_provincia`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_RH_M_DIRECCION_RH_M_EMPLEADO1` FOREIGN KEY (`RH_M_EMPLEADO_id_empleado`) REFERENCES `rh_m_empleado` (`id_empleado`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rh_m_direccion`
--

LOCK TABLES `rh_m_direccion` WRITE;
/*!40000 ALTER TABLE `rh_m_direccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `rh_m_direccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rh_m_empleado`
--

DROP TABLE IF EXISTS `rh_m_empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rh_m_empleado` (
  `id_empleado` int(11) NOT NULL,
  `primer_nombre` varchar(25) NOT NULL,
  `segundo_nombre` varchar(25) NOT NULL,
  `apellido_paterno` varchar(25) NOT NULL,
  `apellido_materno` varchar(25) NOT NULL,
  `fecha_nacimiento` date NOT NULL,
  `genero` varchar(1) NOT NULL,
  `cargas_familiares` varchar(45) NOT NULL,
  `sueldo` varchar(45) NOT NULL,
  `fecha_registrado` varchar(45) NOT NULL,
  `RH_M_DEPARTAMENTO_idRH_M_DEPARTAMENTO` int(11) NOT NULL,
  `RH_M_CARGO_idRH_M_CARGO` int(11) NOT NULL,
  PRIMARY KEY (`id_empleado`),
  KEY `fk_RH_M_EMPLEADO_RH_M_DEPARTAMENTO1_idx` (`RH_M_DEPARTAMENTO_idRH_M_DEPARTAMENTO`),
  KEY `fk_RH_M_EMPLEADO_RH_M_CARGO1_idx` (`RH_M_CARGO_idRH_M_CARGO`),
  CONSTRAINT `fk_RH_M_EMPLEADO_RH_M_DEPARTAMENTO1` FOREIGN KEY (`RH_M_DEPARTAMENTO_idRH_M_DEPARTAMENTO`) REFERENCES `rh_m_departamento` (`id_departamento`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_RH_M_EMPLEADO_RH_M_CARGO1` FOREIGN KEY (`RH_M_CARGO_idRH_M_CARGO`) REFERENCES `rh_m_cargo` (`id_cargo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rh_m_empleado`
--

LOCK TABLES `rh_m_empleado` WRITE;
/*!40000 ALTER TABLE `rh_m_empleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `rh_m_empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rh_m_parroquia`
--

DROP TABLE IF EXISTS `rh_m_parroquia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rh_m_parroquia` (
  `id_parroquia` int(11) NOT NULL,
  `nombre` varchar(25) NOT NULL,
  `RH_M_CANTON_idRH_M_CANTON` int(11) NOT NULL,
  `RH_M_CANTON_RH_M_CIUDAD_idRH_M_CIUDAD` int(11) NOT NULL,
  `RH_M_CANTON_RH_M_CIUDAD_RH_M_PROVINCIA_idRH_M_PROVINCIA` int(11) NOT NULL,
  PRIMARY KEY (`id_parroquia`,`RH_M_CANTON_idRH_M_CANTON`,`RH_M_CANTON_RH_M_CIUDAD_idRH_M_CIUDAD`,`RH_M_CANTON_RH_M_CIUDAD_RH_M_PROVINCIA_idRH_M_PROVINCIA`),
  KEY `fk_RH_M_PARROQUIA_RH_M_CANTON1_idx` (`RH_M_CANTON_idRH_M_CANTON`,`RH_M_CANTON_RH_M_CIUDAD_idRH_M_CIUDAD`,`RH_M_CANTON_RH_M_CIUDAD_RH_M_PROVINCIA_idRH_M_PROVINCIA`),
  CONSTRAINT `fk_RH_M_PARROQUIA_RH_M_CANTON1` FOREIGN KEY (`RH_M_CANTON_idRH_M_CANTON`, `RH_M_CANTON_RH_M_CIUDAD_idRH_M_CIUDAD`, `RH_M_CANTON_RH_M_CIUDAD_RH_M_PROVINCIA_idRH_M_PROVINCIA`) REFERENCES `rh_m_canton` (`id_canton`, `RH_M_CIUDAD_idRH_M_CIUDAD`, `RH_M_CIUDAD_RH_M_PROVINCIA_idRH_M_PROVINCIA`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rh_m_parroquia`
--

LOCK TABLES `rh_m_parroquia` WRITE;
/*!40000 ALTER TABLE `rh_m_parroquia` DISABLE KEYS */;
/*!40000 ALTER TABLE `rh_m_parroquia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rh_m_provincia`
--

DROP TABLE IF EXISTS `rh_m_provincia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rh_m_provincia` (
  `id_provincia` int(11) NOT NULL,
  `nombre` varchar(25) NOT NULL,
  `codigo_tel` varchar(45) NOT NULL,
  PRIMARY KEY (`id_provincia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rh_m_provincia`
--

LOCK TABLES `rh_m_provincia` WRITE;
/*!40000 ALTER TABLE `rh_m_provincia` DISABLE KEYS */;
/*!40000 ALTER TABLE `rh_m_provincia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rh_m_tipo_direccion`
--

DROP TABLE IF EXISTS `rh_m_tipo_direccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rh_m_tipo_direccion` (
  `id_tipo_direccion` int(11) NOT NULL,
  `descripcion_tipo_direccion` varchar(45) NOT NULL,
  PRIMARY KEY (`id_tipo_direccion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rh_m_tipo_direccion`
--

LOCK TABLES `rh_m_tipo_direccion` WRITE;
/*!40000 ALTER TABLE `rh_m_tipo_direccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `rh_m_tipo_direccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sg_m_aplicacion`
--

DROP TABLE IF EXISTS `sg_m_aplicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sg_m_aplicacion` (
  `id_apliccaion` int(11) NOT NULL,
  `nombre` varchar(25) NOT NULL,
  `fecha` date DEFAULT NULL,
  PRIMARY KEY (`id_apliccaion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sg_m_aplicacion`
--

LOCK TABLES `sg_m_aplicacion` WRITE;
/*!40000 ALTER TABLE `sg_m_aplicacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `sg_m_aplicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sg_m_aplicacion_por_rol`
--

DROP TABLE IF EXISTS `sg_m_aplicacion_por_rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sg_m_aplicacion_por_rol` (
  `id_aplicacion` int(11) NOT NULL,
  `id_rol` int(11) NOT NULL,
  PRIMARY KEY (`id_aplicacion`,`id_rol`),
  KEY `fk_SG_M_APLICACION_POR_ROL_SG_M_APLICACION1_idx` (`id_aplicacion`),
  KEY `fk_SG_M_APLICACION_POR_ROL_SG_M_ROL1_idx` (`id_rol`),
  CONSTRAINT `fk_SG_M_APLICACION_POR_ROL_SG_M_APLICACION1` FOREIGN KEY (`id_aplicacion`) REFERENCES `sg_m_aplicacion` (`id_apliccaion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_SG_M_APLICACION_POR_ROL_SG_M_ROL1` FOREIGN KEY (`id_rol`) REFERENCES `sg_m_rol` (`id_rol`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sg_m_aplicacion_por_rol`
--

LOCK TABLES `sg_m_aplicacion_por_rol` WRITE;
/*!40000 ALTER TABLE `sg_m_aplicacion_por_rol` DISABLE KEYS */;
/*!40000 ALTER TABLE `sg_m_aplicacion_por_rol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sg_m_estado`
--

DROP TABLE IF EXISTS `sg_m_estado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sg_m_estado` (
  `idSG_M_ESTADO` int(11) NOT NULL,
  `descripcion` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`idSG_M_ESTADO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sg_m_estado`
--

LOCK TABLES `sg_m_estado` WRITE;
/*!40000 ALTER TABLE `sg_m_estado` DISABLE KEYS */;
/*!40000 ALTER TABLE `sg_m_estado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sg_m_rol`
--

DROP TABLE IF EXISTS `sg_m_rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sg_m_rol` (
  `id_rol` int(11) NOT NULL,
  `descripcion` varchar(25) NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY (`id_rol`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sg_m_rol`
--

LOCK TABLES `sg_m_rol` WRITE;
/*!40000 ALTER TABLE `sg_m_rol` DISABLE KEYS */;
/*!40000 ALTER TABLE `sg_m_rol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sg_m_rol_por_usuario`
--

DROP TABLE IF EXISTS `sg_m_rol_por_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sg_m_rol_por_usuario` (
  `id_rol` int(11) NOT NULL,
  `id_empleado` int(11) NOT NULL,
  PRIMARY KEY (`id_rol`,`id_empleado`),
  KEY `fk_SG_M_ROL_POR_USUARIO_SG_M_ROL1_idx` (`id_rol`),
  KEY `fk_SG_M_ROL_POR_USUARIO_SG_M_USUARIO1_idx` (`id_empleado`),
  CONSTRAINT `fk_SG_M_ROL_POR_USUARIO_SG_M_ROL1` FOREIGN KEY (`id_rol`) REFERENCES `sg_m_rol` (`id_rol`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_SG_M_ROL_POR_USUARIO_SG_M_USUARIO1` FOREIGN KEY (`id_empleado`) REFERENCES `sg_m_usuario` (`id_empleado`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sg_m_rol_por_usuario`
--

LOCK TABLES `sg_m_rol_por_usuario` WRITE;
/*!40000 ALTER TABLE `sg_m_rol_por_usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `sg_m_rol_por_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sg_m_transaccion`
--

DROP TABLE IF EXISTS `sg_m_transaccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sg_m_transaccion` (
  `id_transaccion` int(11) NOT NULL,
  `nombre` varchar(25) NOT NULL,
  `fecha` date DEFAULT NULL,
  PRIMARY KEY (`id_transaccion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sg_m_transaccion`
--

LOCK TABLES `sg_m_transaccion` WRITE;
/*!40000 ALTER TABLE `sg_m_transaccion` DISABLE KEYS */;
/*!40000 ALTER TABLE `sg_m_transaccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sg_m_usuario`
--

DROP TABLE IF EXISTS `sg_m_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sg_m_usuario` (
  `id_empleado` int(11) NOT NULL,
  `usuario` varchar(25) NOT NULL,
  `contraseña` varchar(25) NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY (`id_empleado`),
  KEY `fk_SG_M_USUARIO_RH_M_EMPLEADO1_idx` (`id_empleado`),
  CONSTRAINT `fk_SG_M_USUARIO_RH_M_EMPLEADO1` FOREIGN KEY (`id_empleado`) REFERENCES `rh_m_empleado` (`id_empleado`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sg_m_usuario`
--

LOCK TABLES `sg_m_usuario` WRITE;
/*!40000 ALTER TABLE `sg_m_usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `sg_m_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario_prueba`
--

DROP TABLE IF EXISTS `usuario_prueba`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario_prueba` (
  `idusuario_prueba` int(11) NOT NULL,
  `usuario` varchar(45) NOT NULL,
  `contraseña` varchar(45) NOT NULL,
  PRIMARY KEY (`idusuario_prueba`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario_prueba`
--

LOCK TABLES `usuario_prueba` WRITE;
/*!40000 ALTER TABLE `usuario_prueba` DISABLE KEYS */;
INSERT INTO `usuario_prueba` VALUES (1,'aede','aede');
/*!40000 ALTER TABLE `usuario_prueba` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-06-30 16:26:46
