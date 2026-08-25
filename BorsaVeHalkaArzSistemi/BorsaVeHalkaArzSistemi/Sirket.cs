namespace BorsaVeHalkaArzSistemi;

public class Sirket
{
    public string SirketAdi;
    private decimal _hisseFiyati;

    public static double BorsaEndeksi = 10000;
    

    public decimal HisseFiyati
    {
        get {return _hisseFiyati;}
        set
        {
            if (value < 0)
                _hisseFiyati = 0;
            else
                _hisseFiyati = value;
        }
    }

    public Sirket(string sirket,decimal hisse)
    {
        SirketAdi = sirket;
        HisseFiyati = hisse;
    }

    public virtual void BilgiGoster()
    {
        Console.WriteLine($"{SirketAdi}: {HisseFiyati}");
    }
    public void HalkaArzEt()
    {
        Console.WriteLine($"{SirketAdi} borsaya halka arz edildi.");
    }
}