// See https://aka.ms/new-console-template for more information

using Dictionary;
MyDictionary<string> kelimeler = new MyDictionary<string>();
kelimeler.Add("ağaç");
Console.WriteLine(kelimeler.lenght);
kelimeler.Add("kapı");
Console.WriteLine(kelimeler.lenght);
kelimeler.Add("kağıt");
Console.WriteLine(kelimeler.lenght);
foreach (var kelime in kelimeler.Items)
{
    Console.WriteLine(kelime);
}
    
