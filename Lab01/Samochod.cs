public class Samochod
{

    private string marka;
    private string model;
    private int iloscDrzwi;
    private int pojemnoscSilnika;
    private double srednieSpalanie; //zmienne

    public static int ilosc_samochodow = 0;


    public string Marka //funkcje, metody - jak zwal, tak ruchal wojtka pies
    {
        get { return marka; }
        set { marka = value; }
    }
    public string Model
    {  
        get { return model; } 
        set { model = value; } 
    }
    public int IloscDrzwi
    {
        get { return iloscDrzwi; }
        set { iloscDrzwi = value; }
    }
    public int PojemnoscSilnika
    {
        get { return pojemnoscSilnika; }
        set { pojemnoscSilnika = value; }
    }
    public double SrednieSpalanie
    {
        get { return srednieSpalanie; }
        set { srednieSpalanie = value;}
    }
    public Samochod()
    {
        ilosc_samochodow += 1;
    }
    public Samochod(string _marka,string _model,int _iloscDrzwi,int _pojemnoscSilnika,double _srednieSpalanie)
    {
        ilosc_samochodow += 1;
    }
}