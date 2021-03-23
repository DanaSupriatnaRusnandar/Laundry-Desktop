-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 22 Mar 2021 pada 14.31
-- Versi server: 10.4.17-MariaDB
-- Versi PHP: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `laundry`
--

DELIMITER $$
--
-- Prosedur
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `transaksi` (IN `id` INT(11), IN `id_outlet` INT(11), IN `invoice` VARCHAR(100), IN `id_member` INT(11), IN `tgl` DATETIME, IN `batas_waktu` DATETIME, IN `tgl_bayar` DATETIME, IN `biaya_tambahan` INT(11), IN `diskon` INT(11), IN `pajak` INT(11), IN `status_cucian` VARCHAR(10), IN `status_pembayaran` VARCHAR(20), IN `id_user` INT(11), IN `id_paket` INT(11), IN `qty` DOUBLE, IN `keterangan` TEXT, IN `total_pembayaran` INT(11), IN `id_kurir` INT(11))  BEGIN
 
 DECLARE exit handler for sqlexception
   BEGIN
     -- ERROR
   ROLLBACK;
 END;
   
 DECLARE exit handler for sqlwarning
  BEGIN
     -- WARNING
  ROLLBACK;
 END;
 
 START TRANSACTION;
   INSERT INTO tb_transaksi VALUES(null, id_outlet,invoice,id_member,tgl,batas_waktu,tgl_bayar,biaya_tambahan,diskon,pajak,total_pembayaran,status_cucian,status_pembayaran,id_kurir,id_user);
   INSERT INTO tb_detail_transaksi VALUES(null,id,id_paket,qty,keterangan);
 COMMIT;
 END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `crud_log`
--

