-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 05 Gru 2022, 21:56
-- Wersja serwera: 10.4.25-MariaDB
-- Wersja PHP: 8.0.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `cthulu_api`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `greatoldones`
--

CREATE TABLE `greatoldones` (
  `Id` int(11) NOT NULL,
  `Name` longtext NOT NULL,
  `FirstAppearance` longtext NOT NULL,
  `DangerousScaleOutOfTen` int(11) NOT NULL,
  `WhereItCurrentlyIs` longtext NOT NULL,
  `Stage` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `greatoldones`
--

INSERT INTO `greatoldones` (`Id`, `Name`, `FirstAppearance`, `DangerousScaleOutOfTen`, `WhereItCurrentlyIs`, `Stage`) VALUES
(1, 'Cthulhu', 'The Call of Cthulhu,', 7, 'R\'lyeh', ' In his house at R\'lyeh dead Cthulhu waits dreaming'),
(2, 'Yig', 'The Curse of Yig', 6, 'Somewhere in South America Jungle', 'Alive');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `greatones`
--

CREATE TABLE `greatones` (
  `Id` int(11) NOT NULL,
  `Name` longtext NOT NULL,
  `className` longtext NOT NULL,
  `FirstAppearance` longtext NOT NULL,
  `DangerousScaleOutOfTen` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `greatones`
--

INSERT INTO `greatones` (`Id`, `Name`, `className`, `FirstAppearance`, `DangerousScaleOutOfTen`) VALUES
(1, 'Hagarg Ryonis', 'reptilian monster.', 'Wizards of Hyperborea,', 5),
(2, 'Lilith', 'Unknown', 'The Horror at Red Hook', 5);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `outerones`
--

CREATE TABLE `outerones` (
  `Id` int(11) NOT NULL,
  `Name` longtext NOT NULL,
  `powers` longtext NOT NULL,
  `FirstAppearance` longtext NOT NULL,
  `DangerousScaleOutOfTen` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `outerones`
--

INSERT INTO `outerones` (`Id`, `Name`, `powers`, `FirstAppearance`, `DangerousScaleOutOfTen`) VALUES
(1, 'Yog-Sothoth', 'Yog-Sothoth sees all and knows all - key and gate for time travels', 'The Case of Charles Dexter Ward', 10),
(2, 'Azotharoth', ' He created all of existence as part of his dream and is not even aware of it.', 'The Dream-Quest of Unknown Kadath', 10);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `stories`
--

CREATE TABLE `stories` (
  `Id` int(11) NOT NULL,
  `Name` longtext NOT NULL,
  `CreationTime` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `stories`
--

INSERT INTO `stories` (`Id`, `Name`, `CreationTime`) VALUES
(1, 'The Alchemist', '1908'),
(2, 'The Tomb', 'Jun 1917'),
(3, 'Dagon', 'Jul 1917'),
(4, 'A Reminiscence of Dr. Samuel Johnson', 'Sum-early Fall 1917'),
(5, 'Polaris', 'Spr-Sum 1918'),
(6, 'Beyond the Wall of Sleep', 'Spr 1919'),
(7, 'Memory', 'Spr 1919');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Zrzut danych tabeli `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20221205202611_final', '6.0.9');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `greatoldones`
--
ALTER TABLE `greatoldones`
  ADD PRIMARY KEY (`Id`);

--
-- Indeksy dla tabeli `greatones`
--
ALTER TABLE `greatones`
  ADD PRIMARY KEY (`Id`);

--
-- Indeksy dla tabeli `outerones`
--
ALTER TABLE `outerones`
  ADD PRIMARY KEY (`Id`);

--
-- Indeksy dla tabeli `stories`
--
ALTER TABLE `stories`
  ADD PRIMARY KEY (`Id`);

--
-- Indeksy dla tabeli `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `greatoldones`
--
ALTER TABLE `greatoldones`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT dla tabeli `greatones`
--
ALTER TABLE `greatones`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT dla tabeli `outerones`
--
ALTER TABLE `outerones`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT dla tabeli `stories`
--
ALTER TABLE `stories`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
