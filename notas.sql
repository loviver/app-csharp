-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 17-05-2024 a las 06:11:27
-- Versión del servidor: 8.0.37
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `registro_academico`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `notas`
--

CREATE TABLE `notas` (
  `id` int NOT NULL,
  `nota` decimal(19,4) DEFAULT NULL,
  `fk_materia` int DEFAULT NULL,
  `fk_alumno` int DEFAULT NULL,
  `fecha` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `notas`
--

INSERT INTO `notas` (`id`, `nota`, `fk_materia`, `fk_alumno`, `fecha`) VALUES
(1, 5.0000, 1, 1, NULL),
(2, 6.8800, 1, 10, NULL),
(3, 10.0000, 1, 19, NULL),
(4, 5.1300, 1, 28, NULL),
(5, 8.1600, 1, 37, NULL),
(6, 6.2400, 2, 1, NULL),
(7, 5.0500, 2, 10, NULL),
(8, 5.0000, 2, 19, NULL),
(9, 8.3600, 2, 28, NULL),
(10, 5.0000, 2, 37, NULL),
(11, 7.0100, 3, 1, NULL),
(12, 5.0600, 3, 10, NULL),
(13, 7.1800, 3, 19, NULL),
(14, 9.6800, 3, 28, NULL),
(15, 8.6600, 3, 37, NULL),
(16, 5.7100, 4, 1, NULL),
(17, 5.5000, 4, 10, NULL),
(18, 6.0400, 4, 19, NULL),
(19, 5.5300, 4, 28, NULL),
(20, 5.3400, 4, 37, NULL),
(21, 5.5200, 5, 1, NULL),
(22, 8.4300, 5, 10, NULL),
(23, 5.1600, 5, 19, NULL),
(24, 5.8300, 5, 28, NULL),
(25, 6.2800, 5, 37, NULL),
(26, 5.4700, 6, 2, NULL),
(27, 5.0000, 6, 11, NULL),
(28, 5.0900, 6, 20, NULL),
(29, 7.0300, 6, 29, NULL),
(30, 8.1000, 6, 38, NULL),
(31, 5.0000, 7, 2, NULL),
(32, 7.8600, 7, 11, NULL),
(33, 7.5100, 7, 20, NULL),
(34, 5.3700, 7, 29, NULL),
(35, 5.2900, 7, 38, NULL),
(36, 5.7400, 8, 2, NULL),
(37, 5.2000, 8, 11, NULL),
(38, 8.5700, 8, 20, NULL),
(39, 6.9700, 8, 29, NULL),
(40, 6.8300, 8, 38, NULL),
(41, 5.1000, 9, 2, NULL),
(42, 9.0100, 9, 11, NULL),
(43, 5.0100, 9, 20, NULL),
(44, 6.5500, 9, 29, NULL),
(45, 7.0400, 9, 38, NULL),
(46, 6.3700, 10, 2, NULL),
(47, 7.4900, 10, 11, NULL),
(48, 9.5300, 10, 20, NULL),
(49, 7.0700, 10, 29, NULL),
(50, 5.6600, 10, 38, NULL),
(51, 8.9400, 11, 3, NULL),
(52, 5.6000, 11, 12, NULL),
(53, 5.0300, 11, 21, NULL),
(54, 5.5300, 11, 30, NULL),
(55, 5.8200, 11, 39, NULL),
(56, 5.0100, 12, 3, NULL),
(57, 5.0100, 12, 12, NULL),
(58, 5.0200, 12, 21, NULL),
(59, 5.1900, 12, 30, NULL),
(60, 8.0800, 12, 39, NULL),
(61, 5.5500, 13, 3, NULL),
(62, 5.4700, 13, 12, NULL),
(63, 6.4700, 13, 21, NULL),
(64, 8.1300, 13, 30, NULL),
(65, 5.5400, 13, 39, NULL),
(66, 5.3700, 14, 3, NULL),
(67, 5.7000, 14, 12, NULL),
(68, 5.0100, 14, 21, NULL),
(69, 5.0700, 14, 30, NULL),
(70, 6.0700, 14, 39, NULL),
(71, 9.5000, 15, 3, NULL),
(72, 5.6300, 15, 12, NULL),
(73, 9.3000, 15, 21, NULL),
(74, 6.6400, 15, 30, NULL),
(75, 5.0300, 15, 39, NULL),
(76, 7.4200, 16, 4, NULL),
(77, 5.2600, 16, 13, NULL),
(78, 5.0100, 16, 22, NULL),
(79, 6.6900, 16, 31, NULL),
(80, 7.8100, 16, 40, NULL),
(81, 5.0000, 17, 4, NULL),
(82, 7.8500, 17, 13, NULL),
(83, 7.9800, 17, 22, NULL),
(84, 6.7900, 17, 31, NULL),
(85, 7.2900, 17, 40, NULL),
(86, 6.7200, 18, 4, NULL),
(87, 9.0800, 18, 13, NULL),
(88, 7.8500, 18, 22, NULL),
(89, 5.0200, 18, 31, NULL),
(90, 5.0200, 18, 40, NULL),
(91, 5.0900, 19, 4, NULL),
(92, 6.0800, 19, 13, NULL),
(93, 9.3200, 19, 22, NULL),
(94, 5.3200, 19, 31, NULL),
(95, 6.1000, 19, 40, NULL),
(96, 6.7300, 20, 4, NULL),
(97, 6.4200, 20, 13, NULL),
(98, 9.0600, 20, 22, NULL),
(99, 9.1300, 20, 31, NULL),
(100, 8.5300, 20, 40, NULL),
(101, 6.1200, 21, 5, NULL),
(102, 4.0000, 21, 14, NULL),
(103, 10.0000, 21, 23, NULL),
(104, 6.1600, 21, 32, NULL),
(105, 5.0000, 22, 5, NULL),
(106, 9.0000, 22, 14, NULL),
(107, 10.0000, 22, 23, NULL),
(108, 6.0400, 22, 32, NULL),
(109, 8.1000, 23, 5, NULL),
(110, 9.0000, 23, 14, NULL),
(111, 10.0000, 23, 23, NULL),
(112, 7.3700, 23, 32, NULL),
(113, 5.0000, 24, 5, NULL),
(114, 10.0000, 24, 14, NULL),
(115, 10.0000, 24, 23, NULL),
(116, 8.8600, 24, 32, NULL),
(117, 5.1200, 25, 5, NULL),
(118, 4.0000, 25, 14, NULL),
(119, 10.0000, 25, 23, NULL),
(120, 6.7600, 25, 32, NULL),
(121, 5.7000, 26, 6, NULL),
(122, 5.0400, 26, 15, NULL),
(123, 5.5300, 26, 24, NULL),
(124, 5.6500, 26, 33, NULL),
(125, 8.4400, 27, 6, NULL),
(126, 5.0200, 27, 15, NULL),
(127, 8.3600, 27, 24, NULL),
(128, 9.1800, 27, 33, NULL),
(129, 5.0600, 28, 6, NULL),
(130, 8.3400, 28, 15, NULL),
(131, 7.8100, 28, 24, NULL),
(132, 5.4300, 28, 33, NULL),
(133, 5.2500, 29, 6, NULL),
(134, 5.2900, 29, 15, NULL),
(135, 6.4200, 29, 24, NULL),
(136, 9.4300, 29, 33, NULL),
(137, 5.0600, 30, 6, NULL),
(138, 7.4700, 30, 15, NULL),
(139, 5.2000, 30, 24, NULL),
(140, 8.8800, 30, 33, NULL),
(141, 8.2900, 31, 7, NULL),
(142, 5.8600, 31, 16, NULL),
(143, 7.0200, 31, 25, NULL),
(144, 9.3500, 31, 34, NULL),
(145, 7.9000, 32, 7, NULL),
(146, 5.0000, 32, 16, NULL),
(147, 7.7800, 32, 25, NULL),
(148, 7.5100, 32, 34, NULL),
(149, 5.4700, 33, 7, NULL),
(150, 5.8600, 33, 16, NULL),
(151, 5.1100, 33, 25, NULL),
(152, 6.2500, 33, 34, NULL),
(153, 5.0200, 34, 7, NULL),
(154, 8.0200, 34, 16, NULL),
(155, 7.5800, 34, 25, NULL),
(156, 5.3300, 34, 34, NULL),
(157, 5.1000, 35, 7, NULL),
(158, 9.2000, 35, 16, NULL),
(159, 5.1400, 35, 25, NULL),
(160, 5.0500, 35, 34, NULL),
(161, 9.7700, 36, 8, NULL),
(162, 6.7500, 36, 17, NULL),
(163, 5.0000, 36, 26, NULL),
(164, 5.6500, 36, 35, NULL),
(165, 7.6200, 37, 8, NULL),
(166, 6.4400, 37, 17, NULL),
(167, 6.3000, 37, 26, NULL),
(168, 9.4300, 37, 35, NULL),
(169, 5.1600, 38, 8, NULL),
(170, 5.0200, 38, 17, NULL),
(171, 7.9600, 38, 26, NULL),
(172, 7.2400, 38, 35, NULL),
(173, 5.0100, 39, 8, NULL),
(174, 5.1400, 39, 17, NULL),
(175, 7.6800, 39, 26, NULL),
(176, 5.1200, 39, 35, NULL),
(177, 6.7400, 40, 8, NULL),
(178, 6.1500, 40, 17, NULL),
(179, 6.9700, 40, 26, NULL),
(180, 7.4600, 40, 35, NULL),
(181, 6.9400, 41, 9, NULL),
(182, 5.0000, 41, 18, NULL),
(183, 5.1700, 41, 27, NULL),
(184, 8.9200, 41, 36, NULL),
(185, 8.8400, 42, 9, NULL),
(186, 7.6400, 42, 18, NULL),
(187, 5.0000, 42, 27, NULL),
(188, 8.4100, 42, 36, NULL),
(189, 5.0800, 43, 9, NULL),
(190, 5.1400, 43, 18, NULL),
(191, 5.9500, 43, 27, NULL),
(192, 7.3800, 43, 36, NULL),
(193, 5.1000, 44, 9, NULL),
(194, 6.9300, 44, 18, NULL),
(195, 7.4000, 44, 27, NULL),
(196, 6.8200, 44, 36, NULL),
(197, 9.3600, 45, 9, NULL),
(198, 8.7200, 45, 18, NULL),
(199, 6.3000, 45, 27, NULL),
(200, 9.6500, 45, 36, NULL);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `notas`
--
ALTER TABLE `notas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_alumno` (`fk_alumno`),
  ADD KEY `fk_materia` (`fk_materia`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `notas`
--
ALTER TABLE `notas`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=201;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `notas`
--
ALTER TABLE `notas`
  ADD CONSTRAINT `notas_ibfk_1` FOREIGN KEY (`fk_alumno`) REFERENCES `alumnos` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `notas_ibfk_3` FOREIGN KEY (`fk_materia`) REFERENCES `materias` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