CREATE TABLE `crud_log` (
  `id` int(11) NOT NULL,
  `tanggal` datetime NOT NULL,
  `aktivitas` enum('insert','update','delete') NOT NULL,
  `tabel` varchar(20) NOT NULL,
  `id_data` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `login_log`
--

CREATE TABLE `login_log` (
  `id` int(11) NOT NULL,
  `tanggal` datetime NOT NULL,
  `id_user` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `login_log`
--

INSERT INTO `login_log` (`id`, `tanggal`, `id_user`) VALUES
(1, '2021-03-22 19:38:27', 53),
(2, '2021-03-22 19:38:52', 50),
(3, '2021-03-22 20:22:29', 46);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_detail_transaksi`
--

CREATE TABLE `tb_detail_transaksi` (
  `id` int(11) NOT NULL,
  `id_transaksi` int(11) NOT NULL,
  `id_paket` int(11) NOT NULL,
  `qty` double NOT NULL,
  `keterangan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tb_detail_transaksi`
--

INSERT INTO `tb_detail_transaksi` (`id`, `id_transaksi`, `id_paket`, `qty`, `keterangan`) VALUES
(3, 13, 19, 1, 'mmnk'),
(6, 15, 19, 1, 'adad'),
(7, 16, 22, 1, ''),
(10, 19, 18, 1, 'mn'),
(11, 20, 20, 1, 'mn'),
(14, 23, 21, 1, 'cccccccccccc'),
(15, 24, 19, 1, 'cccccccccccc'),
(16, 25, 20, 1, 'Laundry '),
(17, 26, 22, 1, 'Laundry '),
(22, 27, 19, 1, 'mkfkjkjak'),
(23, 28, 18, 5, 'mkfkjkjak'),
(25, 29, 19, 15, 'Suka bon');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_jenis`
--

CREATE TABLE `tb_jenis` (
  `id` int(11) NOT NULL,
  `jenis` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tb_jenis`
--

INSERT INTO `tb_jenis` (`id`, `jenis`) VALUES
(8, 'Kiloan'),
(9, 'Kaos'),
(10, 'Selimut'),
(16, 'Bed Cover'),
(17, 'Sepatu');

--
-- Trigger `tb_jenis`
--
DELIMITER $$
CREATE TRIGGER `crud_delete_jenis` AFTER DELETE ON `tb_jenis` FOR EACH ROW BEGIN
    INSERT INTO crud_log VALUES(null, NOW(), 'delete', 'tb_jenis', OLD.id);
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `crud_insert_jenis` AFTER INSERT ON `tb_jenis` FOR EACH ROW BEGIN
    INSERT INTO crud_log VALUES(null, NOW(), 'insert', 'tb_jenis', NEW.id);
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `crud_update_jenis` AFTER UPDATE ON `tb_jenis` FOR EACH ROW BEGIN
    INSERT INTO crud_log VALUES(null, NOW(), 'update', 'tb_jenis', NEW.id);
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_kurir`
--

CREATE TABLE `tb_kurir` (
  `id` int(11) NOT NULL,
  `nama_kurir` varchar(100) NOT NULL,
  `alamat` text NOT NULL,
  `tlp` varchar(15) NOT NULL,
  `id_outlet` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tb_kurir`
--

INSERT INTO `tb_kurir` (`id`, `nama_kurir`, `alamat`, `tlp`, `id_outlet`) VALUES
(8, 'Dendra Permana', 'Tambakan', '0822984930012', 22),
(10, 'Cahyono', 'Sumurgintung', '088937183992', 20),
(11, 'Jono', 'Sukamelang', '088937284930', 31);

--
-- Trigger `tb_kurir`
--
DELIMITER $$
CREATE TRIGGER `crud_delete_kurir` AFTER DELETE ON `tb_kurir` FOR EACH ROW BEGIN
    INSERT INTO crud_log VALUES(null, NOW(), 'delete', 'tb_kurir', OLD.id);
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `crud_insert_kurir` AFTER INSERT ON `tb_kurir` FOR EACH ROW BEGIN
    INSERT INTO crud_log VALUES(null, NOW(), 'insert', 'tb_kurir', NEW.id);
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `crud_update_kurir` AFTER UPDATE ON `tb_kurir` FOR EACH ROW BEGIN
    INSERT INTO crud_log VALUES(null, NOW(), 'update', 'tb_kurir', NEW.id);
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_member`
--

CREATE TABLE `tb_member` (
  `id` int(11) NOT NULL,
  `nama_member` varchar(100) NOT NULL,
  `alamat` text NOT NULL,
  `jenis_kelamin` enum('Laki - Laki','Perempuan') NOT NULL,
  `tlp` varchar(15) NOT NULL,
  `id_outlet` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tb_member`
--

INSERT INTO `tb_member` (`id`, `nama_member`, `alamat`, `jenis_kelamin`, `tlp`, `id_outlet`) VALUES
(15, 'Yusuf', 'Tambakan', 'Laki - Laki', '089938274882', 22),
(16, 'Dela Puspita', 'Cibogo', 'Perempuan', '088493392203', 20),
(17, 'Moci', 'Tambakan', 'Laki - Laki', '088393402013', 22),
(18, 'Toni', 'Cerelek', 'Laki - Laki', '089938492174', 22);

--
-- Trigger `tb_member`
--
DELIMITER $$
CREATE TRIGGER `crud_delete_pelanggan` AFTER DELETE ON `tb_member` FOR EACH ROW BEGIN
    INSERT INTO crud_log VALUES(null, NOW(), 'delete', 'tb_member', OLD.id);
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `crud_insert_pelanggan` AFTER INSERT ON `tb_member` FOR EACH ROW BEGIN
    INSERT INTO crud_log VALUES(null, NOW(), 'insert', 'tb_member', NEW.id);
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `crud_update_pelanggan` AFTER UPDATE ON `tb_member` FOR EACH ROW BEGIN
    INSERT INTO crud_log VALUES(null, NOW(), 'update', 'tb_member', NEW.id);
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_outlet`
--

CREATE TABLE `tb_outlet` (
  `id` int(11) NOT NULL,
  `nama_outlet` varchar(100) NOT NULL,
  `alamat` text NOT NULL,
  `tlp` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tb_outlet`
--

INSERT INTO `tb_outlet` (`id`, `nama_outlet`, `alamat`, `tlp`) VALUES
(20, 'Outlet Santuy Cabang Pagaden', 'Pagaden', '08977500294'),
(22, 'Outlet Santuy Cabang Jalan Cagak', 'Jalan Cagak', '082217673242'),
(27, 'Outlet Santuy Cabang Subang', 'Subang', '0822819440385'),
(28, 'Outlet Santuy Cabang Purwadadi', 'Purwadadi', '089938263711'),
(31, 'Outlet Pusat', 'Wakanda', '089623097303');

--
-- Trigger `tb_outlet`
--
DELIMITER $$
CREATE TRIGGER `crud_delete_outlet` AFTER DELETE ON `tb_outlet` FOR EACH ROW BEGIN
    INSERT INTO crud_log VALUES(null, NOW(), 'delete', 'tb_outlet', OLD.id);
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `crud_insert_outlet` AFTER INSERT ON `tb_outlet` FOR EACH ROW BEGIN
    INSERT INTO crud_log VALUES(null, NOW(), 'insert', 'tb_outlet', NEW.id);
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `crud_update_outlet` AFTER UPDATE ON `tb_outlet` FOR EACH ROW BEGIN
    INSERT INTO crud_log VALUES(null, NOW(), 'update', 'tb_outlet', NEW.id);
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_paket`
--

CREATE TABLE `tb_paket` (
  `id` int(11) NOT NULL,
  `id_outlet` int(11) NOT NULL,
  `nama_paket` varchar(100) NOT NULL,
  `id_jenis` int(11) NOT NULL,
  `harga` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tb_paket`
--

INSERT INTO `tb_paket` (`id`, `id_outlet`, `nama_paket`, `id_jenis`, `harga`) VALUES
(18, 20, 'Selimut Bayi', 10, 4000),
(19, 20, 'Selimut Tidur', 10, 5000),
(20, 22, 'Kaos', 9, 4000),
(21, 22, 'Sepatu Sekolah', 17, 6000),
(22, 20, 'Bed Cover Size M', 16, 5000);

--
-- Trigger `tb_paket`
--
DELIMITER $$
CREATE TRIGGER `crud_delete_paket` AFTER DELETE ON `tb_paket` FOR EACH ROW BEGIN
    INSERT INTO crud_log VALUES(null, NOW(), 'delete', 'tb_paket', OLD.id);
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `crud_insert_paket` AFTER INSERT ON `tb_paket` FOR EACH ROW BEGIN
    INSERT INTO crud_log VALUES(null, NOW(), 'insert', 'tb_paket', NEW.id);
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `crud_update_paket` AFTER UPDATE ON `tb_paket` FOR EACH ROW BEGIN
    INSERT INTO crud_log VALUES(null, NOW(), 'update', 'tb_paket', NEW.id);
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_pengeluaran`
--

CREATE TABLE `tb_pengeluaran` (
  `id` int(11) NOT NULL,
  `id_outlet` int(11) NOT NULL,
  `nama_barang` varchar(100) NOT NULL,
  `tgl` datetime NOT NULL,
  `total` int(11) NOT NULL,
  `keterangan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tb_pengeluaran`
--

INSERT INTO `tb_pengeluaran` (`id`, `id_outlet`, `nama_barang`, `tgl`, `total`, `keterangan`) VALUES
(20, 20, 'Molto', '2021-03-18 00:00:00', 5000, 'Pewangi pakaian'),
(21, 22, 'Molto', '2021-03-19 00:00:00', 6000, 'Pewangi'),
(22, 22, 'Rinso', '2021-03-19 00:00:00', 4000, 'mkdlakod'),
(23, 20, 'Rinso', '2021-03-19 00:00:00', 5000, 'jnfjfnsfsnjk');

--
-- Trigger `tb_pengeluaran`
--
DELIMITER $$
CREATE TRIGGER `crud_delete_pengeluaran` AFTER DELETE ON `tb_pengeluaran` FOR EACH ROW BEGIN
    INSERT INTO crud_log VALUES(null, NOW(), 'delete', 'tb_pengeluran', OLD.id);
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `crud_insert_pengeluaran` AFTER INSERT ON `tb_pengeluaran` FOR EACH ROW BEGIN
    INSERT INTO crud_log VALUES(null, NOW(), 'insert', 'tb_pengeluaran', NEW.id);
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `crud_update_pengeluaran` AFTER UPDATE ON `tb_pengeluaran` FOR EACH ROW BEGIN
    INSERT INTO crud_log VALUES(null, NOW(), 'update', 'tb_pengeluaran', NEW.id);
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_transaksi`
--

CREATE TABLE `tb_transaksi` (
  `id` int(11) NOT NULL,
  `id_outlet` int(11) NOT NULL,
  `kode_invoice` varchar(100) NOT NULL,
  `id_member` int(11) NOT NULL,
  `tgl` datetime NOT NULL,
  `batas_waktu` datetime NOT NULL,
  `tgl_bayar` datetime DEFAULT NULL,
  `biaya_tambahan` int(11) NOT NULL,
  `diskon` double NOT NULL,
  `pajak` int(11) NOT NULL,
  `total_pembayaran` int(11) NOT NULL,
  `status` enum('baru','proses','selesai','diambil') NOT NULL,
  `dibayar` enum('dibayar','belum_dibayar') NOT NULL,
  `id_kurir` int(11) NOT NULL,
  `id_user` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tb_transaksi`
--

INSERT INTO `tb_transaksi` (`id`, `id_outlet`, `kode_invoice`, `id_member`, `tgl`, `batas_waktu`, `tgl_bayar`, `biaya_tambahan`, `diskon`, `pajak`, `total_pembayaran`, `status`, `dibayar`, `id_kurir`, `id_user`) VALUES
(13, 20, 'INV2103200953', 15, '2021-03-20 09:53:47', '2021-03-20 00:00:00', '2021-03-20 09:53:47', 0, 0, 0, 5000, 'baru', 'dibayar', 10, 46),
(15, 20, 'INV2103201020', 16, '2021-03-20 10:20:11', '2021-03-24 00:00:00', '2021-03-20 10:20:11', 0, 0, 0, 5000, 'baru', 'dibayar', 10, 46),
(16, 20, 'INV2103201023', 15, '2021-03-20 10:23:01', '2021-03-20 00:00:00', '2021-03-20 10:23:01', 0, 0, 0, 5000, 'baru', 'dibayar', 10, 46),
(19, 20, 'INV2103201028', 15, '2021-03-20 10:28:06', '2021-03-20 00:00:00', '2021-03-20 10:28:06', 0, 0, 0, 4000, 'baru', 'dibayar', 11, 46),
(20, 20, 'INV2103201028', 15, '2021-03-20 10:28:06', '2021-03-20 00:00:00', '2021-03-20 10:28:06', 0, 0, 0, 4000, 'baru', 'dibayar', 11, 46),
(23, 20, 'INV2103201031', 15, '2021-03-20 10:31:27', '2021-03-20 00:00:00', '2021-03-20 23:54:53', 0, 0, 0, 6000, 'selesai', 'dibayar', 10, 46),
(24, 20, 'INV2103201031', 15, '2021-03-20 10:31:27', '2021-03-20 00:00:00', '2021-03-20 23:54:53', 0, 0, 0, 5000, 'selesai', 'dibayar', 10, 46),
(25, 20, 'INV2103201036', 16, '2021-03-20 10:36:48', '2021-03-31 00:00:00', '2021-03-20 10:36:48', 1500, 450, 450, 5500, 'baru', 'dibayar', 8, 46),
(26, 20, 'INV2103201036', 16, '2021-03-20 10:36:48', '2021-03-31 00:00:00', '2021-03-20 10:36:48', 1500, 450, 450, 6500, 'baru', 'dibayar', 8, 46),
(27, 22, 'INV2103202258', 17, '2021-03-20 22:58:00', '2021-03-20 00:00:00', '2021-03-20 22:58:00', 5000, 1250, 6250, 15000, 'baru', 'dibayar', 8, 50),
(28, 22, 'INV2103202258', 17, '2021-03-20 22:58:00', '2021-03-20 00:00:00', '2021-03-20 22:58:00', 5000, 1250, 6250, 30000, 'baru', 'dibayar', 8, 50),
(29, 20, 'INV2103202352', 17, '2021-03-20 23:52:39', '2021-03-20 00:00:00', '2021-03-21 23:02:53', 10000, 3750, 2250, 83500, 'selesai', 'dibayar', 10, 46);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_user`
--

CREATE TABLE `tb_user` (
  `id` int(11) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` text NOT NULL,
  `id_outlet` int(11) NOT NULL,
  `role` enum('admin','kasir','owner','superAdmin') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tb_user`
--

INSERT INTO `tb_user` (`id`, `nama`, `username`, `password`, `id_outlet`, `role`) VALUES
(46, 'Administrator', 'admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 20, 'admin'),
(47, 'Kasir', 'kasir', '2c7ee7ade401a7cef9ef4dad9978998cf42ed805243d6c91f89408c6097aa571', 20, 'kasir'),
(48, 'Owner', 'owner', '4c1029697ee358715d3a14a2add817c4b01651440de808371f78165ac90dc581', 20, 'owner'),
(50, 'Dana S Rusnandar', 'dana', '2c9e0a2585dc7406589a3724f0027811506e0f133726303a15d6779d532a2573', 22, 'admin'),
(51, 'Nova Puspita', 'nova', '19e05df6b2e5fb94f3ee7eed2c02d340a1128a00231f5f6949641a143ab3b57a', 22, 'kasir'),
(52, 'Yanto Sujirwo', 'yanto', '2473c6c903469b0cae713acf2ad11c501467451941273767ca809992b4a97268', 22, 'owner'),
(53, 'Rekt Xenza', 'xenza', '45bafd2ef89a4d20898da09b54b1914b01ebb00c63677e017d0c112e906e56ea', 31, 'superAdmin');

--
-- Trigger `tb_user`
--
DELIMITER $$
CREATE TRIGGER `crud_delete_user` AFTER DELETE ON `tb_user` FOR EACH ROW BEGIN
    INSERT INTO crud_log VALUES(null, NOW(), 'delete', 'tb_user', OLD.id);
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `crud_insert_user` AFTER INSERT ON `tb_user` FOR EACH ROW BEGIN
    INSERT INTO crud_log VALUES(null, NOW(), 'insert', 'tb_user', NEW.id);
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `crud_update_user` AFTER UPDATE ON `tb_user` FOR EACH ROW BEGIN
    INSERT INTO crud_log VALUES(null, NOW(), 'update', 'tb_user', NEW.id);
END
$$
DELIMITER ;

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `crud_log`
--
ALTER TABLE `crud_log`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `login_log`
--
ALTER TABLE `login_log`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_user` (`id_user`);

--
-- Indeks untuk tabel `tb_detail_transaksi`
--
ALTER TABLE `tb_detail_transaksi`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_transaksi` (`id_transaksi`),
  ADD KEY `id_paket` (`id_paket`);

--
-- Indeks untuk tabel `tb_jenis`
--
ALTER TABLE `tb_jenis`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `tb_kurir`
--
ALTER TABLE `tb_kurir`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_outlet` (`id_outlet`);

--
-- Indeks untuk tabel `tb_member`
--
ALTER TABLE `tb_member`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_outlet` (`id_outlet`);

--
-- Indeks untuk tabel `tb_outlet`
--
ALTER TABLE `tb_outlet`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `tb_paket`
--
ALTER TABLE `tb_paket`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_outlet` (`id_outlet`),
  ADD KEY `id_jenis` (`id_jenis`);

--
-- Indeks untuk tabel `tb_pengeluaran`
--
ALTER TABLE `tb_pengeluaran`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_outlet` (`id_outlet`);

--
-- Indeks untuk tabel `tb_transaksi`
--
ALTER TABLE `tb_transaksi`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_user` (`id_user`),
  ADD KEY `id_outlet` (`id_outlet`),
  ADD KEY `id_member` (`id_member`),
  ADD KEY `id_kurir` (`id_kurir`);

--
-- Indeks untuk tabel `tb_user`
--
ALTER TABLE `tb_user`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_outlet` (`id_outlet`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `crud_log`
--
ALTER TABLE `crud_log`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `login_log`
--
ALTER TABLE `login_log`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT untuk tabel `tb_detail_transaksi`
--
ALTER TABLE `tb_detail_transaksi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT untuk tabel `tb_jenis`
--
ALTER TABLE `tb_jenis`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT untuk tabel `tb_kurir`
--
ALTER TABLE `tb_kurir`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT untuk tabel `tb_member`
--
ALTER TABLE `tb_member`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT untuk tabel `tb_outlet`
--
ALTER TABLE `tb_outlet`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT untuk tabel `tb_paket`
--
ALTER TABLE `tb_paket`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT untuk tabel `tb_pengeluaran`
--
ALTER TABLE `tb_pengeluaran`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT untuk tabel `tb_transaksi`
--
ALTER TABLE `tb_transaksi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT untuk tabel `tb_user`
--
ALTER TABLE `tb_user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=54;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tb_detail_transaksi`
--
ALTER TABLE `tb_detail_transaksi`
  ADD CONSTRAINT `tb_detail_transaksi_ibfk_1` FOREIGN KEY (`id_transaksi`) REFERENCES `tb_transaksi` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tb_detail_transaksi_ibfk_2` FOREIGN KEY (`id_paket`) REFERENCES `tb_paket` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `tb_kurir`
--
ALTER TABLE `tb_kurir`
  ADD CONSTRAINT `tb_kurir_ibfk_1` FOREIGN KEY (`id_outlet`) REFERENCES `tb_outlet` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `tb_member`
--
ALTER TABLE `tb_member`
  ADD CONSTRAINT `tb_member_ibfk_1` FOREIGN KEY (`id_outlet`) REFERENCES `tb_outlet` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `tb_paket`
--
ALTER TABLE `tb_paket`
  ADD CONSTRAINT `tb_paket_ibfk_1` FOREIGN KEY (`id_outlet`) REFERENCES `tb_outlet` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tb_paket_ibfk_2` FOREIGN KEY (`id_jenis`) REFERENCES `tb_jenis` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `tb_pengeluaran`
--
ALTER TABLE `tb_pengeluaran`
  ADD CONSTRAINT `tb_pengeluaran_ibfk_1` FOREIGN KEY (`id_outlet`) REFERENCES `tb_outlet` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `tb_transaksi`
--
ALTER TABLE `tb_transaksi`
  ADD CONSTRAINT `tb_transaksi_ibfk_1` FOREIGN KEY (`id_member`) REFERENCES `tb_member` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tb_transaksi_ibfk_2` FOREIGN KEY (`id_user`) REFERENCES `tb_user` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tb_transaksi_ibfk_3` FOREIGN KEY (`id_outlet`) REFERENCES `tb_outlet` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tb_transaksi_ibfk_4` FOREIGN KEY (`id_kurir`) REFERENCES `tb_kurir` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `tb_user`
--
ALTER TABLE `tb_user`
  ADD CONSTRAINT `tb_user_ibfk_1` FOREIGN KEY (`id_outlet`) REFERENCES `tb_outlet` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
