namespace RPG_KarakterArenaSimulasyonu;

public class Karakter
{
    private int can;
    public string ad;
    public int saldiriGucu;
    public int zirh;
    public int CaniGetir()
    {
        return can;
    }

    public void CaniAyarla(int baslangicCani)
    {
        can=baslangicCani;
    }
    public void HasarAl(int alinanHasar)
    {
        can-=alinanHasar;
        if (can < 0)
        {
            can = 0;
        }
    }
    public void Saldir(Karakter hedef)
    {
        int netHasar = this.saldiriGucu - hedef.zirh;
    
        // Net hasar 0'dan küçükse (yani zırh çok güçlüyse) hasar vermesin diye kontrol edebilirsin
        if (netHasar > 0)
        {
            // Hedefin private can değerini doğrudan değiştiremediğimiz için metodunu kullanıyoruz:
            hedef.HasarAl(netHasar); 
        }
    }

    public void ZirhArttir(int zirhArttirma)
    {
        zirh+=zirhArttirma;
    }

    public void saldiriGucuArttir(int saldiriGucuArttirma)
    {
        saldiriGucu+=saldiriGucuArttirma;
    }
    public int zirhiGetir()
    {
        return zirh;
    }
}