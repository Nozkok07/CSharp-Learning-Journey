namespace BorsaVeHalkaArzSistemi;

public class CelikSirketi:Sirket
{
    private int yillikUretimTon;
    public CelikSirketi(string sirket, decimal hisse,int yillikUretim) : base(sirket, hisse)
    {
        yillikUretimTon=yillikUretim;
    }

    public override void BilgiGoster()
    {
        base.BilgiGoster();
        Console.WriteLine($"Yillik Uretim : {yillikUretimTon} TON");
    }
}