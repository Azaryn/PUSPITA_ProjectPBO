DROP TABLE IF EXISTS Detail_TransaksiPupuk;
DROP TABLE IF EXISTS Detail_TransaksiPestisida;
DROP TABLE IF EXISTS transaksi;
DROP TABLE IF EXISTS petani;
DROP TABLE IF EXISTS admins;
DROP TABLE IF EXISTS pupuk;
DROP TABLE IF EXISTS jenis_pupuk;
DROP TABLE IF EXISTS pestisida;
DROP TABLE IF EXISTS jenis_pestisida;

Create table petani(
	ID_Petani serial primary key,
	Username varchar(50) NOT NULL,
	Password_petani varchar(50) NOT NULL,
	Alamat varchar(50) NOT NULL
);

Create table admins(
	ID_Admin serial primary key,
	Username varchar(50) NOT NULL,
	Password_admin varchar(50) NOT NULL
);

create table jenis_pupuk (
	ID_JenisPupuk serial primary key,
	Jenis_Pupuk varchar(50)
);

create table Pupuk(
	ID_Pupuk serial primary key,
	Nama_pupuk varchar(50) NOT NULL,
	ID_JenisPupuk int NOT NULL,
	Stock int NOT NULL,
	Harga Decimal(10,2) NOT NULL,
	foreign key (ID_JenisPupuk) references jenis_pupuk(ID_JenisPupuk)
);

create table jenis_pestisida(
	ID_JenisPestisida serial primary key,
	Jenis_Pestisida varchar(50)
);

create table pestisida(
	ID_pestisida serial primary key,
	Nama_Pestisida varchar(50) NOT NULL,
	ID_JenisPestisida int NOT NULL,
	Stock int NOT NULL,
	Harga Decimal(10,2) NOT NULL,
	foreign key (ID_JenisPestisida) references jenis_Pestisida(ID_JenisPestisida)
);

create table transaksi(
	ID_Transaksi serial primary key,
	Tanggal_transaksi Date NOT NULL,
	ID_petani int NOT NULL,
	ID_Admin int NOT NULL,
	foreign key (ID_Petani) references petani (ID_Petani),
	foreign key (ID_admin) references admins (ID_Admin)
);

create table Detail_TransaksiPupuk(
	ID_TransaksiPupuk serial primary key,
	ID_Transaksi int not null,
	ID_Pupuk int not null,
	Quantity int not null,
	foreign key (ID_Transaksi) references transaksi(ID_Transaksi),
	foreign key (ID_Pupuk) references pupuk(ID_Pupuk)
);

create table Detail_TransaksiPestisida(
	ID_TransaksiPestisida serial primary key,
	ID_Transaksi int not null,
	ID_Pestisida int not null,
	Quantity int not null,
	foreign key (ID_Transaksi) references transaksi(ID_Transaksi),
	foreign key (ID_Pestisida) references pestisida(ID_Pestisida)
);

insert into  admins(username,Password_admin)
values
('rafi',123),
('rafa',123),
('habib',123);