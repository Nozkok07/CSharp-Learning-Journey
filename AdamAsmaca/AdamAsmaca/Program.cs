Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Clear();


static void MyMetod()
{
    List<string> Kelimeler = new List<string>();
    Kelimeler.Add("Apartman");
    Kelimeler.Add("Bozkir");
    Kelimeler.Add("Karadeniz");
    Kelimeler.Add("Alfabe");
    Kelimeler.Add("Spiderman");
    Kelimeler.Add("Lastik");
    Kelimeler.Add("Supurge");
    Kelimeler.Add("Sandalye");
    Kelimeler.Add("Klima");
    int i;
    
    Random rd = new Random();
    int randomIndex = rd.Next(Kelimeler.Count);
    string secilenKelime = Kelimeler[randomIndex].ToLower();
    char[] gizliEkran = new char[secilenKelime.Length];
    for (i=0; i < gizliEkran.Length; i++)
    {
        gizliEkran[i] = '_';
    }
    
    
    int can = 6;
    
    while (can>0)
    {
        Console.Clear();
        Console.Write("\t\t\t\t");
        foreach (char karakter in gizliEkran)
            Console.Write(karakter);
        Console.WriteLine();
        Console.WriteLine();
        
        bool harfbulundu = false;
        Console.WriteLine($"\t\t\t{can} Caniniz Kaldi");
        Console.Write("\t\t\tBir harf giriniz: ");
        Console.Write("");
        string girilenHarf = Console.ReadLine().ToLower();
            for (int j = 0; j < secilenKelime.Length; j++)
            {
                if (secilenKelime[j] == girilenHarf[0])
                {
                    harfbulundu = true;
                    gizliEkran[j] = girilenHarf[0];
                }
                
            }
            if (!harfbulundu)
                can--;
            bool altTire = false;
            for (int k = 0; k < gizliEkran.Length; k++) 
            {
                if (gizliEkran[k] == '_') 
                {
                    altTire = true; // Demek ki hala açılmamış harf var!
                    break; 
                }
            }
            if (altTire == false) 
            {
                Console.Clear();
                Console.WriteLine($"\n\n\t\t\tTEBRİKLER, KAZANDINIZ!");
                Console.WriteLine($"\t\t\tGizli Kelime: {secilenKelime}");
                break; // While döngüsünü tamamen kırıp oyunu bitirir.
            }
            
    }
    if (can == 0)
    {
        Console.WriteLine("Kaybettiniz");
        Console.WriteLine($"Kelimeniz : {secilenKelime}");
    }

}
MyMetod();



