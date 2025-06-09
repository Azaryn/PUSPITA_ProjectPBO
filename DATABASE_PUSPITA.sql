DROP TABLE IF EXISTS transaksi;
DROP TABLE IF EXISTS detail_transaksi;
DROP TABLE IF EXISTS produk;
DROP TABLE IF EXISTS jenis_produk;
DROP TABLE IF EXISTS kategori_produk;
DROP TABLE IF EXISTS petani;
DROP TABLE IF EXISTS admins;

CREATE TABLE petani (
  id_petani SERIAL PRIMARY KEY,
  username VARCHAR(50) NOT NULL,
  password_petani VARCHAR(50) NOT NULL,
  alamat VARCHAR(100) NOT NULL
);


CREATE TABLE admins (
  id_admin SERIAL PRIMARY KEY,
  username VARCHAR(50) NOT NULL,
  password_admin VARCHAR(50) NOT NULL
);

CREATE TABLE kategori_produk (
  id_kategori SERIAL PRIMARY KEY,
  kategori VARCHAR(20) NOT NULL
);

CREATE TABLE jenis_produk (
  id_jenis SERIAL PRIMARY KEY,
  id_kategori INT NOT NULL,
  jenis VARCHAR(50) NOT NULL,
  FOREIGN KEY (id_kategori) REFERENCES kategori_produk (id_kategori)
);

CREATE TABLE produk (
  id_produk SERIAL PRIMARY KEY,
  nama_produk VARCHAR(50) NOT NULL,
  id_jenis INT NOT NULL,
  dosis INT  NOT NULL CHECK (dosis BETWEEN 100 AND 200),
  harga DECIMAL(10,2) NOT NULL,
  discontinued SMALLINT NOT NULL CHECK (discontinued IN (0,1)),
  FOREIGN KEY (id_jenis) REFERENCES jenis_produk (id_jenis)
);

CREATE TABLE transaksi (
  id_transaksi SERIAL PRIMARY KEY,
  tanggal_transaksi DATE NOT NULL,
  id_petani INT NOT NULL,
  metode_pembayaran VARCHAR(50) NOT NULL,
  jenis_pengiriman VARCHAR(50) NOT NULL,
  FOREIGN KEY (id_petani) REFERENCES petani(id_petani)
);

CREATE TABLE detail_transaksi (
  id_detail SERIAL PRIMARY KEY,
  id_transaksi INT NOT NULL,
  id_produk INT NOT NULL,
  jumlah INT NOT NULL,
  FOREIGN KEY (id_transaksi) REFERENCES transaksi(id_transaksi),
  FOREIGN KEY (id_produk) REFERENCES produk(id_produk)
);

-- Insert an
INSERT INTO admins (username,password_admin)
VALUES ('admin','123');

INSERT INTO petani (username,password_petani,alamat)
VALUES 
('rafi','111','Halmahera'),
('rafa','222','Jl. Jawa'),
('habib','333','Jl. Mangli');

INSERT INTO kategori_produk (kategori)
VALUES 
('Pupuk'),
('Pestisida');

INSERT INTO jenis_produk (id_kategori,jenis)
VALUES
(1,'Organik'),
(1,'Anorganik'),
(2,'Insektisida'),
(2,'Herbisida'),
(2,'Fungisida');

INSERT INTO produk (nama_produk,id_jenis,dosis,harga,discontinued)
VALUES
('Urea', 2,150,10000,1),
('Kompos', 1,100,15000,1),
('Kandang', 1,100, 5000,0),
('SP-36', 2,200,15000,0),
('Glifosat', 4,150,15000,1),
('Profenofos', 3,200,30000,1),
('Mancozeb', 5,100,18000,1),
('Gramoxone', 4,200,15000,0);

INSERT INTO transaksi (tanggal_transaksi,id_petani,metode_pembayaran,jenis_pengiriman)
VALUES
('2025-05-22',1,'PuspiPay','PuspiFast'),
('2025-10-21',2,'E-Bank','JNE');

INSERT INTO detail_transaksi (id_transaksi,id_produk,jumlah)
VALUES
(1, (SELECT id_produk FROM produk WHERE nama_produk='Glifosat'), 2),
(1, (SELECT id_produk FROM produk WHERE nama_produk='Urea'), 1);

INSERT INTO detail_transaksi (id_transaksi,id_produk,jumlah)
VALUES
(2, (SELECT id_produk FROM produk WHERE nama_produk='Kompos'), 1),
(2, (SELECT id_produk FROM produk WHERE nama_produk='Profenofos'),2),
(2, (SELECT id_produk FROM produk WHERE nama_produk='Glifosat'), 1);
