using System.Runtime.CompilerServices;

namespace MiniFootbolsimulator;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();
        Takim evSahibi = new Takim();
        Takim deplasman = new Takim();
        while (true)
        {
            
            Console.Clear();
            Console.WriteLine("\t\t\tFutbol oyununa hosgeldiniz");
            Console.WriteLine("\t\t\tDevam etmek icin bir tusa basiniz");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\t\t\tTakimlar");
            Console.WriteLine("\t\t\tKarsilasmasi icin iki takim seciniz");
            Console.WriteLine("\t\t\t1-Real Madrid");
            Console.WriteLine("\t\t\t2-Barcelona");
            Console.WriteLine("\t\t\t3-Manchester United");
            Console.WriteLine("\t\t\t4-Liverpool");
            Console.WriteLine("\t\t\t5-Fenerbahce");
            Console.WriteLine("\t\t\t6-Galatasaray");
            Console.WriteLine("\t\t\t7-Bayern Munchen");
            Console.WriteLine("\t\t\t8-Borussia Dortmund");
            Console.WriteLine("\t\t\t9-Cikis");
            bool secim = int.TryParse(Console.ReadLine(),out int secim1);
            if (!secim || secim1 < 1 || secim1 > 9)
            {
                Console.Clear();
                Console.WriteLine("Hatali secim yaptiniz");
                Console.WriteLine("Lutfen tekrar deneyiniz");
                continue;
            }

            switch (secim1)
            {
                case 1:
                    evSahibi.TakimAdi="Real Madrid";
                    evSahibi.HucumGucu = 90;
                    evSahibi.SavunmaGucu = 80;
                    break;
                case 2:
                    evSahibi.TakimAdi="Barcelona";
                    evSahibi.HucumGucu = 95;
                    evSahibi.SavunmaGucu = 75;
                    break;
                case 3:
                    evSahibi.TakimAdi="Manchester United";
                    evSahibi.HucumGucu = 70;
                    evSahibi.SavunmaGucu = 60;
                    break;
                case 4:
                    evSahibi.TakimAdi="Liverpool";
                    evSahibi.HucumGucu = 75;
                    evSahibi.SavunmaGucu = 65;
                    break;
                case 5:
                    evSahibi.TakimAdi="Fenerbahce";
                    evSahibi.HucumGucu = 72;
                    evSahibi.SavunmaGucu = 60;
                    break;
                case 6:
                    evSahibi.TakimAdi="Galatasaray";
                    evSahibi.HucumGucu = 75;
                    evSahibi.SavunmaGucu = 60;
                    break;
                case 7:
                    evSahibi.TakimAdi="Bayern Munchen";
                    evSahibi.HucumGucu = 90;
                    evSahibi.SavunmaGucu = 85;
                    break;
                case 8:
                    evSahibi.TakimAdi="Borussia Dortmund";
                    evSahibi.HucumGucu = 70;
                    evSahibi.SavunmaGucu = 70;
                    break;
                case 9:
                    return;
            }
            Console.WriteLine("\t\t\tŞimdi ikinci takimi secebilirsiniz");
            bool secim2 = int.TryParse(Console.ReadLine(),out int secim3);
            if (!secim2 || secim3 < 1 || secim3 > 8)
            {
                Console.Clear();
                Console.WriteLine("Hatali secim yaptiniz");
                Console.WriteLine("Lutfen tekrar deneyiniz");
                continue;
            }
            switch (secim3)
            {
                case 1:
                    deplasman.TakimAdi="Real Madrid";
                    deplasman.HucumGucu = 90;
                    deplasman.SavunmaGucu = 80;
                    break;
                case 2:
                    deplasman.TakimAdi="Barcelona";
                    deplasman.HucumGucu = 95;
                    deplasman.SavunmaGucu = 75;
                    break;
                case 3:
                    deplasman.TakimAdi="Manchester United";
                    deplasman.HucumGucu = 70;
                    deplasman.SavunmaGucu = 60;
                    break;
                case 4:
                    deplasman.TakimAdi="Liverpool";
                    deplasman.HucumGucu = 75;
                    deplasman.SavunmaGucu = 65;
                    break;
                case 5:
                    deplasman.TakimAdi="Fenerbahce";
                    deplasman.HucumGucu = 72;
                    deplasman.SavunmaGucu = 60;
                    break;
                case 6:
                    deplasman.TakimAdi="Galatasaray";
                    deplasman.HucumGucu = 75;
                    deplasman.SavunmaGucu = 60;
                    break;
                case 7:
                    deplasman.TakimAdi="Bayern Munchen";
                    deplasman.HucumGucu = 90;
                    deplasman.SavunmaGucu = 85;
                    break;
                case 8:
                    deplasman.TakimAdi="Borussia Dortmund";
                    deplasman.HucumGucu = 70;
                    deplasman.SavunmaGucu = 70;
                    break;
            }
            Console.Clear();
            Console.WriteLine("\t\t\tMac Basliyor : \n");
            Thread.Sleep(1000);
            evSahibi.MacYap(deplasman);
            evSahibi.IstatistikleriGoster();
            deplasman.IstatistikleriGoster();
            Console.WriteLine("\t\t\tMenuye donmek icin bir tusa basiniz");
            Console.ReadKey();
        }
    }
}