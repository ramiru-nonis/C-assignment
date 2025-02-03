-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 03, 2025 at 10:10 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `library_management_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin_table`
--

CREATE TABLE `admin_table` (
  `Id` int(100) NOT NULL,
  `name` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `password` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `email` varchar(35) NOT NULL,
  `phoneNumber` int(10) NOT NULL,
  `role` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `books_table`
--

CREATE TABLE `books_table` (
  `ID` int(100) NOT NULL,
  `Title` varchar(50) NOT NULL,
  `Author` varchar(20) NOT NULL,
  `Year` int(5) NOT NULL,
  `ISBN` varchar(50) NOT NULL,
  `URL` varchar(300) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `borrowed_records`
--

CREATE TABLE `borrowed_records` (
  `BorrowedId` int(100) NOT NULL,
  `BookId` int(100) NOT NULL,
  `UserId` int(100) NOT NULL,
  `BorrowDate` date NOT NULL,
  `DueDate` date NOT NULL,
  `IsReturned` tinyint(1) NOT NULL,
  `ReturnedDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `librarian_table`
--

CREATE TABLE `librarian_table` (
  `Id` int(100) NOT NULL,
  `name` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `password` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `email` varchar(35) NOT NULL,
  `phoneNumber` int(10) NOT NULL,
  `role` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `overdue_table`
--

CREATE TABLE `overdue_table` (
  `OverdueId` int(100) NOT NULL,
  `BorrowedId` int(100) NOT NULL,
  `UserID` int(100) NOT NULL,
  `BookID` int(100) NOT NULL,
  `OverdueDays` int(100) NOT NULL,
  `FineAmount` decimal(10,0) NOT NULL,
  `PaidStatus` tinyint(1) NOT NULL,
  `PaidDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `reservation_table`
--

CREATE TABLE `reservation_table` (
  `ReservationId` int(100) NOT NULL,
  `BookId` int(100) NOT NULL,
  `UserId` int(100) NOT NULL,
  `ReservationDate` date NOT NULL,
  `ReservedUntill` date NOT NULL,
  `Status` varchar(100) NOT NULL,
  `IsCollected` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `student_table`
--

CREATE TABLE `student_table` (
  `Id` int(100) NOT NULL,
  `name` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `password` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `email` varchar(35) NOT NULL,
  `phoneNumber` int(10) NOT NULL,
  `role` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin_table`
--
ALTER TABLE `admin_table`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `books_table`
--
ALTER TABLE `books_table`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `borrowed_records`
--
ALTER TABLE `borrowed_records`
  ADD PRIMARY KEY (`BorrowedId`);

--
-- Indexes for table `librarian_table`
--
ALTER TABLE `librarian_table`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `overdue_table`
--
ALTER TABLE `overdue_table`
  ADD PRIMARY KEY (`OverdueId`);

--
-- Indexes for table `reservation_table`
--
ALTER TABLE `reservation_table`
  ADD PRIMARY KEY (`ReservationId`);

--
-- Indexes for table `student_table`
--
ALTER TABLE `student_table`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin_table`
--
ALTER TABLE `admin_table`
  MODIFY `Id` int(100) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `books_table`
--
ALTER TABLE `books_table`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `borrowed_records`
--
ALTER TABLE `borrowed_records`
  MODIFY `BorrowedId` int(100) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `librarian_table`
--
ALTER TABLE `librarian_table`
  MODIFY `Id` int(100) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `overdue_table`
--
ALTER TABLE `overdue_table`
  MODIFY `OverdueId` int(100) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `reservation_table`
--
ALTER TABLE `reservation_table`
  MODIFY `ReservationId` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `student_table`
--
ALTER TABLE `student_table`
  MODIFY `Id` int(100) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
