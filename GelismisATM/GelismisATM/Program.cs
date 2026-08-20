Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Clear();

Console.WriteLine("\t\t\tNozkok ATM'ye hosgeldiniz");
Console.Write("\t\t\tDevam etmek icin bir tusa basiniz:");
Console.ReadKey();

decimal bakiye = 1000;
List<string> hesapGecmisi = new List<string>();
string tl = "₺";
while (true)
{
    
    Console.Clear();
    Console.WriteLine("\t\t\t\tNOZKOK ATM");
    Console.WriteLine("\t\t\t\tANA MENU");
    Console.WriteLine("\t\t\t1-Bakiye Sorgula");
    Console.WriteLine("\t\t\t2-Para Yatır");
    Console.WriteLine("\t\t\t3-Para Cek");
    Console.WriteLine("\t\t\t4-Hesap Ozeti/Gecmis Islemler");
    Console.WriteLine("\t\t\t5-Kart iade/Cikis");
    bool giris = (!int.TryParse(Console.ReadLine(), out int secim));
    if (giris || (secim < 1 || secim > 5))
    {
        Console.WriteLine("Lutfen 0 ve 6 arasinda bir sayi giriniz");
        Console.ReadKey();
        continue;
    }
    switch (secim)
    {
        case 1:
            BakiyeSorgulama();
            break;
        case 2:
            Parayatir();
            break;
        case 3:
            ParaCek();
            break;
        case 4:
            HesapOzetiListele();
            break;
        case 5:
            Console.WriteLine("Cikis Yapildi");
            return;
    }
    
}
void BakiyeSorgulama()
{
    Console.Clear();
    string tl ="₺";
    Console.WriteLine($"\t\t\tBakiyeniz : {tl}{bakiye}");
    Console.ReadKey();
}

void Parayatir()
{
    Console.Clear();
    Console.WriteLine("\t\t\tPara yatirma");
    Console.Write($"\t\t\tYatirilacak tutari giriniz: {tl}");
    bool tutar = !decimal.TryParse(Console.ReadLine(), out decimal yatirilacakTutar);
    if (tutar || yatirilacakTutar < 0 || yatirilacakTutar == 0)
    {
        Console.WriteLine("Lutfen tekrar deneyiniz");
        return;
    }
    bakiye += yatirilacakTutar;
    hesapGecmisi.Add($"[{DateTime.Now:dd.MM.yyyy HH:mm}] Yatirilan tutar : {tl}{yatirilacakTutar}");
    Console.WriteLine("\t\t\tYatirma basarili");
    Console.WriteLine($"\t\t\tYeni bakiyeniz : {tl}{bakiye}");
    Console.ReadKey();
}

void ParaCek()
{
    Console.Clear();
    Console.WriteLine("\t\t\tPara cekme");
    Console.WriteLine($"\t\t\tBakiyeniz : {tl}{bakiye}");
    Console.Write($"\t\t\tCekilecek tutari giriniz: {tl}");
    bool tutar1 = !decimal.TryParse(Console.ReadLine(), out decimal cekilecekTutar);
    if (tutar1 || cekilecekTutar <= 0 || cekilecekTutar > bakiye)
    {
        Console.WriteLine("Hatali islem yaptiniz");
        return;
    }
    bakiye -= cekilecekTutar;
    hesapGecmisi.Add($"[{DateTime.Now:dd.MM.yyyy HH:mm}] Cekilen tutar : {tl}{cekilecekTutar}");
    Console.WriteLine("\t\t\tCekme basarili");
    Console.WriteLine($"\t\t\tYeni bakiyeniz : {tl}{bakiye}");
    Console.ReadKey();
}
void HesapOzetiListele()
{
    Console.Clear();
    Console.WriteLine("\t\t\tHesap Ozeti");
    if (hesapGecmisi.Count == 0)
    {
        Console.WriteLine("Henuz bir hesap hareketi bulunmamaktadir");
    }
    else
    {
        foreach (var islem in hesapGecmisi)
        {
            Console.WriteLine(islem);
        }
    } 
    Console.ReadKey();
}