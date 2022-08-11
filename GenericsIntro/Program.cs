// See https://aka.ms/new-console-template for more information
using GenericsIntro;

MyList<string> isimler = new MyList<string>();
isimler.Add("temmuz");
Console.WriteLine(isimler.Lenght);
isimler.Add("efe");
Console.WriteLine(isimler.Lenght);

foreach (var isim in isimler.Items)
{
    Console.WriteLine(isim);
}