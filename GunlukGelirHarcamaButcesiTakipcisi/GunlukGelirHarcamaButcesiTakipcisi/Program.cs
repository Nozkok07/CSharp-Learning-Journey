Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Clear();

string tl = "₺";

Console.WriteLine("\t\t\tGelir Harcama Butcesi Takipcisi");
Console.WriteLine("\t\t\tProgramina Hosgeldiniz");
Console.Write("\t\t\tDevam etmek icin bir tusa basiniz");
Console.ReadKey();
Console.Clear();
Console.WriteLine("\t\t\tButcenizi giriniz");
Console.Write($"\t\t\t {tl}");
if (!double.TryParse(Console.ReadLine(), out double butce))
{
    Console.WriteLine($"\t\t\tLutfen bir tutar giriniz {tl}");
}

List<string> harcamaAdi= new List<string>();
List<double> harcamaTutari = new List<double>();


while (butce > 0)
{
    Console.Clear();
    Console.WriteLine($"\t\t\tKalan butceniz {tl}{butce}");
    Console.WriteLine("\t\t\tHarcama adi giriniz");
    Console.Write("\t\t\t");
    string girilenAd = Console.ReadLine();
    Console.WriteLine("\t\t\tLutfen harcama tutari giriniz");
    Console.Write($"\t\t\t{tl}");
    bool tutar = double.TryParse(Console.ReadLine(), out double tutar1);
    if (!tutar || tutar1 < 0 || tutar1 > butce)
    {
        Console.WriteLine("\t\t\tLutfen harcama tutari 0 den buyuk ve butce den kucuk olmalidir");
        Console.WriteLine("\t\t\tTekrar deneyiniz");
        continue;
    }
    else if (tutar1 == 0)
        break;
    harcamaAdi.Add(girilenAd);
    harcamaTutari.Add(tutar1);
    butce -= tutar1;
}
Console.Clear();
for (int i = 0; i < harcamaAdi.Count; i++)
{
    Console.WriteLine($"Harcama adi : {harcamaAdi[i]}");
    Console.WriteLine($"Harcama tutari : {tl}{harcamaTutari[i]}");
}
Console.WriteLine($"\t\t\tKalan butceniz {tl}{butce}");