using Lab01;

class Program
{
    public static void Zadanie1()
    {
        /*
       Samochod s = new Samochod();
       s.Marka = "nigga car";
       Console.WriteLine(s.Marka);
       Console.WriteLine(Samochod.ilosc_samochodow); //*/
        Samochod s1 = new Samochod();
        s1.WypiszInfo(); //wypisuje pusty booo.... nie danych przeciez xddd

        s1.Marka = "Fiat";
        s1.Model = "126p";
        s1.IloscDrzwi = 2;
        s1.PojemnoscSilnika = 650;
        s1.SrednieSpalanie = 6.0;
        s1.WypiszInfo();


        Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6);
        s2.WypiszInfo();
        double kosztPrzejazdu = s2.CenaPaliwa(30.5, 4.85);
        Console.WriteLine("Koszt przejazdu: " + kosztPrzejazdu);
        Samochod.WypiszIloscSamochodow();
    }
    public static void Zadanie2() 
    {
        Samochod s1 = new Samochod("Fiat", "126p", 2, 650, 6.0);
        Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6);
        Garaz g1 = new Garaz();
        g1.Adres = "ul. Garażowa 1";
        g1.Pojemnosc = 1;
        Garaz g2 = new Garaz("ul. Garażowa 2", 2);
        g1.WprowadzSamochod(s1);
        g1.WypiszInfo(); //pokaze info o 1 aucie
        g1.WprowadzSamochod(s2); //powinno wypierdolic, ze jest przepolniony
        g2.WprowadzSamochod(s2); //tutaj dodaje pierwszy
        g2.WprowadzSamochod(s1); //tutaj dodaje drugi
        g2.WypiszInfo(); //pokaze info o 2 autach

        g2.WyprowadzSamochod(); //wypierdala z butow jedno auto
        g2.WypiszInfo(); //pokaze jedno auto

        g2.WyprowadzSamochod(); //wypierdala z butow ostatnie auto
        g2.WyprowadzSamochod(); //nic nie moze zrobic bo jest wiesniakiem skonczonym
    }
    static void Main()
    {
        //Zadanie1();
        Zadanie2();



    }
}
/*Pytania do Podrazy
    1.O co chodzi z value przy set'cie i get'cie
        jeżeli Value to dostarczony parametr to czy mogę
        zrobić więcej dostarczonych parametrów?
    2.Jakim kurwa cudem te pliki są połączone
        W którym miejscu są podlinkowane

*/
