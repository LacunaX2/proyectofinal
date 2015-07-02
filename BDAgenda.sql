/*
SQLyog Enterprise - MySQL GUI v7.14 
MySQL - 5.6.20 : Database - bdagenda
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

CREATE DATABASE /*!32312 IF NOT EXISTS*/`bdagenda` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `bdagenda`;

/*Table structure for table `tbagenda` */

DROP TABLE IF EXISTS `tbagenda`;

CREATE TABLE `tbagenda` (
  `cod_agenda` int(11) NOT NULL AUTO_INCREMENT,
  `cod_usuario` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  PRIMARY KEY (`cod_agenda`),
  KEY `fk_agenda_usuario` (`cod_usuario`),
  CONSTRAINT `fk_agenda_usuario` FOREIGN KEY (`cod_usuario`) REFERENCES `tbusuario` (`cod_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbagenda` */

/*Table structure for table `tbarchivo` */

DROP TABLE IF EXISTS `tbarchivo`;

CREATE TABLE `tbarchivo` (
  `cod_archivo` int(11) NOT NULL AUTO_INCREMENT,
  `cod_notas` int(11) DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `descripcion` varchar(50) DEFAULT NULL,
  `formato` varchar(50) DEFAULT NULL,
  `tamaño` varchar(50) DEFAULT NULL,
  `direccion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`cod_archivo`),
  KEY `FK_tbarchivo` (`cod_notas`),
  CONSTRAINT `FK_tbarchivo` FOREIGN KEY (`cod_notas`) REFERENCES `tbnotas` (`cod_notas`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbarchivo` */

/*Table structure for table `tbnotas` */

DROP TABLE IF EXISTS `tbnotas`;

CREATE TABLE `tbnotas` (
  `cod_notas` int(11) NOT NULL AUTO_INCREMENT,
  `cod_agenda` int(11) DEFAULT NULL,
  `titulo` varchar(50) DEFAULT NULL,
  `descripcion` varchar(50) DEFAULT NULL,
  `fecha_creacion` date DEFAULT NULL,
  PRIMARY KEY (`cod_notas`),
  KEY `fk_notas_agenda` (`cod_agenda`),
  CONSTRAINT `fk_notas_agenda` FOREIGN KEY (`cod_agenda`) REFERENCES `tbagenda` (`cod_agenda`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbnotas` */

/*Table structure for table `tbpersona` */

DROP TABLE IF EXISTS `tbpersona`;

CREATE TABLE `tbpersona` (
  `cod_persona` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `ap_paterno` varchar(50) DEFAULT NULL,
  `ap_materno` varchar(50) DEFAULT NULL,
  `estado` int(11) DEFAULT NULL,
  `fecha_creacion` date DEFAULT NULL,
  PRIMARY KEY (`cod_persona`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbpersona` */

/*Table structure for table `tbusuario` */

DROP TABLE IF EXISTS `tbusuario`;

CREATE TABLE `tbusuario` (
  `cod_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `cod_persona` int(11) DEFAULT NULL,
  `login` varchar(50) DEFAULT NULL,
  `pass` varchar(50) DEFAULT NULL,
  `fecha_creacion` date DEFAULT NULL,
  PRIMARY KEY (`cod_usuario`),
  KEY `fk_usuario_persona` (`cod_persona`),
  CONSTRAINT `fk_usuario_persona` FOREIGN KEY (`cod_persona`) REFERENCES `tbpersona` (`cod_persona`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbusuario` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
