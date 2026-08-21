namespace MiniFootbolsimulator;

public class Takim
{
    public string TakimAdi;
    public int HucumGucu;
    public int SavunmaGucu;
    private int puan;
    private int atilanGol;
    private int yenilenGol;

    public void IstatistikleriGoster()
    {
        Console.WriteLine($"\t\t\tTakim adi: {TakimAdi}");
        Console.WriteLine($"\t\t\tGuncel puan : {puan}");
        Console.WriteLine($"\t\t\tAtilan gol: {atilanGol}");
        Console.WriteLine($"\t\t\tYenilen gol: {yenilenGol}");
        int average=atilanGol-yenilenGol;
        Console.WriteLine($"\t\t\tAverage : {average}");
    }

    public void MacYap(Takim rakip)
    {
        
        Random rnd = new Random();
        int evSahibiSans=rnd.Next(0, 40);
        int rakipSans=rnd.Next(0, 40);
        int evGol=0, rakipGol=0;
        int evSahibiPerformans=this.HucumGucu+evSahibiSans-rakip.SavunmaGucu;
        int rakipPerformans=rakip.HucumGucu+rakipSans-this.SavunmaGucu;
        if (evSahibiPerformans > rakipPerformans)
        {
            evGol=rnd.Next(0, 5);
            rakipGol=rnd.Next(0, 2);
        }
        else if (evSahibiPerformans < rakipPerformans)
        {
            rakipGol=rnd.Next(0, 5);
            evGol=rnd.Next(0, 2);
        }
        else if (evSahibiPerformans == rakipPerformans)
        {
            int beraberlikGolu = rnd.Next(0, 3);
            rakipGol = beraberlikGolu;
            evGol = beraberlikGolu;
        }
        // rnd.Next(0,6);
        // evGol=this.HucumGucu+rnd.Next(0,6);
        // rakipGol=rakip.HucumGucu+rnd.Next(0,6);
        // this.HucumGucu=evGol;
        // rakip.HucumGucu=rakipGol;
        Console.WriteLine($"{this.TakimAdi}{evGol} - {rakipGol}{rakip.TakimAdi}");
        this.atilanGol += evGol;
        this.yenilenGol += rakipGol;
        rakip.atilanGol += rakipGol;
        rakip.yenilenGol += evGol;
        if (evGol > rakipGol)
        {
            this.puan += 3;
        }
        else if(evGol < rakipGol)
        {
            rakip.puan += 3;
            
        }
        else
        {
            this.puan += 1;
            rakip.puan += 1;
        }
    }
}