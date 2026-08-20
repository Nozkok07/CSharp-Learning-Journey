namespace GuvenliBankaHesabiYonetimi;

public class BankaHesabi
{
    
    private decimal Bakiye;
    public string HesapSahibi;

    public void ParaYatir (decimal miktar)
    {
        if(miktar>0)
            Bakiye += miktar;
        else if(miktar<0)
            Console.WriteLine("Negatif Para Yatiramazsiniz");
    }
    public void ParaCek (decimal miktar)
    {
        if(miktar>0 && miktar<=Bakiye)
            Bakiye -= miktar;
        else if(miktar>Bakiye)
            Console.WriteLine("Yetersiz Bakiye");
    }

    public void BakiyeSorgula()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string tl = "₺";
        Console.WriteLine($"Bakiyeniz : {tl}{Bakiye}");
    }
}