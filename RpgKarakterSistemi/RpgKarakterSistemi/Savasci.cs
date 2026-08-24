namespace RpgKarakterSistemi;

public class Savasci:Karakter
{
    public int EkstraZirh;

    public Savasci(string ad,int can,int saldiriGucu,int ekstraZirh):base(ad,can,saldiriGucu)
    {
        EkstraZirh=ekstraZirh;
    }
    public override void HasarAl(int gelenHasar)
    {
        int netHasar = gelenHasar - EkstraZirh;
        if (netHasar > 0)
            Can=Can-netHasar;
        
    }
    public void KalkanKullan()
    {
        Console.WriteLine("Kalkan Kullaniliyor");
    }
}