-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jun 11, 2023 at 03:14 PM
-- Server version: 8.0.33
-- PHP Version: 7.4.3-4ubuntu2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `catalog`
--

-- --------------------------------------------------------

--
-- Table structure for table `anistudii`
--

CREATE TABLE `anistudii` (
  `ID_An` int NOT NULL,
  `NumeAn` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `ID_Program` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `anistudii`
--

INSERT INTO `anistudii` (`ID_An`, `NumeAn`, `ID_Program`) VALUES
(12, 'Informatica', 3),
(15, 'Automatica', 1);

-- --------------------------------------------------------

--
-- Table structure for table `cadredidactice`
--

CREATE TABLE `cadredidactice` (
  `ID_CadruDidactic` int NOT NULL,
  `NumeCadruDidactic` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `PrenumeCadruDidactic` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `MarcaAngajat` varchar(20) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `Titlu` varchar(10) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `Post` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cadredidactice`
--

INSERT INTO `cadredidactice` (`ID_CadruDidactic`, `NumeCadruDidactic`, `PrenumeCadruDidactic`, `MarcaAngajat`, `Titlu`, `Post`) VALUES
(77, 'Iulius', 'Cezar', '1', 'prof ascn', 'Prof'),
(666, 'Iuliana', 'Profesorescu', '1', 'prof ing ', 'prof ascn poo');

-- --------------------------------------------------------

--
-- Table structure for table `cataloage`
--

CREATE TABLE `cataloage` (
  `ID_Catalog` int NOT NULL,
  `ID_Student` int DEFAULT NULL,
  `ID_Disciplina` int DEFAULT NULL,
  `Nota` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cataloage`
--

INSERT INTO `cataloage` (`ID_Catalog`, `ID_Student`, `ID_Disciplina`, `Nota`) VALUES
(2, 10045, 60, 4),
(2, 10045, 55, 3),
(2, 10045, 50, 6),
(2, 10046, 50, 8),
(2, 10046, 60, 10),
(2, 10046, 55, 5);

-- --------------------------------------------------------

--
-- Table structure for table `CicluriInvatamant`
--

CREATE TABLE `CicluriInvatamant` (
  `ID_Ciclu` int NOT NULL,
  `NumeCiclu` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `CicluriInvatamant`
--

INSERT INTO `CicluriInvatamant` (`ID_Ciclu`, `NumeCiclu`) VALUES
(4411, 'Zi');

-- --------------------------------------------------------

--
-- Table structure for table `cicluriinvatamant`
--

CREATE TABLE `cicluriinvatamant` (
  `ID_Ciclu` int NOT NULL,
  `NumeCiclu` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cicluriinvatamant`
--

INSERT INTO `cicluriinvatamant` (`ID_Ciclu`, `NumeCiclu`) VALUES
(1, 'Licență'),
(15, 'Masterat'),
(44, 'Doctorat'),
(77, 'unde ne duce viitorul?'),
(77777777, 'Cine stie ');

-- --------------------------------------------------------

--
-- Table structure for table `grupe`
--

CREATE TABLE `grupe` (
  `ID_Grupa` int NOT NULL,
  `NumeGrupa` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `ID_An` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `planuriinvatamant`
--

CREATE TABLE `planuriinvatamant` (
  `ID_Disciplina` int NOT NULL,
  `NumeDisciplina` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `AcronimDisciplina` varchar(10) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `NumarCredite` int DEFAULT NULL,
  `ID_An` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `planuriinvatamant`
--

INSERT INTO `planuriinvatamant` (`ID_Disciplina`, `NumeDisciplina`, `AcronimDisciplina`, `NumarCredite`, `ID_An`) VALUES
(50, 'Analiza si Sinteza Circuitelor Numerice', 'ASCN', 10, 15),
(55, 'Teoria Sistemelor', 'TS', 5, 15),
(60, 'Programare Orientata pe Obiect', 'POO', 6, 15),
(65, 'Sisteme Automate cu Esantionare', 'SAE', 5, 15);

-- --------------------------------------------------------

--
-- Table structure for table `programestudii`
--

CREATE TABLE `programestudii` (
  `ID_Program` int NOT NULL,
  `NumeProgram` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `ID_Ciclu` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `programestudii`
--

INSERT INTO `programestudii` (`ID_Program`, `NumeProgram`, `ID_Ciclu`) VALUES
(1, 'NumeProgram1', 1),
(3, 'NumeProgram2', 1);

-- --------------------------------------------------------

--
-- Table structure for table `studenti`
--

CREATE TABLE `studenti` (
  `ID_Student` int NOT NULL,
  `NumarMatricol` varchar(20) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `NumeStudent` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `PrenumeStudent` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `InitialaTata` varchar(1) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `CNP` varchar(13) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `DataInscriere` date DEFAULT NULL,
  `ID_Ciclu` int DEFAULT NULL,
  `MediaInscriere` float DEFAULT NULL,
  `id_grupa` varchar(6) COLLATE utf8mb4_general_ci NOT NULL DEFAULT 'N/A',
  `ID_ProgramStudii` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `studenti`
--

INSERT INTO `studenti` (`ID_Student`, `NumarMatricol`, `NumeStudent`, `PrenumeStudent`, `InitialaTata`, `CNP`, `DataInscriere`, `ID_Ciclu`, `MediaInscriere`, `id_grupa`, `ID_ProgramStudii`) VALUES
(10044, '545', 'Costache', 'Andreea', 'X', '2031010492635', '2023-03-14', 44, 8.89, '1', 1),
(10045, '546', 'Anton', 'Virgil', 'G', '5001225789056', '2020-02-12', 44, 5.15, '2', 2),
(10046, '547', 'Popescu', 'Andrei', 'M', '5990416653487', '2022-07-16', 77, 9, '3', 3),
(10047, '548', 'Petrescu', 'Gica', 'M', '5040734465987', '2023-04-18', 44, 6.45, '1', 1);

-- --------------------------------------------------------

--
-- Table structure for table `utilizatori`
--

CREATE TABLE `utilizatori` (
  `ID_Utilizator` int NOT NULL,
  `NumeUtilizator` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `ParolaUtilizator` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `ProfilUtilizator` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `Permisiuni` varchar(25) COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `utilizatori`
--

INSERT INTO `utilizatori` (`ID_Utilizator`, `NumeUtilizator`, `ParolaUtilizator`, `ProfilUtilizator`, `Permisiuni`) VALUES
(0, 'test', 'test', 'testprofile', 'admin'),
(2, 't', 't', 'testprofile', 'admin'),
(20, '2', '2', 'secretar', 'secretar'),
(21, '1', '1', 'testprofile', 'admin'),
(30, '3', '3', 'cadru didactic', 'cadru');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `anistudii`
--
ALTER TABLE `anistudii`
  ADD PRIMARY KEY (`ID_An`),
  ADD KEY `ID_Program` (`ID_Program`);

--
-- Indexes for table `cadredidactice`
--
ALTER TABLE `cadredidactice`
  ADD PRIMARY KEY (`ID_CadruDidactic`);

--
-- Indexes for table `cataloage`
--
ALTER TABLE `cataloage`
  ADD KEY `ID_Student` (`ID_Student`),
  ADD KEY `ID_Disciplina` (`ID_Disciplina`);

--
-- Indexes for table `CicluriInvatamant`
--
ALTER TABLE `CicluriInvatamant`
  ADD PRIMARY KEY (`ID_Ciclu`);

--
-- Indexes for table `cicluriinvatamant`
--
ALTER TABLE `cicluriinvatamant`
  ADD PRIMARY KEY (`ID_Ciclu`);

--
-- Indexes for table `grupe`
--
ALTER TABLE `grupe`
  ADD PRIMARY KEY (`ID_Grupa`),
  ADD KEY `ID_An` (`ID_An`);

--
-- Indexes for table `planuriinvatamant`
--
ALTER TABLE `planuriinvatamant`
  ADD PRIMARY KEY (`ID_Disciplina`),
  ADD KEY `ID_An` (`ID_An`);

--
-- Indexes for table `programestudii`
--
ALTER TABLE `programestudii`
  ADD PRIMARY KEY (`ID_Program`),
  ADD KEY `ID_Ciclu` (`ID_Ciclu`);

--
-- Indexes for table `studenti`
--
ALTER TABLE `studenti`
  ADD PRIMARY KEY (`ID_Student`),
  ADD KEY `ID_Ciclu` (`ID_Ciclu`);

--
-- Indexes for table `utilizatori`
--
ALTER TABLE `utilizatori`
  ADD PRIMARY KEY (`ID_Utilizator`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `anistudii`
--
ALTER TABLE `anistudii`
  ADD CONSTRAINT `anistudii_ibfk_1` FOREIGN KEY (`ID_Program`) REFERENCES `programestudii` (`ID_Program`);

--
-- Constraints for table `cataloage`
--
ALTER TABLE `cataloage`
  ADD CONSTRAINT `cataloage_ibfk_1` FOREIGN KEY (`ID_Student`) REFERENCES `studenti` (`ID_Student`),
  ADD CONSTRAINT `cataloage_ibfk_2` FOREIGN KEY (`ID_Disciplina`) REFERENCES `planuriinvatamant` (`ID_Disciplina`);

--
-- Constraints for table `grupe`
--
ALTER TABLE `grupe`
  ADD CONSTRAINT `grupe_ibfk_1` FOREIGN KEY (`ID_An`) REFERENCES `anistudii` (`ID_An`);

--
-- Constraints for table `planuriinvatamant`
--
ALTER TABLE `planuriinvatamant`
  ADD CONSTRAINT `planuriinvatamant_ibfk_1` FOREIGN KEY (`ID_An`) REFERENCES `anistudii` (`ID_An`);

--
-- Constraints for table `programestudii`
--
ALTER TABLE `programestudii`
  ADD CONSTRAINT `programestudii_ibfk_1` FOREIGN KEY (`ID_Ciclu`) REFERENCES `cicluriinvatamant` (`ID_Ciclu`);

--
-- Constraints for table `studenti`
--
ALTER TABLE `studenti`
  ADD CONSTRAINT `studenti_ibfk_1` FOREIGN KEY (`ID_Ciclu`) REFERENCES `cicluriinvatamant` (`ID_Ciclu`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
