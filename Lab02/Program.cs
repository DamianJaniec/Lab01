namespace Lab02
{
    internal class Program
    {
        static void Zadanie1()
        {
            Osoba o = new Osoba("Adam", "Miś", "69.69.2069");
            Osoba o1 = new Student("Michał", "Kot", "21.37.2420", 2, 1, 12345);
            Osoba o2 = new Pilkarz("Mateusz", "Żbik", "10.08.1986", "oborńca", "FC Częstochowa");

            o.WypiszInfo();
            o1.WypiszInfo();
            o2.WypiszInfo();

            Student s = new Student("Krzysztof", "Jeż", "22.12.199", 2, 5, 54321);
            Pilkarz p = new Pilkarz("Piotr", "Kos", "14.09.1984", "napastnij", "Gówno twojej starej");

            Console.WriteLine("\n\n");

            s.WypiszInfo();
            p.WypiszInfo();

            Console.WriteLine("\n\n");

            ((Pilkarz)o2).StrzelGola();
            p.StrzelGola();
            p.StrzelGola();

            o2.WypiszInfo();
            p.WypiszInfo();
        }
        static void Zadanie2()
        {

            Osoba o2 = new Student("Michał", "Kot", "21.37.2420", 2, 1, 12345);
            Student s = new Student("Krzysztof", "Jeż", "22.12.199", 2, 5, 54321);

            ((Student)o2).DodajOcene("PO", "20.02.2011", 5.0);
            ((Student)o2).DodajOcene("Bazy Danych", "13.02.2011", 4.0);

            o2.WypiszInfo();

            s.DodajOcene("Bazy Danych", "01.05.2011", 5.0);
            s.DodajOcene("Dziekan chuj robi mi loda", "11.05.2011", 5.0);
            s.DodajOcene("Dziekan chuj robi mi loda", "02.04.2011", 4.5);

            s.WypiszInfo();

            s.UsunOcene("Dziekan chuj robi mi loda", "02.04.2011", 4.5);

            s.WypiszInfo();

            s.DodajOcene("Dziekan chuj robi mi loda", "02.04.2011", 4.5);

            s.WypiszInfo();

            s.UsunOceny("Dziekan chuj robi mi loda");

            s.WypiszInfo();

            s.DodajOcene("Dziekan chuj robi mi loda", "02.04.2011", 4.5);
            s.UsunOceny();

            s.WypiszInfo();



        }
        static void Zadanie3()
        {

        }
        static void Main()
        {
            //Zadanie1 ();
            //Zadanie2();
            Zadanie3();
        }
    }
}