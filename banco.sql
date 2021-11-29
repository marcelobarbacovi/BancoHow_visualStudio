-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 29-Nov-2021 às 03:48
-- Versão do servidor: 10.4.21-MariaDB
-- versão do PHP: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `banco`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE `clientes` (
  `ID` int(11) NOT NULL,
  `Nome` varchar(50) CHARACTER SET utf8 NOT NULL,
  `Cpf` int(11) NOT NULL,
  `Data` varchar(8) NOT NULL,
  `Uf` varchar(2) CHARACTER SET utf8 NOT NULL,
  `Cep` int(11) NOT NULL,
  `Ativo` int(1) NOT NULL DEFAULT 1,
  `Conta` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `clientes`
--

INSERT INTO `clientes` (`ID`, `Nome`, `Cpf`, `Data`, `Uf`, `Cep`, `Ativo`, `Conta`) VALUES
(28, 'Ana Paula Cristina Daló ', 121244111, '10/03/19', 'SP', 8845411, 1, 19),
(29, 'Marcelo Barbacovi', 636540693, '09/07/19', 'SC', 88117250, 1, 20);

-- --------------------------------------------------------

--
-- Estrutura da tabela `conta`
--

CREATE TABLE `conta` (
  `Titular` varchar(30) CHARACTER SET utf8 NOT NULL,
  `Ativo` int(1) NOT NULL,
  `tipo` varchar(30) CHARACTER SET utf8 NOT NULL,
  `Agencia` int(10) NOT NULL,
  `conta` int(11) NOT NULL,
  `Saldo` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `conta`
--

INSERT INTO `conta` (`Titular`, `Ativo`, `tipo`, `Agencia`, `conta`, `Saldo`) VALUES
('Ana Paula Cristina Daló', 0, '', 0, 0, 0),
('', 0, 'Conta Poupança', 2257, 19, 0),
('', 0, 'Conta Corrente', 2257, 20, 0),
('', 0, 'Conta Poupança', 2257, 21, 0);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `contaFK` (`Conta`);

--
-- Índices para tabela `conta`
--
ALTER TABLE `conta`
  ADD PRIMARY KEY (`conta`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `clientes`
--
ALTER TABLE `clientes`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
