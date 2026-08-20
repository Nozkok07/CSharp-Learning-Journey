namespace RPG_KarakterArenaSimulasyonu;
using System.Threading;
class Program
{
    
    static void Main(string[] args)
    {
        
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        Karakter cuce = new Karakter();
        Karakter elf = new Karakter();
        cuce.ad = "Gimli";
        elf.ad = "Legolas";
        cuce.CaniAyarla(120);
        elf.CaniAyarla(100);
        cuce.zirh = 30;
        cuce.saldiriGucu=25;
        elf.saldiriGucu=35;
        elf.zirh = 15;
        cuce.ZirhArttir(3);
        elf.ZirhArttir(1);
        cuce.saldiriGucuArttir(2);
        elf.saldiriGucuArttir(3);
        while (cuce.CaniGetir() > 0 && elf.CaniGetir() > 0)
        {
            Console.Clear();
            Console.WriteLine("Savas Basliyor");
            Console.WriteLine($"Gimli'nin cani : {cuce.CaniGetir()}");
            Console.WriteLine($"Legolas'in cani : {elf.CaniGetir()}");
            Console.WriteLine($"Gimli'nin zirhi : {cuce.zirhiGetir()}");
            Console.WriteLine($"Legolas'in zirhi : {elf.zirhiGetir()}");
            Console.WriteLine($"Gimli'nin zirh artma miktari : 3");
            Console.WriteLine($"Legolas'in zirh artma miktari : 1");
            Console.WriteLine($"Gimli'nin saldiri gucu artma miktari : 2");
            Console.WriteLine($"Legolas'in saldiri gucu miktari : 3");
            
            cuce.Saldir(elf);
            Console.WriteLine($"Gimli saldirdi Legolas'in kalan cani : {elf.CaniGetir()}");
            if (elf.CaniGetir() > 0)
            {
                elf.Saldir(cuce);
                Console.WriteLine($"Legolas saldirdi Gimli'nin kalan cani : {cuce.CaniGetir()}");
            }
            Thread.Sleep(1000);
            
        }

        if (cuce.CaniGetir() > 0)
        {
            Console.WriteLine($"Savasin kazanani : {cuce.ad}");
            Console.WriteLine("Savas bitti");
        }
        else if (elf.CaniGetir() > 0)
        {
            Console.WriteLine($"Savasin kazanani : {elf.ad}");
            Console.WriteLine("Savas bitti");
        }
        
    }
}