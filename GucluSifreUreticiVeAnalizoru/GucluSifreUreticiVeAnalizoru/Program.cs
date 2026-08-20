Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.Black;
Console.Clear();

static void SifreTest(string sifre)
{
    
    bool buyukVarMi = false,kucukVarMi = false,rakamVarMi = false,ozelVarMi = false;
    foreach (char sifreTest in sifre)
    {
        if (char.IsUpper(sifreTest))
            buyukVarMi = true;
        if (char.IsLower(sifreTest))
            kucukVarMi = true;
        if (char.IsDigit(sifreTest))
            rakamVarMi = true;
        if (!char.IsLetterOrDigit(sifreTest))
            ozelVarMi = true;
    }

    int puan=0;
    if (buyukVarMi)
        puan++;
    if (kucukVarMi)
        puan++;
    if (rakamVarMi)
        puan++;
    if (ozelVarMi)
        puan++;
    if(sifre.Length>=8)
        puan++;
    if (puan == 5)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("COK GUCLU SİFRE");
        Console.ResetColor();
    }
    else if (puan ==3||puan==4)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("ORTA GUCLU SİFRE");
        Console.ResetColor();
    }
    else if(puan==2||puan==1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ZAYIF SİFRE");
        Console.ResetColor();
    }
}




Console.WriteLine("Sifre uretme programina hosgeldiniz");
Console.WriteLine("Devam etmek icin bir tusa basiniz");
Console.ReadKey();
Console.Clear();
while (true)
{
    Console.Clear();
    int secim1;
    bool secim2;
    Console.WriteLine("1-Sifre uretme ");
    Console.WriteLine("2-Sifre gucunu test etme ");
    Console.WriteLine("3-cikis ");
    secim2 = int.TryParse(Console.ReadLine(), out secim1);
    if (!secim2 || secim1 > 3 || secim1 < 1)
    {
        Console.WriteLine("Hatali secim yaptiniz lutfen tekrar deneyiniz");
        continue;
    }
    switch (secim1)
    {
        case 1:
            Console.WriteLine("Sifre uretme");
            Console.WriteLine("Sifre kac karakteli olsun?");
            if (!int.TryParse(Console.ReadLine(), out int uzunluk))
            {
                Console.WriteLine("Hatali giris yaptiniz lutfen tekrar deneyiniz");
                continue;
            }
            string karakterHavuzu = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";
            string yeniSifre = "";
            Random rastgele = new Random();
            for (int i = 0; i<uzunluk; i++)
            {
                int rastgeleIndex = rastgele.Next(0,karakterHavuzu.Length);
                yeniSifre += karakterHavuzu[rastgeleIndex];
            }
            Console.WriteLine("Yeni sifreniz : " + yeniSifre);
            Console.ReadKey();
            break;
        case 2:
            Console.WriteLine("Sifre gucunu test etme");
            Console.WriteLine("Bir sifre giriniz ");
            string girilenSifre = Console.ReadLine();
            SifreTest(girilenSifre);
            Console.ReadKey();
            break;
        case 3:
            Console.WriteLine("Programdan cikiliyorsunuz");
            return;
    }
}