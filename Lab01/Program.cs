class Program
{
    static void Main()
    {
        Samochod s = new Samochod();
        s.Marka = "nigga car";
        Console.WriteLine(s.Marka);
        Console.WriteLine(Samochod.ilosc_samochodow);
    }
}
