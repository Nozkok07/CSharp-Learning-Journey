namespace BorsaVeHalkaArzSistemi;

public class EnerjiSirketi:Sirket
{
    private int _uretim;

    public int UretimKapasitesi {get; set;}
    
    public EnerjiSirketi(string sirket,decimal hisse,int uretim):base(sirket,hisse)
    {
        UretimKapasitesi = uretim;
    }

    public void DevletIhalesiKazan()
    {
        HisseFiyati = HisseFiyati*1.1m;
        Sirket.BorsaEndeksi += 50;
        Console.WriteLine("İlhale kazanıldı.");
    }
}