namespace PapaganBakimAsistani;

public class Papagan
{
    public string isim;
    private int _enerji;
    private int _mutluluk;

    public int Enerji
    {
        set
        {
            if(value < 0)
                _enerji = 0;
            if(value > 100)
                _enerji = 100;
            else _enerji = value;
        } get{ return _enerji; }
    }

    public int Mutluluk
    {
        set
        {
            if(value < 0)
                _mutluluk = 0;
            if(value > 100)
                _mutluluk = 100;
            else _mutluluk = value;
            
        }
        get { return _mutluluk; }
    }


    public Papagan(string isim1)
    {
        isim = isim1;
        _enerji = 100;
        _mutluluk = 100;
    }

    public void KabloKemir()
    {
        Console.WriteLine("Tehlike");
        Console.WriteLine("kablo Kemiriliyor");
        Mutluluk = Mutluluk + 20;
        Enerji = Enerji - 30;
        Console.ReadKey();
    }

    public void CekirdekVer()
    {
        Mutluluk = Mutluluk + 10;
        Enerji = Enerji + 15;
        Console.WriteLine("Cekirdek yeniyor");
        Console.ReadKey();
    }

    public void DurumGoster()
    {
        Console.WriteLine($"İsim : {isim}");
        Console.WriteLine($"Mutluluk : {_mutluluk}");
        Console.WriteLine($"Enerji : {_enerji}");
        Console.ReadKey();
    }
}