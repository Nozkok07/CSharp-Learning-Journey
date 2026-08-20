namespace GuvenliBankaHesabiYonetimi;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string tl = "₺";
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Clear();
        BankaHesabi hesap = new BankaHesabi();
        hesap.HesapSahibi = "Nebi";
        while (true)
        {
            Console.WriteLine("Nozkok Bankasina Hosgeldiniz");
            Console.WriteLine("Devam etmek icin bir tusa basiniz");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(hesap.HesapSahibi +" Hosgeldiniz");
            Console.WriteLine("Lutfen yapmak istediginiz islemi seciniz");
            Console.WriteLine("1-Para Yatir");
            Console.WriteLine("2-Para Cek");
            Console.WriteLine("3-Bakiye Sorgula");
            Console.WriteLine("4-Cikis Yap");
            bool secim=int.TryParse(Console.ReadLine(),out int secim1);
            if (!secim || secim1 < 1 || secim1 > 4)
            {
                Console.Clear();
                Console.WriteLine("Hatali secim yaptiniz");
                Console.WriteLine("Lutfen tekrar deneyiniz");
                continue;
            }

            switch (secim1)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Para Yatir");
                    Console.WriteLine($"Yatirilacak miktari giriniz : {tl}");
                    hesap.ParaYatir(decimal.TryParse(Console.ReadLine(),out decimal miktar) ? miktar : 0);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Para Cek");
                    Console.WriteLine($"Cekilecek miktari giriniz : {tl}");
                    hesap.ParaCek(decimal.TryParse(Console.ReadLine(),out miktar) ? miktar : 0);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    hesap.BakiyeSorgula();
                    Console.ReadKey();
                    break;
                case 4:
                    return;
            }
        }
    }
}