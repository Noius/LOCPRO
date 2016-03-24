-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Jeu 24 Mars 2016 à 17:49
-- Version du serveur :  5.6.17
-- Version de PHP :  5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `bdd_loc`
--

-- --------------------------------------------------------

--
-- Structure de la table `chat`
--

CREATE TABLE IF NOT EXISTS `chat` (
  `NUMTICKET` char(32) NOT NULL,
  `MESSAGETECH` char(32) DEFAULT NULL,
  `MESSAGECLIENT` char(32) DEFAULT NULL,
  `DESCRIPTION` char(32) DEFAULT NULL,
  PRIMARY KEY (`NUMTICKET`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE IF NOT EXISTS `client` (
  `NUMCLIENT` int(11) NOT NULL,
  `NOMCLIENT` char(32) DEFAULT NULL,
  `PRENOMCLIENT` char(32) DEFAULT NULL,
  `IDCLIENT` varchar(60) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `MDPCLIENT` varchar(60) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `MAILCLIENT` char(32) DEFAULT NULL,
  `ADRESSECLIENT` char(32) DEFAULT NULL,
  `CPCLIENT` char(32) DEFAULT NULL,
  PRIMARY KEY (`NUMCLIENT`),
  UNIQUE KEY `IDCLIENT` (`IDCLIENT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `communication`
--

CREATE TABLE IF NOT EXISTS `communication` (
  `NUMTICKET` char(32) NOT NULL,
  `MESSAGETECH` char(32) DEFAULT NULL,
  `MESSAGECLIENT` char(32) DEFAULT NULL,
  `DESCRIPTION` char(32) DEFAULT NULL,
  PRIMARY KEY (`NUMTICKET`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `garantie`
--

CREATE TABLE IF NOT EXISTS `garantie` (
  `NUMGARANTIE` int(11) NOT NULL,
  `NUMPROD` int(11) NOT NULL,
  `CODEGRANTIE` char(32) DEFAULT NULL,
  PRIMARY KEY (`NUMGARANTIE`),
  KEY `I_FK_GARANTIE_PRODUIT` (`NUMPROD`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `marque`
--

CREATE TABLE IF NOT EXISTS `marque` (
  `NUMMARQUE` int(11) NOT NULL,
  `LIBELLEMARQUE` char(32) DEFAULT NULL,
  PRIMARY KEY (`NUMMARQUE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `probleme`
--

CREATE TABLE IF NOT EXISTS `probleme` (
  `NUMPROB` int(11) NOT NULL,
  `LIBELLEPROB` char(32) DEFAULT NULL,
  PRIMARY KEY (`NUMPROB`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `produit`
--

CREATE TABLE IF NOT EXISTS `produit` (
  `NUMPROD` int(11) NOT NULL,
  `NUMTYPE` int(11) NOT NULL,
  `NUMMARQUE` int(11) NOT NULL,
  `LIBELLEPROD` char(32) DEFAULT NULL,
  `OCCURPROD` char(32) DEFAULT NULL,
  PRIMARY KEY (`NUMPROD`),
  KEY `I_FK_PRODUIT_TYPEPRODUIT` (`NUMTYPE`),
  KEY `I_FK_PRODUIT_MARQUE` (`NUMMARQUE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `rechercher`
--

CREATE TABLE IF NOT EXISTS `rechercher` (
  `NUMTYPE` int(11) NOT NULL,
  `NUMCLIENT` int(11) NOT NULL,
  PRIMARY KEY (`NUMTYPE`,`NUMCLIENT`),
  KEY `I_FK_RECHERCHER_TYPEPRODUIT` (`NUMTYPE`),
  KEY `I_FK_RECHERCHER_CLIENT` (`NUMCLIENT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `specialisation`
--

CREATE TABLE IF NOT EXISTS `specialisation` (
  `NUM_SPE` int(11) NOT NULL,
  `NUMTECH` int(11) NOT NULL,
  `LIBELLE_SPE` char(32) DEFAULT NULL,
  PRIMARY KEY (`NUM_SPE`),
  KEY `I_FK_SPECIALISATION_TECHNICIEN` (`NUMTECH`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `technicien`
--

CREATE TABLE IF NOT EXISTS `technicien` (
  `NUMTECH` int(11) NOT NULL,
  `NOMTECH` char(32) DEFAULT NULL,
  `PRENOMTECH` char(32) DEFAULT NULL,
  `IDTECH` varchar(60) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `MDPTECH` varchar(60) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `EVALUATION` char(32) DEFAULT NULL,
  PRIMARY KEY (`NUMTECH`),
  UNIQUE KEY `IDTECH` (`IDTECH`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `technicien`
--

INSERT INTO `technicien` (`NUMTECH`, `NOMTECH`, `PRENOMTECH`, `IDTECH`, `MDPTECH`, `EVALUATION`) VALUES
(1, 'test', 'test', 'test', 'test', 'test');

-- --------------------------------------------------------

--
-- Structure de la table `ticket`
--

CREATE TABLE IF NOT EXISTS `ticket` (
  `NUMTICKET` char(32) NOT NULL,
  `NUMCLIENT` int(11) NOT NULL,
  `NUMPROB` int(11) NOT NULL,
  `NUMPROD` int(11) NOT NULL,
  `NUMTECH` int(11) DEFAULT NULL,
  `DESCRIPTION` char(32) DEFAULT NULL,
  PRIMARY KEY (`NUMTICKET`),
  KEY `I_FK_TICKET_CLIENT` (`NUMCLIENT`),
  KEY `I_FK_TICKET_PROBLEME` (`NUMPROB`),
  KEY `I_FK_TICKET_PRODUIT` (`NUMPROD`),
  KEY `I_FK_TICKET_TECHNICIEN` (`NUMTECH`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `typeproduit`
--

CREATE TABLE IF NOT EXISTS `typeproduit` (
  `NUMTYPE` int(11) NOT NULL,
  `LIBELLETYPE` char(32) DEFAULT NULL,
  `OCCURTYPE` char(32) DEFAULT NULL,
  PRIMARY KEY (`NUMTYPE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `chat`
--
ALTER TABLE `chat`
  ADD CONSTRAINT `chat_ibfk_1` FOREIGN KEY (`NUMTICKET`) REFERENCES `ticket` (`NUMTICKET`);

--
-- Contraintes pour la table `communication`
--
ALTER TABLE `communication`
  ADD CONSTRAINT `communication_ibfk_1` FOREIGN KEY (`NUMTICKET`) REFERENCES `ticket` (`NUMTICKET`);

--
-- Contraintes pour la table `garantie`
--
ALTER TABLE `garantie`
  ADD CONSTRAINT `garantie_ibfk_1` FOREIGN KEY (`NUMPROD`) REFERENCES `produit` (`NUMPROD`);

--
-- Contraintes pour la table `produit`
--
ALTER TABLE `produit`
  ADD CONSTRAINT `produit_ibfk_2` FOREIGN KEY (`NUMMARQUE`) REFERENCES `marque` (`NUMMARQUE`),
  ADD CONSTRAINT `produit_ibfk_1` FOREIGN KEY (`NUMTYPE`) REFERENCES `typeproduit` (`NUMTYPE`);

--
-- Contraintes pour la table `rechercher`
--
ALTER TABLE `rechercher`
  ADD CONSTRAINT `rechercher_ibfk_2` FOREIGN KEY (`NUMCLIENT`) REFERENCES `client` (`NUMCLIENT`),
  ADD CONSTRAINT `rechercher_ibfk_1` FOREIGN KEY (`NUMTYPE`) REFERENCES `typeproduit` (`NUMTYPE`);

--
-- Contraintes pour la table `specialisation`
--
ALTER TABLE `specialisation`
  ADD CONSTRAINT `specialisation_ibfk_1` FOREIGN KEY (`NUMTECH`) REFERENCES `technicien` (`NUMTECH`);

--
-- Contraintes pour la table `ticket`
--
ALTER TABLE `ticket`
  ADD CONSTRAINT `ticket_ibfk_4` FOREIGN KEY (`NUMTECH`) REFERENCES `technicien` (`NUMTECH`),
  ADD CONSTRAINT `ticket_ibfk_1` FOREIGN KEY (`NUMCLIENT`) REFERENCES `client` (`NUMCLIENT`),
  ADD CONSTRAINT `ticket_ibfk_2` FOREIGN KEY (`NUMPROB`) REFERENCES `probleme` (`NUMPROB`),
  ADD CONSTRAINT `ticket_ibfk_3` FOREIGN KEY (`NUMPROD`) REFERENCES `produit` (`NUMPROD`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
