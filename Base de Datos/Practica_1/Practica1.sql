-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 04-12-2023 a las 10:18:54
-- Versión del servidor: 10.4.28-MariaDB
-- Versión de PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `practica1`
--

CREATE DATABASE IF NOT EXISTS `practica1`;
USE `practica1`;
-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `centros`
--

CREATE TABLE `centros` (
  `numero` int(10) NOT NULL,
  `nombre` text NOT NULL,
  `direccion` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `centros`
--

INSERT INTO `centros` (`numero`, `nombre`, `direccion`) VALUES
(10, 'SEDE CENTRAL', 'Avda. Los Menceyes, SANTA CRUZ'),
(20, 'RELACIONES CON CLIENTES', 'C/Neptuno, CANDELARIA');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departamentos`
--

CREATE TABLE `departamentos` (
  `numero` int(5) NOT NULL,
  `centro` int(5) NOT NULL,
  `director` int(50) NOT NULL,
  `tipo_dir` text NOT NULL,
  `presupuesto` int(5) NOT NULL,
  `depto_jefe` int(5) DEFAULT NULL,
  `nombre` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `departamentos`
--

INSERT INTO `departamentos` (`numero`, `centro`, `director`, `tipo_dir`, `presupuesto`, `depto_jefe`, `nombre`) VALUES
(100, 10, 260, 'P', 12, 0, 'DIRECCION GENERAL'),
(110, 20, 180, 'P', 15, 100, 'DIRECCION COMERCIAL'),
(111, 20, 180, 'F', 11, 110, 'SECTOR INDUSTRIAL'),
(112, 20, 270, 'P', 9, 100, 'SECTOR DE SERVICIOS'),
(122, 10, 350, 'P', 6, 120, 'PROCESO DE DATOS'),
(120, 10, 150, 'F', 3, 100, 'ORGANIZACION'),
(121, 10, 150, 'P', 2, 120, 'PERSONAL'),
(130, 10, 310, 'P', 2, 100, 'FINANZAS');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

CREATE TABLE `empleados` (
  `cod` int(5) NOT NULL,
  `departamento` int(5) NOT NULL,
  `telefono` int(5) NOT NULL,
  `fechaNac` date NOT NULL,
  `fecha` date NOT NULL,
  `salario` int(10) NOT NULL,
  `comision` int(5) DEFAULT NULL,
  `numhijos` int(5) NOT NULL,
  `nombre` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `empleados`
--

INSERT INTO `empleados` (`cod`, `departamento`, `telefono`, `fechaNac`, `fecha`, `salario`, `comision`, `numhijos`, `nombre`) VALUES
(110, 121, 350, '1935-11-10', '1990-02-10', 1310, 0, 3, 'LOPEZ, JAVIER'),
(120, 112, 840, '1945-06-09', '1988-10-01', 1350, 110, 1, 'VALLADARES, MARIO'),
(130, 112, 810, '1955-11-09', '1989-02-01', 1290, 110, 2, 'JORGE, LUCIANO'),
(150, 121, 340, '1940-08-10', '1968-01-15', 1440, 0, 0, 'PEREZ, JULIA'),
(160, 111, 740, '1949-07-09', '1988-11-11', 1310, 110, 2, 'AGUERE, AURELIO'),
(180, 110, 508, '1944-10-18', '1996-03-18', 1480, 50, 2, 'MARQUEZ, MARCOS'),
(190, 121, 350, '1942-05-12', '1982-02-11', 1300, 0, 4, 'VERA, JULIO'),
(210, 100, 200, '1950-09-28', '1969-01-22', 1380, 0, 2, 'GÓMEZ, PILAR'),
(240, 111, 760, '1952-02-26', '1986-02-24', 1280, 100, 3, 'SANCHÉZ, LUCIA'),
(250, 100, 250, '1965-10-27', '1987-03-01', 1450, 0, 0, 'HENRIQUEZ, ALBA');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `centros`
--
ALTER TABLE `centros`
  ADD PRIMARY KEY (`numero`);

--
-- Indices de la tabla `departamentos`
--
ALTER TABLE `departamentos`
  ADD PRIMARY KEY (`numero`);

--
-- Indices de la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD PRIMARY KEY (`cod`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;