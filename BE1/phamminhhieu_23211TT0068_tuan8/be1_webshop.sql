-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 09, 2024 at 10:50 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `be1_webshop`
--
CREATE DATABASE IF NOT EXISTS `be1_webshop` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE `be1_webshop`;

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `id` int(2) NOT NULL,
  `name` varchar(80) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`id`, `name`) VALUES
(1, 'Iphone12'),
(2, 'Samsung'),
(3, 'Oppo'),
(4, 'Vivo');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `id` int(2) NOT NULL,
  `name` varchar(80) NOT NULL,
  `price` float NOT NULL,
  `desc` text NOT NULL,
  `image` varchar(50) NOT NULL,
  `category_id` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`id`, `name`, `price`, `desc`, `image`, `category_id`) VALUES
(1, 'Apple iPhone 5S Silver 16GB', 219.95, 'This Certified Refurbished product is tested and \r\nCertified to look and work like new, with limited to No wear. The refurbishing \r\nprocess includes functionality testing, inspection, and repackaging. The \r\nproduct is backed by a minimum 90-day warranty, and may arrive in a generic \r\nbox. The product ships with a charger and cable, but does not include \r\nheadphone, Manual or SIM card. Only select sellers who maintain a high \r\nperformance bar may offer Certified Refurbished products on Amazon.', 'iphone5s.jpg', 1),
(2, 'Apple iPhone 5C White 16GB', 183.95, 'Factory unlocked iPhones are GSM models and are \r\nONLY compatible with GSM carriers like AT&T and T-Mobile as well as other \r\nGSM networks around the world. They WILL NOT WORK with CDMA carriers \r\nlike Sprint, Verizon and the likes. The phone requires a nano SIM card (not \r\nincluded in the package).', 'iphone5c.jpg', 2),
(3, 'Apple iPhone 6 16GB Space Grey', 449.99, 'Unlocked cell phones are compatible with GSM \r\ncarriers like AT&T and T-Mobile as well as with GSM SIM cards (e.g. H20, \r\nStraight Talk, and select prepaid carriers). Unlocked cell phones will not work \r\nwith CDMA Carriers like Sprint, Verizon, Boost or Virgin.', 'iphone6.jpg', 3),
(4, 'Apple iPhone 12 128GB blue', 449.99, 'Unlocked cell phones are compatible with GSM \r\ncarriers like AT&T and T-Mobile as well as with GSM SIM cards (e.g. H20, \r\nStraight Talk, and select prepaid carriers). Unlocked cell phones will not work \r\nwith CDMA Carriers like Sprint, Verizon, Boost or Virgin.', 'iphone6.jpg', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `id` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `id` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
