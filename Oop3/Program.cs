// See https://aka.ms/new-console-template for more information
using Oop3;
IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasıtKrediManager = new TasıtKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();
//basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService();  alttaki satırla aynı ama alternatif bi yöntem.
basvuruManager.BasvuruYap(ihtiyacKrediManager, fileLoggerService);

List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasıtKrediManager};
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);





