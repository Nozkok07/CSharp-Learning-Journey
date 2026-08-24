namespace RpgKarakterSistemi;

class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor=ConsoleColor.DarkBlue;
        Console.ForegroundColor=ConsoleColor.Yellow;
        Console.Clear();
        Buyucu b1 = new Buyucu("Barney", 100, 25);
        Savasci s1 = new Savasci("KralArthur", 100, 25,2);
        Console.WriteLine("Savas basliyor :");
        while (b1.Can>0 && s1.Can>0)
        {
            Console.Clear();
            b1.BilgiGoster();
            s1.BilgiGoster();
            Thread.Sleep(1000);
            b1.AtesTopuAt();
            b1.Saldir(s1);
            s1.KalkanKullan();
            s1.Saldir(b1);
            

        }

        if (b1.Can > 0)
        {
            Console.Clear();
            Console.WriteLine($"Savasin kazanani Barney");
            Console.WriteLine("Savas bitti");
        }
        else if (s1.Can > 0)
        {
            Console.Clear();
            Console.WriteLine($"Savasin kazanani Kral Arthur");
            Console.WriteLine("Savas bitti");
        }
    }
}