
urun urun1 = new urun();
urun1.urunadi = "tava";
urun1.urunfiyati = 39.90;
urun1.urundekindirim = 10;


urun urun2 = new urun();
urun2.urunadi = "bardak";
urun2.urunfiyati = 9.35;
urun2.urundekindirim = 2;


urun urun3 = new urun();
urun3.urunadi = "termos";
urun3.urunfiyati = 179.99;
urun3.urundekindirim = 23;
urun[] urunler = new urun[] { urun1,urun2, urun3 };
foreach (var urun in urunler)
{
    Console.WriteLine(urun.urunadi + " : " + urun.urundekindirim + " : " + urun.urunfiyati);
}

class urun
{
    public double urunfiyati { get; set; }
    public string urunadi { get; set; }
    public int urundekindirim { get; set; }
}

