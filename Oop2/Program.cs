// See https://aka.ms/new-console-template for more information

using Oop2;
//Ahmet K girisi
GercekMusteri musteri1 = new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = "12345";
musteri1.Adi = "Ahemt";
musteri1.Soyadi = "K";
musteri1.TcNo = "1343245";

//Tuzel kisi girisi
TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "23242432";
musteri2.SirketAdi = "Sirket";
musteri2.VergiNo = "1234567890";

Musteri musteri3 = new TuzelMusteri();
Musteri musteri4 = new GercekMusteri();


CustomerManager CustomerManager = new CustomerManager();
CustomerManager.Ekle(musteri1);
