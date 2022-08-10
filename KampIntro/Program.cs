// See https://aka.ms/new-console-template for more information
string KategoriEtiketi = "kategoriler";
Console.WriteLine(KategoriEtiketi);
Console.WriteLine(KategoriEtiketi);
Console.WriteLine(KategoriEtiketi);
int ogrenciSayisi = 32000;
Console.WriteLine(ogrenciSayisi);
double faizOrani = 1.45;
Console.WriteLine(faizOrani);
bool SistemeGirisYapmiMi = false;
Console.WriteLine(SistemeGirisYapmiMi);
if(SistemeGirisYapmiMi == true)
{
    Console.WriteLine("Kullanıcı Ayarları Butonu");
}
else
{
    Console.WriteLine("Giris Yap Butonu");
}

int sevilensayi = 2;
if (sevilensayi == 3 && SistemeGirisYapmiMi == false)
{
    Console.WriteLine("Sen Muazzam Bi İnsansın");
}
else
{
    Console.WriteLine("sen muazzam değilsin");
}
double dolarDun = 3.15;
double dolarBugun = 3.15;
if (dolarDun > dolarBugun)
{
    Console.WriteLine("azalış butonu");
}
else if (dolarDun==dolarBugun) {
    Console.WriteLine("değişmedi butonu");
}
else
{
    Console.WriteLine("artış oku");
}
