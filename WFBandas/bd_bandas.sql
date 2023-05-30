-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Oct 03, 2017 at 08:28 PM
-- Server version: 5.7.16
-- PHP Version: 5.6.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bd_bandas`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb01_bandas`
--

CREATE TABLE `tb01_bandas` (
  `banda_id` int(11) NOT NULL,
  `banda_nome` varchar(60) NOT NULL,
  `banda_estilo` varchar(60) NOT NULL,
  `banda_ano` year(4) NOT NULL,
  `banda_descricao` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb01_bandas`
--

INSERT INTO `tb01_bandas` (`banda_id`, `banda_nome`, `banda_estilo`, `banda_ano`, `banda_descricao`) VALUES
(1, 'AC/DC', 'aaa', 2014, 'asdasd asd'),
(2, 'Iron Maidem', 'aaa', 2014, 'asdasd asd   asd as das');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb01_bandas`
--
ALTER TABLE `tb01_bandas`
  ADD PRIMARY KEY (`banda_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb01_bandas`
--
ALTER TABLE `tb01_bandas`
  MODIFY `banda_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
