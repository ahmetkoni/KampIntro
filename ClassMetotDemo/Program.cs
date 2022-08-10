// See https://aka.ms/new-console-template for more information

using ClassMetotDemo;

Musteri musteri1 = new Musteri();
musteri1.Id = 1;
musteri1.Adi = "ahmet";
musteri1.Soyadi = "k";
musteri1.Yası = 21;

Musteri musteri2 = new Musteri();
musteri2.Id= 2;
musteri2.Adi = "temmuz";
musteri2.Soyadi = "uzay";
musteri2.Yası = 21;

Musteri musteri3=new Musteri(); 
musteri3.Id= 3;
musteri3.Adi = "efe";
musteri3.Soyadi = "kyra";
musteri3.Yası = 24;

Musteri musteri4= new Musteri();
musteri4.Id= 4;
musteri4.Adi = "çağan";
musteri4.Soyadi = "çınar";
musteri4.Yası = 27;

MusteriManager musterimanager = new MusteriManager();
musterimanager.musteriekle(musteri1);
musterimanager.musteriekle2(musteri2);
musterimanager.musteriekle3(musteri3);
musterimanager.musteriekle4(musteri4);
