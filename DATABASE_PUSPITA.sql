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
	Dosis int NOT NULL CHECK (Dosis Between 100 AND 200),
	Harga Decimal(10,2) NOT NULL,
	Discontinued smallint NOT NULL CHECK(Discontinued IN (0,1)),
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
	Dosis int NOT NULL CHECK (Dosis between 100 and 200),
	Harga Decimal(10,2) NOT NULL,
	Discontinued smallint NOT NULL CHECK(Discontinued IN (0,1)),
	foreign key (ID_JenisPestisida) references jenis_Pestisida(ID_JenisPestisida)
);

create table transaksi(
	ID_Transaksi serial primary key,
	Tanggal_transaksi Date NOT NULL,
	ID_petani int NOT NULL,
	MetodePembayaran varchar(50) NOT NULL,
	JenisPengiriman varchar(50) NOT NULL,
	foreign key (ID_Petani) references petani (ID_Petani)
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

insert into admins(Username,Password_admin)
values ('admin',123);

insert into petani(Username,Password_petani,Alamat)
values
('rafi',111, 'halmahera'),
('rafa',222,'jl jawa'),
('habib',333,'jl mangli');

insert into Jenis_pupuk (jenis_pupuk)
values
('Organik'),
('Anorganik');

insert into jenis_pestisida (jenis_pestisida)
values
('Insektisida'),
('Herbisida'),
('Fungisida');

insert into pupuk(Nama_pupuk, id_jenispupuk,dosis, Harga,Discontinued)
values
('Urea', 2,150, 10000,1),
('Kompos', 1, 100, 15000,1),
('Kandang', 1, 100, 5000,0),
('SP-36', 2,200,15000,0);

insert into pestisida (nama_pestisida, id_jenispestisida, dosis, harga,Discontinued)
values
('Glifosat', 2, 150, 15000,1),
('Profenofos',1,200,30000,1),
('Mancozeb',3,100,18000,1),
('Gramoxone',2,200,15000,0);

insert into Transaksi (tanggal_transaksi, id_petani,metodepembayaran,jenispengiriman)
values 
('2025/5/22', 1,'PuspiPay','PuspiFast'),
('2025/10/21',2, 'E-Bank', 'JNE');

insert into detail_transaksipupuk (id_transaksi, id_pupuk, quantity)
values 
(1,1,2),
(1,1,1),
(2,2,1);

insert into detail_transaksipestisida (id_transaksi, id_pestisida, quantity)
values
(1,1,2),
(2,2,2),
(2,1,1);

-----------------------------------------------------------------------------------------------