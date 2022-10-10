-- TABLE
CREATE TABLE ADRES(
Adres_id       		INT PRIMARY KEY,
Adres_detay		VARCHAR(20));
CREATE TABLE CINSIYET(
Cinsiyet_id 		CHAR(1) PRIMARY KEY,
Cinsiyet_adi		VARCHAR(5));
CREATE TABLE demo (ID integer primary key, Name varchar(20), Hint text );
CREATE TABLE DERSLER(
Ders_id        	 	INT PRIMARY KEY,
Ders_Adi        	           VARCHAR(20),
Ogretmen_id    	INT REFERENCES OGRETMENLER);
CREATE TABLE MUHASEBE(
Kayit_no    	 	INT PRIMARY KEY,
Ogrenci_numara  	INT REFERENCES OGRENCILER,
Ogrenci_Adi     	VARCHAR(20),
Ogrenci_Soyadi  	VARCHAR(20),
Cinsiyet_id 		CHAR(1) REFERENCES CINSIYET,
Sinif_Adi       	NVARCHAR(3) REFERENCES SINIFLAR,
Veli_Adi  		VARCHAR(20),
Veli_Soyadi  		VARCHAR(20),
Kalan_Borc		INT);
CREATE TABLE OGRENCILER(
Ogrenci_numara  	INT PRIMARY KEY,
Adres_id        	            INT REFERENCES ADRES,
Ogrenci_Adi     	VARCHAR(20),
Ogrenci_Soyadi  	VARCHAR(20),
Cinsiyet_id 		CHAR(1) REFERENCES CINSIYET,
Sinif_Adi       	            NVARCHAR(3) REFERENCES SINIFLAR,
Veli_Adi  		VARCHAR(20),
Veli_Soyadi  		VARCHAR(20),
Veli_tel		NVARCHAR(20));
CREATE TABLE OGRETMENLER(
Ogretmen_id    	INT PRIMARY KEY,
Ogretmen_Ad     	VARCHAR(20),
Ogretmen_Soyad  	VARCHAR(20),
Cinsiyet_id     	            CHAR(1) REFERENCES CINSIYET,
Adres_id          	INT REFERENCES ADRES);
CREATE TABLE PERSONEL(
Personel_id  		INT PRIMARY KEY,
Personel_adi 		VARCHAR(20),
Personel_Soyadi 	VARCHAR(20),
Cinsiyet_id 		CHAR(1) REFERENCES CINSIYET,
Adres_id        	            INT REFERENCES ADRES,
Personel_Gorevi	VARCHAR(20));
CREATE TABLE SERVIS_KAYDI(
Ogrenci_numara  	 INT PRIMARY KEY REFERENCES OGRENCILER,
Servis_sirket_id	 INT REFERENCES SERVIS_SIRKET,
Servis_guzergah_id	 INT);
CREATE TABLE SERVIS_SIRKET(
Servis_sirket_id	 INT PRIMARY KEY,
Servis_sirket_adi	 VARCHAR(20));
CREATE TABLE SINIFLAR(
Sinif_Adi	 	NVARCHAR(3) PRIMARY KEY ,
Ogretmen_id      	INT REFERENCES OGRETMENLER);
CREATE TABLE SPOR_SALONU(
Ogrenci_numara    	 INT PRIMARY KEY REFERENCES OGRENCILER,
Kur			 INT,
Baslama_Tarihi  	 DATE);
CREATE TABLE YEMEKHANE_KAYDI(
Ogrenci_numara  	 INT PRIMARY KEY REFERENCES OGRENCILER,
Menu_tip		 INT);
 
-- INDEX
 
-- TRIGGER
 
-- VIEW
 
