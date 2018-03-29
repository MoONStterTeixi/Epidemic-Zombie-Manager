-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.1.26-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win32
-- HeidiSQL Versión:             9.5.0.5196
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para epidemic-zombiedb
CREATE DATABASE IF NOT EXISTS `epidemic-zombiedb` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `epidemic-zombiedb`;

-- Volcando estructura para tabla epidemic-zombiedb.ez_admin
CREATE TABLE IF NOT EXISTS `ez_admin` (
  `ID` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Contraseña` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla epidemic-zombiedb.ez_users
CREATE TABLE IF NOT EXISTS `ez_users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nickname` varchar(20) NOT NULL,
  `experience` int(11) NOT NULL,
  `money` int(11) NOT NULL,
  `lenguage` int(11) NOT NULL,
  `max_round` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nickname` (`nickname`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla epidemic-zombiedb.ez_user_survivors
CREATE TABLE IF NOT EXISTS `ez_user_survivors` (
  `user_id` int(11) NOT NULL,
  `survivor1` int(11) NOT NULL DEFAULT '0',
  `survivor2` int(11) NOT NULL DEFAULT '0',
  `survivor3` int(11) NOT NULL DEFAULT '0',
  `survivor4` int(11) NOT NULL DEFAULT '0',
  UNIQUE KEY `user_id` (`user_id`),
  CONSTRAINT `ez_user_survivors_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `ez_users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla epidemic-zombiedb.ez_voucher
CREATE TABLE IF NOT EXISTS `ez_voucher` (
  `code` varchar(10) NOT NULL,
  `money` int(11) NOT NULL,
  `experience` int(11) NOT NULL,
  PRIMARY KEY (`code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- La exportación de datos fue deseleccionada.
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
