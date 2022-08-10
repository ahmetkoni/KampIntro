// See https://aka.ms/new-console-template for more information

using Metodlar;

Urun Urun1= new Urun();
Urun1.Adi = "elma";
Urun1.Fiyati = 15;
Urun1.Aciklama = "AmASYA ELMASI";

Urun Urun2 = new Urun();
Urun2.Adi = "karpuz";
Urun2.Fiyati = 80;
Urun2.Aciklama = "Diyarbakır karpuzu";

Urun[] urunler = new Urun[] { Urun1 , Urun2 };

foreach ( var urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("---------");
}
Console.WriteLine("----METOTLAR------");

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(Urun1);


sepetManager.Ekle2("Armut", "yeşil armut", 15;
sepetManager.Ekle2("elma", "yeşil elma", 12);
sepetManager.Ekle2("karpuz", "diayrbakır karpuzu", 12);





