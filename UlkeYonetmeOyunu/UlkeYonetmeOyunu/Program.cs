namespace UlkeYonetmeOyunu;

class Program
{
    static void Main(string[] args)
    {
        Ulke yeniUlke = new Ulke("Osmanli",1000);
        Ulke yeniUlke1 = new Ulke("Fransa",800);
        Ulke yeniUlke2 = new Ulke("Ingiltere",700);
        Ulke yeniUlke3 = new Ulke("Rusya",500);
        yeniUlke.VergiTopla();
        Console.WriteLine($"Dünyadaki toplam ülke sayısı: {Ulke.ToplamUlkeSayisi}");
    }
}