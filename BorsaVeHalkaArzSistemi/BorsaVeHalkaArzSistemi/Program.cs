namespace BorsaVeHalkaArzSistemi;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();
        EnerjiSirketi e1 = new EnerjiSirketi("Ozkok Energies",100m,20);
        CelikSirketi c1 = new CelikSirketi("Ozkok Celik",77m,250);
        Console.WriteLine($"{e1.SirketAdi} Halka arz ediliyor");
        Console.WriteLine($"{c1.SirketAdi} Halka arz ediliyor");
        Thread.Sleep(1000);
        e1.DevletIhalesiKazan();
        Console.WriteLine();
        Thread.Sleep(1000);
        Console.WriteLine($"{e1.SirketAdi} Bilgileri :");
        e1.BilgiGoster();
        Console.WriteLine();
        Console.WriteLine($"{c1.SirketAdi} Bilgileri :");
        c1.BilgiGoster();
        Console.WriteLine();
        Thread.Sleep(1000);
        Console.WriteLine($"Piyasanin Genel Borsa Endeksi : {Sirket.BorsaEndeksi}");
    }
    
}