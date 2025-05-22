DROP TABLE IF EXISTS penjual;



Create table penjual (
	ID_Penjual serial,
	Username varchar(50) NOT NULL,
	Password varchar(50) NOT NULL,
	Alamat varchar(50) NOT NULL
);

Create table admin (
	ID_Admin serial,
	Username varchar(50) NOT NULL,
	Password varchar(50) 
);

Create table pupuk (
	ID_Pupuk serial,
	Nama_pupuk varchar(50) NOT NULL,
	ID_JenisPupuk varchar(50) NOT NULL,
	Stock int NOT NULL,
	Harga int NOT NULL
);

Create table Pestisida (
	ID_Pestisida serial,
	Nama_Pestisida varchar(50) NOT NULL,
	ID_JenisPestisida Serial NOT NULL,
	Stock int NOT NULL,
	Harga int NOT NULL
);

create table jenis_pupuk (
	ID_JenisPupuk serial,
	Jenis_Pupuk varchar(50)
);

create table jenis_pestisida (
	ID_JenisPestisida serial,
	Jenis_Pestisida varchar(50)
);

create table rekomendasi_pestisida(
	ID_RekomendasiPestisida Serial,
	ID_Pestisida Serial
)