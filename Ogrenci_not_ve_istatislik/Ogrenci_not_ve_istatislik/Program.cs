Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Clear();
Console.WriteLine("\t\t\tOgrenci Istatislik ve Not Sistemi");
Console.WriteLine("\t\t\tProgramina Hosgeldiniz");
Console.WriteLine("\t\t\tDevam etmek icin bir tusa basiniz");
Console.ReadKey();


List<string> ogrenciAdi = new List<string>();
List<double> ogrenciNotu = new List<double>();
double toplam = 0;

while (true)
{
        Console.Clear();
        Console.WriteLine("\t\t\tOgrenci adı giriniz:");
        Console.Write("\t\t\t");
        string ogrenciAdiGir = Console.ReadLine();
        // if(ogrenciAdiGir == "cikis")
        //     break;
        ogrenciAdi.Add(ogrenciAdiGir);
        Console.WriteLine("\t\t\tOgrenci notu giriniz:");
        Console.Write("\t\t\t");
        if (!double.TryParse(Console.ReadLine(), out double ogrenciNotuGir))
        {
            Console.WriteLine("\t\t\tHatali Giris Yaptiniz Tekrar Deneyiniz");
            continue;
        }

        toplam += ogrenciNotuGir;
        ogrenciNotu.Add(ogrenciNotuGir);
        Console.WriteLine("\t\t\tCikmak icin Q tusuna basiniz");
        Console.WriteLine("\t\t\tDevam etmek icin bir tusa basiniz");
        // Console.ReadLine();
        ConsoleKeyInfo basilanTus = Console.ReadKey(true);
        if (basilanTus.Key == ConsoleKey.Q)
            break;
        
}
double ortalama = 0;
ortalama = toplam / ogrenciAdi.Count;
Console.WriteLine($"\nOgrenci Not Ortalamsi: {ortalama}");
double enYuksekNot,enDusukNot;
string enBasariliKisi, enBasarisizKisi;
enYuksekNot = ogrenciNotu[0];
enBasariliKisi = ogrenciAdi[0];
enDusukNot = ogrenciNotu[0];
enBasarisizKisi = ogrenciAdi[0];
for (int i=1; i < ogrenciNotu.Count; i++)
{
    if(ogrenciNotu[i] > enYuksekNot)
    {
        enYuksekNot = ogrenciNotu[i];
        enBasariliKisi = ogrenciAdi[i];
    }
    if(ogrenciNotu[i] < enDusukNot)
    {
        enDusukNot = ogrenciNotu[i];
        enBasarisizKisi = ogrenciAdi[i];
    }
}
Console.WriteLine($"En Yuksek Not: {enYuksekNot} Ogrenci: {enBasariliKisi}");
Console.WriteLine($"En Dusuk Not: {enDusukNot} Ogrenci: {enBasarisizKisi}");
for (int j = 0; j < ogrenciNotu.Count; j++)
{
    if (ogrenciNotu[j] > ortalama)
    {
        Console.WriteLine($"Ortalama Ustu Not Alan Ogrenci: {ogrenciAdi[j]} Notu: {ogrenciNotu[j]}");
    }
}