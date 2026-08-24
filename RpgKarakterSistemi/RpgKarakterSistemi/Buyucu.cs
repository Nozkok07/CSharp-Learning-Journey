namespace RpgKarakterSistemi;

public class Buyucu:Karakter
{
    private int _mana;
    

    public int Mana
    {
        get{return _mana;}
        set
        {
            if(value < 0)
                _mana = 0;
            if(value > 100)
                _mana = 100;
            else _mana = value;
        }
    }

    public void AtesTopuAt()
    {
        Mana = Mana - 20;
    }

    public Buyucu(string ad,int can,int saldiriGucu):base(ad,can,saldiriGucu)
    {
        Mana = 100;
    }
}