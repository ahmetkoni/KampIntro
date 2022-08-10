// See https://aka.ms/new-console-template for more informatio 


string kurs1 = "Yazılım Geliştrici Yetiştirme Kampı";
string kurs2 = "Programlamaya Başlangıç için temel kurslar";
string kurs3 = "Java";

string[] kurslar = new string[] {
    "Yazılım Geliştrici Yetiştirme Kampı",
    "Programlamaya Başlangıç için temel kurslar",
    "Java"
};
for (int i = 0; i <3; i++)
{
    Console.WriteLine(kurslar[i]); 
}
Console.WriteLine("SAYFA SONU  -  FOOTER ");


string[] ayakkabılar = new string[]
{
    "nike",
    "adidas",
    "puma",
    "kinetix",
    "ayakkabı1",
    "ayakkabı2",
    "ayakkabı3",
    "ayakkabı4"
};
for (int i = 0; i <ayakkabılar.Length; i++)
{
    Console.WriteLine(ayakkabılar[i]);
}
Console.WriteLine("en güzelini seçtiniz.");
foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}

string[] karakterler = new string[]
{
    "kiraz",
    "adam",
    "eva",
    "lilith"
};
foreach (string karakter in karakterler)
{
    Console.WriteLine(karakter);
};
