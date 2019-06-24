-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 25, 2019 at 12:46 AM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.3.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kmk_movie`
--

-- --------------------------------------------------------

--
-- Table structure for table `auditoriums`
--

CREATE TABLE `auditoriums` (
  `id` int(11) NOT NULL,
  `name` varchar(50) COLLATE utf8_general_mysql500_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_mysql500_ci;

--
-- Dumping data for table `auditoriums`
--

INSERT INTO `auditoriums` (`id`, `name`) VALUES
(2, 'Theatre 1'),
(3, 'Theatre 2'),
(4, 'Theatre 3');

-- --------------------------------------------------------

--
-- Table structure for table `movies`
--

CREATE TABLE `movies` (
  `id` int(11) NOT NULL,
  `name` varchar(50) COLLATE utf8_general_mysql500_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_mysql500_ci;

--
-- Dumping data for table `movies`
--

INSERT INTO `movies` (`id`, `name`) VALUES
(3, 'Avengers: Endgame'),
(4, 'Spiderman: Far From Home'),
(5, 'Aladin');

-- --------------------------------------------------------

--
-- Table structure for table `reservation_logs`
--

CREATE TABLE `reservation_logs` (
  `id` int(11) NOT NULL,
  `movie_name` varchar(50) COLLATE utf8_general_mysql500_ci NOT NULL,
  `start_time` varchar(50) COLLATE utf8_general_mysql500_ci NOT NULL,
  `auditorium_name` varchar(50) COLLATE utf8_general_mysql500_ci NOT NULL,
  `seats` varchar(50) COLLATE utf8_general_mysql500_ci NOT NULL,
  `amount` int(11) NOT NULL,
  `cashier_name` varchar(50) COLLATE utf8_general_mysql500_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_mysql500_ci;

--
-- Dumping data for table `reservation_logs`
--

INSERT INTO `reservation_logs` (`id`, `movie_name`, `start_time`, `auditorium_name`, `seats`, `amount`, `cashier_name`) VALUES
(2, 'Aladin', '6/24/2019 3:00:00 PM', 'Theatre 2', ' A1 C3 D2', 12000, 'Kaung Min Khant'),
(3, 'Aladin', '6/24/2019 10:00:00 AM', 'Theatre 1', ' A3', 3000, 'Kaung Min Khant'),
(4, 'Spiderman: Far From Home', '6/24/2019 12:00:00 PM', 'Theatre 3', ' D2 D3 D4', 15000, 'Kaung Min Khant'),
(5, 'Avengers: Endgame', '6/24/2019 12:00:00 PM', 'Theatre 2', ' A2 A3 C2 D4 B4', 18000, 'Kaung Min Khant'),
(6, 'Avengers: Endgame', '6/24/2019 12:00:00 PM', 'Theatre 2', ' A4 D2 D3 D4', 18000, 'Kaung Min Khant'),
(7, 'Avengers: Endgame', '6/24/2019 12:00:00 PM', 'Theatre 2', ' A3 C3 D4', 12000, 'staff'),
(8, 'Spiderman: Far From Home', '6/26/2019 10:00:00 AM', 'Theatre 1', ' B3 C2 D3', 12000, 'Kaung Min Khant');

-- --------------------------------------------------------

--
-- Table structure for table `screenings`
--

CREATE TABLE `screenings` (
  `id` int(11) NOT NULL,
  `movie_name` varchar(50) COLLATE utf8_general_mysql500_ci NOT NULL,
  `auditorium_name` varchar(50) COLLATE utf8_general_mysql500_ci NOT NULL,
  `start_time` varchar(50) COLLATE utf8_general_mysql500_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_mysql500_ci;

--
-- Dumping data for table `screenings`
--

INSERT INTO `screenings` (`id`, `movie_name`, `auditorium_name`, `start_time`) VALUES
(1, 'Aladin', 'Theatre 1', '6/24/2019 10:00:00 AM'),
(3, 'Avengers: Endgame', 'Theatre 2', '6/24/2019 10:00:00 AM'),
(4, 'Spiderman: Far From Home', 'Theatre 3', '6/24/2019 10:00:00 AM'),
(5, 'Aladin', 'Theatre 1', '6/24/2019 12:00:00 PM'),
(6, 'Spiderman: Far From Home', 'Theatre 3', '6/24/2019 12:00:00 PM'),
(7, 'Avengers: Endgame', 'Theatre 2', '6/24/2019 12:00:00 PM'),
(8, 'Aladin', 'Theatre 2', '6/24/2019 3:00:00 PM'),
(9, 'Avengers: Endgame', 'Theatre 1', '6/24/2019 3:00:00 PM'),
(10, 'Spiderman: Far From Home', 'Theatre 3', '6/24/2019 3:00:00 PM'),
(11, 'Spiderman: Far From Home', 'Theatre 2', '6/26/2019 10:00:00 AM'),
(12, 'Spiderman: Far From Home', 'Theatre 1', '6/26/2019 10:00:00 AM');

-- --------------------------------------------------------

--
-- Table structure for table `seats`
--

CREATE TABLE `seats` (
  `id` int(11) NOT NULL,
  `name` varchar(50) COLLATE utf8_general_mysql500_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_mysql500_ci;

--
-- Dumping data for table `seats`
--

INSERT INTO `seats` (`id`, `name`) VALUES
(1, 'A1'),
(2, 'A2'),
(3, 'A3'),
(4, 'A4'),
(5, 'A5'),
(6, 'B1'),
(7, 'B2'),
(8, 'B3'),
(9, 'B4'),
(10, 'B5'),
(11, 'C1'),
(12, 'C2'),
(13, 'C3'),
(14, 'C4'),
(15, 'C5'),
(16, 'D1'),
(17, 'D2'),
(18, 'D3'),
(19, 'D4'),
(20, 'D5'),
(21, 'E1'),
(22, 'E2'),
(23, 'E3'),
(24, 'E4'),
(25, 'E5');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `name` varchar(50) COLLATE utf8_general_mysql500_ci NOT NULL,
  `email` varchar(50) COLLATE utf8_general_mysql500_ci NOT NULL,
  `password` varchar(50) COLLATE utf8_general_mysql500_ci NOT NULL,
  `employee_type` varchar(50) COLLATE utf8_general_mysql500_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_mysql500_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `name`, `email`, `password`, `employee_type`) VALUES
(1, 'Kaung Min Khant ', 'phenomenalkaung@gmail.com', 'kmk2kyttc', 'Staff'),
(2, 'admin', 'admin@admin.org', 'C@wpu$12#', 'Manager'),
(11, 'xzzxt', 'xztzszet', '1234', 'Manager'),
(12, 'sdzdtrsdt', 'zsdt', '1234', 'Staff'),
(13, 'zdts', 'sewatsdy', '1234', 'Manager'),
(14, 'zdts', 'sewatsdy', '1234', 'Staff'),
(15, 'jkl', 'jkl', 'jkl', 'Manager'),
(16, 'asd', 'asd', 'asd', 'Manager'),
(17, 'sdafst', 'asdtfsfdy', '123', 'Staff'),
(18, 'sdt', 'stdat', '123', 'Staff'),
(19, 'sdtsdt', 'stdat', '123', 'Manager'),
(20, 'sdfy', 'dszft', '123', 'Manager'),
(21, 'sattdasdt', 'adttsas', '1234', 'Staff'),
(22, 'alskfj', 'ls;jtp', '1234', 'Manager'),
(23, 'admin2', 'admin@gmail.com', '1234', ''),
(24, 'admin2', 'admin@gmail.com', '1234', ''),
(25, 'admin2', 'admin@gmail.com', '1234', ''),
(26, 'admin2', 'admin@gmail.com', '1234', 'Manager'),
(27, 'admin2', 'admin@gmail.com', '1234', 'Manager'),
(28, 'admin2', 'admin@gmail.com', '1234', 'Manager'),
(29, 'admin2', 'admin@gmail.com', '1234', 'Manager'),
(30, 'admin2', 'admin@gmail.com', '1234', 'Manager'),
(31, 'admin2', 'admin@gmail.com', '1234', 'Manager'),
(32, 'admin2', 'admin@gmail.com', '1234', 'Manager'),
(33, 'admin2', 'admin@gmail.com', '1234', 'Manager'),
(34, 'admin2', 'admin@gmail.com', '1234', 'Manager'),
(35, 'admin', 'admin@gmail.com', '1234', 'Manager'),
(36, 'staff', 'staff@gmail.com', '1234', 'Staff'),
(37, 'kmkjfukku', 'oljghjg', '1234', 'Manager');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `auditoriums`
--
ALTER TABLE `auditoriums`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `movies`
--
ALTER TABLE `movies`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `reservation_logs`
--
ALTER TABLE `reservation_logs`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `screenings`
--
ALTER TABLE `screenings`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `seats`
--
ALTER TABLE `seats`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `auditoriums`
--
ALTER TABLE `auditoriums`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `movies`
--
ALTER TABLE `movies`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `reservation_logs`
--
ALTER TABLE `reservation_logs`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `screenings`
--
ALTER TABLE `screenings`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `seats`
--
ALTER TABLE `seats`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
