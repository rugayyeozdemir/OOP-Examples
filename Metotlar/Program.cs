// See https://aka.ms/new-console-template for more information

using Metotlar;


string urunAdi 0 "Elma";
double fiyat = 15;
string aciklama = "Amasya Elması";

string[] meyveler = new string[] { };

Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15; 
urun1.Aciklama = "Amasya elması";

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır Karpuzu";

Urun[] urunler = new Urun[] { urun1, urun2 };

// type-safe = tip güvenli 
foreach (Urun urun in urunler )
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("-------");

}



