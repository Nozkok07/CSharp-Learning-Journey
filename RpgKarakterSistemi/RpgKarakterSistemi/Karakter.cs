namespace RpgKarakterSistemi;

public class Karakter
{
    public string isim;
    private int _can;
    public int SaldiriGucu;
    public static int ToplamKarakterSayisi;
    public  Karakter(string ad, int can,int saldirigucu1)
    {
       isim=ad;
       SaldiriGucu=saldirigucu1;
       Can=can;
       ToplamKarakterSayisi++;
    }
    public virtual void HasarAl(int gelenHasar)
    {
        Can-=gelenHasar;
        if (Can < 0)
        {
            Can = 0;
        }
    }
    public int Can
    {
        set
        {
            if(value < 0)
                _can = 0;
            else if(value > 100)
                _can = 100;
            else 
                _can = value;
        }
        get{return _can;}
    }

    // public void HasarAl(int alinanHasar)
    // {
    //     Can-=alinanHasar;
    //     if (Can < 0)
    //     {
    //         Can = 0;
    //     }
    // }
    public void Saldir(Karakter hedef)
    {
        hedef.HasarAl(this.SaldiriGucu);
        
        
    }
    public virtual void BilgiGoster()
    {
        Console.WriteLine($"İsim :  {isim}");
        Console.WriteLine($"Can :  {Can}");
        Console.WriteLine($"Saldiri Gucu :  {SaldiriGucu}");
    }
}