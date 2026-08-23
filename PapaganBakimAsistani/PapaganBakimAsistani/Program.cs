namespace PapaganBakimAsistani;

class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Clear();
        Console.Write("Papagana isim veriniz : ");
        string isim1 = Console.ReadLine();
        Papagan p1 = new Papagan(isim1);
        while (true)
        {
            
            Console.Clear();
            Console.WriteLine("1-Kablo kemir");
            Console.WriteLine("2-Cekirdek ver");
            Console.WriteLine("3-Durum Goster");
            Console.WriteLine("4-Cikis");
            Console.WriteLine("Secim yapiniz:");
            bool secim=int.TryParse(Console.ReadLine(),out int secim1);
            if (!secim || secim1 < 1 || secim1 > 4)
            {
                Console.Clear();
                Console.WriteLine("Hatali tuslama yaptiniz");
                Console.WriteLine("Lutfen tekrar deneyiniz");
            }
            
            switch (secim1)
            {
                case 1:
                    Console.Clear();
                    p1.KabloKemir();
                    break;
                case 2:
                    Console.Clear();
                    p1.CekirdekVer();
                    break;
                case 3:
                    Console.Clear();
                    p1.DurumGoster();
                    break;
                case 4:
                    return;
            }
            
        }
    }
}