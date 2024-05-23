public class Samochod
{

    private string marka;
    private string model;
    private int iloscDrzwi;
    private int pojemnoscSilnika;
    private double srednieSpalanie; //zmienne

    public static int ilosc_samochodow = 0;


    public string Marka //funckje, ale troche dziwne
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
    public Samochod() //konstruktory dwa
    {
        ilosc_samochodow += 1;
    }
    public Samochod(string _marka,string _model,int _iloscDrzwi,int _pojemnoscSilnika,double _srednieSpalanie)
    {
        marka = _marka;
        model = _model;
        ilosc_samochodow = _iloscDrzwi;
        pojemnoscSilnika = _pojemnoscSilnika;
        srednieSpalanie = _srednieSpalanie;
        
        
        ilosc_samochodow += 1;
    }
    public double ObliczSpalanie(double trasa)  //zwyczajne ludzkie, normalne metody
        //zakladamy ze uzytkownik nie jest debilem, i nie robi mi pod gorke - trase podaje w kilometrach
    {
        double spalanieNaKm = srednieSpalanie / 100; //spalanie na 1km
        double spalanieLaczne = spalanieNaKm * trasa;
        
        return spalanieLaczne;
    }
    public double CenaPaliwa(double trasa,double cena)
    {
        double spalanie = ObliczSpalanie(trasa);
        double suma = spalanie * cena;
        return suma;
    }
    public void WypiszInfo()
    {
        Console.WriteLine($"Samochod numer: {ilosc_samochodow}");
        Console.WriteLine($"Marka: {marka}");
        Console.WriteLine($"Model: {model}");
        Console.WriteLine($"Ilość Drzwi: {iloscDrzwi}");
        Console.WriteLine($"Pojemność Silnika: {pojemnoscSilnika}");
        Console.WriteLine($"Średnie Spalanie: {SrednieSpalanie}");
        Console.WriteLine("\n\n");
    }
    public static void WypiszIloscSamochodow()
    {
        Console.WriteLine($"W bazie danych jest {ilosc_samochodow} samochody/ów");
    }
}