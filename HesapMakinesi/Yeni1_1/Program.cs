Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Clear();
int secim;
int sayfa = 0;
int ilkSayi,ikinciSayi;
int kucukSayi;
int ebob = 1, ekok = 0;
int kacSayi = 0;
int  c;
while (true)
{
    Console.Clear();
    Console.WriteLine("\t\t\tHosheldiniz");
    Console.WriteLine("\t\t\t1- EBOB/EKOK");
    Console.WriteLine("\t\t\t2- FIBONACCI");
    Console.WriteLine("\t\t\t3- CIKIS");
    Console.WriteLine("\t\t\tBIR SECIM YAPINIZ");

    bool secim1 = int.TryParse(Console.ReadLine(), out secim);
    if (!secim1 || (secim > 3 || secim <= 0))
    {
        Console.WriteLine("Hatali Secim Yaptiniz");
        Console.ReadKey();
        continue;
    }

    switch (secim)
    {
        case 1:
            Console.WriteLine("\t\t\tIlk sayiyi giriniz");
            if (!int.TryParse(Console.ReadLine(), out ilkSayi))
                Console.WriteLine("\t\t\tHatali Giris Yaptiniz");
            Console.WriteLine("\t\t\tIkınci sayiyi giriniz");
            if (!int.TryParse(Console.ReadLine(), out ikinciSayi))
                Console.WriteLine("\t\t\tHatali Giris Yaptiniz");
            kucukSayi = Math.Min(ilkSayi, ikinciSayi);
            if (ilkSayi % kucukSayi == 0 && ikinciSayi % kucukSayi == 0)
                ebob = kucukSayi;
            ekok = ilkSayi * ikinciSayi / ebob;
            Console.WriteLine($"\n\n\t\t\tEBOB: {ebob}");
            Console.WriteLine($"\t\t\tEKOK: {ekok}");
            Console.ReadKey();
            break;
        case 2:
            Console.WriteLine("\n\n\t\t\tKac sayiyi bulmak istersiniz");
            if (!int.TryParse(Console.ReadLine(), out kacSayi))
                Console.WriteLine("\n\n\t\t\tHatali Giris Yaptiniz");
            int a = 0, b = 1;
            Console.Write($"\n\n\t\t\t{a} {b} ");
            for (int i = 2; i < kacSayi; i++)
            {
                c = a + b;
                Console.Write($"{c} ");
                a = b;
                b = c;
            }
            Console.ReadKey();
            break;
        case 3:
            Console.ReadKey();
            return;
            break;
    }
}