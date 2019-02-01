-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3307
-- Generation Time: Sep 29, 2017 at 03:27 AM
-- Server version: 10.1.26-MariaDB
-- PHP Version: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sistem_informasi_perusahaan`
--

-- --------------------------------------------------------

--
-- Table structure for table `category_project`
--

CREATE TABLE `category_project` (
  `ct_id` int(5) NOT NULL,
  `project_category` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `category_project`
--

INSERT INTO `category_project` (`ct_id`, `project_category`) VALUES
(1, 'LPSE'),
(2, 'non LPSE'),
(3, 'lain'),
(4, 'garment'),
(5, 'a'),
(6, 'bababas');

-- --------------------------------------------------------

--
-- Table structure for table `client_project`
--

CREATE TABLE `client_project` (
  `cl_id` int(5) NOT NULL,
  `client_name` varchar(50) NOT NULL,
  `alamat` varchar(150) NOT NULL,
  `no_telp` varchar(13) NOT NULL,
  `email` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `client_project`
--

INSERT INTO `client_project` (`cl_id`, `client_name`, `alamat`, `no_telp`, `email`) VALUES
(1, 'adi putro', '', '', ''),
(2, 'asdasd', '', '', ''),
(3, 'wqewqeq', '', '', ''),
(4, 'septiyono', 'bandung', '123456', 'adi@mail.com'),
(5, 'PT adi', 'blablaba', '01234667', 'asdasd'),
(6, 'ababab', '', '', ''),
(7, 'qweqweqwasdasdzxc', '', '', ''),
(8, 'qweasdzxc', '', '', ''),
(9, 'asdasqweqweqw', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `detail_product`
--

CREATE TABLE `detail_product` (
  `o_id_no` varchar(15) NOT NULL,
  `no` varchar(5) NOT NULL,
  `o_id` varchar(10) NOT NULL,
  `nama_barang` varchar(20) NOT NULL,
  `jumlah` int(20) NOT NULL,
  `satuan` varchar(15) NOT NULL,
  `harga_satuan` int(20) NOT NULL,
  `jumlah_harga` int(20) NOT NULL,
  `ct_id` varchar(5) NOT NULL,
  `cl_id` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `detail_product`
--

INSERT INTO `detail_product` (`o_id_no`, `no`, `o_id`, `nama_barang`, `jumlah`, `satuan`, `harga_satuan`, `jumlah_harga`, `ct_id`, `cl_id`) VALUES
('ND001-1', '1', 'ND001', 'aaa', 1, 'ad', 10000, 10000, '2', '1'),
('ND001-2', '2', 'ND001', 'celana', 33, 'buah', 135000, 4455000, '2', '1'),
('ND001-3', '3', 'ND001', 'asdas', 10, 'buah', 10000, 100000, '2', '1'),
('ND002-1', '1', 'ND002', 'baju', 133, 'stel', 200000, 26600000, '3', '4'),
('ND002-2', '2', 'ND002', 'topi', 1500, 'buah', 9500, 14250000, '3', '4'),
('ND003-1', '1', 'ND003', 'baju laki-laki', 15, 'stel', 50000, 750000, '4', '5'),
('ND003-2', '2', 'ND003', 'celana laki-laki', 20, 'buah', 175000, 3500000, '4', '5');

-- --------------------------------------------------------

--
-- Table structure for table `order_project`
--

CREATE TABLE `order_project` (
  `o_id` varchar(10) NOT NULL,
  `ct_id` varchar(5) NOT NULL,
  `cl_id` varchar(5) NOT NULL,
  `nama_product` varchar(200) NOT NULL,
  `tanggal_dimulai` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `order_project`
--

INSERT INTO `order_project` (`o_id`, `ct_id`, `cl_id`, `nama_product`, `tanggal_dimulai`) VALUES
('ND001', '2', '1', 'baju', '19-07-2017'),
('ND002', '3', '4', 'linmas', '20-07-2017'),
('ND003', '4', '5', 'seragam sekolah SMP bandung', '23-07-2017'),
('ND004', '6', '9', 'aqa', '26-07-2017');

-- --------------------------------------------------------

--
-- Table structure for table `spgb`
--

CREATE TABLE `spgb` (
  `no_surat` varchar(20) NOT NULL,
  `lampiran` varchar(5) NOT NULL,
  `perihal` varchar(50) NOT NULL,
  `tgl_dibuat` varchar(15) NOT NULL,
  `no_kontrak` varchar(20) NOT NULL,
  `tgl_kontrak` varchar(15) NOT NULL,
  `o_id` varchar(5) NOT NULL,
  `no` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `spgb`
--

INSERT INTO `spgb` (`no_surat`, `lampiran`, `perihal`, `tgl_dibuat`, `no_kontrak`, `tgl_kontrak`, `o_id`, `no`) VALUES
('1/SPGB/VII/2017', '', '', '28-07-2017', '', '28-07-2017', 'ND001', ''),
('1/SPGB/VIII/2017', '', '', '01-08-2017', '', '28-07-2017', 'ND002', ''),
('2/SPGB/VII/2017', '1', 'asd', '28-07-2017', '312132', '28-07-2017', 'ND003', ''),
('2/SPGB/VIII/2017', '', '', '01-08-2017', '', '28-07-2017', 'ND001', ''),
('3/SPGB/VII/2017', '2', 'asdas', '28-07-2017', '123', '28-07-2017', 'ND003', '');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `no_id` int(10) NOT NULL,
  `nama_lengkap` varchar(45) NOT NULL DEFAULT '',
  `nama_panggilan` varchar(45) NOT NULL DEFAULT '',
  `jenis_kelamin` varchar(45) NOT NULL DEFAULT '',
  `tempat_lahir` varchar(45) NOT NULL DEFAULT '',
  `tanggal_lahir` varchar(45) NOT NULL DEFAULT '',
  `alamat` varchar(150) NOT NULL DEFAULT '',
  `agama` varchar(45) NOT NULL DEFAULT '',
  `status_pernikahan` varchar(45) NOT NULL DEFAULT '',
  `no_kontak` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `pendidikan_terakhir` varchar(45) NOT NULL,
  `akademik` varchar(5) NOT NULL,
  `jurusan` varchar(45) NOT NULL,
  `tgl_masuk` varchar(45) NOT NULL,
  `posisi` varchar(45) NOT NULL,
  `username` varchar(45) NOT NULL DEFAULT '',
  `password` varchar(45) NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`no_id`, `nama_lengkap`, `nama_panggilan`, `jenis_kelamin`, `tempat_lahir`, `tanggal_lahir`, `alamat`, `agama`, `status_pernikahan`, `no_kontak`, `email`, `pendidikan_terakhir`, `akademik`, `jurusan`, `tgl_masuk`, `posisi`, `username`, `password`) VALUES
(1, 'SEPTIYONO ADI PUTRO', 'ADI', 'L', 'BANDUNG', '02-09-1996', 'JL. SINDANG SARI 2 NO.22 RT.06 RW.10 KELURAHAN ANTAPANI WETAN KECAMATAN ANTAPANI KOTA BANDUNG KODE POS 40291', 'ISLAM', 'LAJANG', '08122091996', 'seadro@mail.com', 'SMK ICB Cinta Teknika', '', 'Teknik Komputer dan Jaringan', '01-05-2016', 'IT', 'admin', 'admin'),
(2, 'Gian Ginanjar', 'Gian', 'L', 'Bandung', '26-05-2016', 'Jl jatihandap', 'ISLAM', 'LAJANG', '082218112873', 'gianginanjar1996@gmail.com', 'SMA', 'S1', 'Informatika', '24-08-2017', 'IT', 'Altruizt', 'shine'),
(3, 'ada', 'asdasd', 'P', 'bandung', '13-09-2017', 'sadasdasd', 'PROTESTAN', 'DUDA', '0524523225', 'asdasd@gmail.com', 'SMK', '', 'TI', '26-09-2017', 'Admin', 'ada', 'ada');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `category_project`
--
ALTER TABLE `category_project`
  ADD PRIMARY KEY (`ct_id`);

--
-- Indexes for table `client_project`
--
ALTER TABLE `client_project`
  ADD PRIMARY KEY (`cl_id`);

--
-- Indexes for table `detail_product`
--
ALTER TABLE `detail_product`
  ADD PRIMARY KEY (`o_id_no`);

--
-- Indexes for table `order_project`
--
ALTER TABLE `order_project`
  ADD PRIMARY KEY (`o_id`);

--
-- Indexes for table `spgb`
--
ALTER TABLE `spgb`
  ADD PRIMARY KEY (`no_surat`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`no_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `category_project`
--
ALTER TABLE `category_project`
  MODIFY `ct_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `client_project`
--
ALTER TABLE `client_project`
  MODIFY `cl_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `staff`
--
ALTER TABLE `staff`
  MODIFY `no_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
