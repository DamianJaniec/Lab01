using System.Collections.Generic; 
namespace Lab02
{
    class Student:Osoba
    {
        private int rok;
        private int grupa;
        private int nrIndeksu;

        List<Ocena> ocenaLista = new List<Ocena>();

        public int Rok
        {
            get { return rok; }
            set { rok = value; }
        }
        public int Grupa
        {
            get { return grupa; }
            set { grupa = value; }
        }
        public int NrIndeksu
        {
            get { return nrIndeksu; }
            set { nrIndeksu = value; }
        }
        public Student(
            string _imie, string _nazwisko, string _dataUrodzin,
            int _rok, int _grupa, int _nrIndeksu
            )
        {
            imie = _imie;
            nazwisko = _nazwisko;
            dataUrodzenia = _dataUrodzin;
            rok = _rok;
            grupa = _grupa;
            nrIndeksu= _nrIndeksu;
        }
        public Student()
        {
            imie = "brak";
            nazwisko = "brak";
            dataUrodzenia = "brak";
            rok = 0;
            grupa = 0;
            nrIndeksu = 0;
        }
        public override void WypiszInfo()
        {
            Console.WriteLine($"{imie} {nazwisko}, urodzony: {dataUrodzenia} \n" +
                $"jest na {rok} roku, w grupie {grupa} oraz ma indeks {nrIndeksu}");
            Console.WriteLine("\n");
            WypiszOceny();
        }
        public void DodajOcene(
            string _nazwaPrzedmiotu, string _data, double _ocena)
        {
            ocenaLista.Add(new Ocena(_nazwaPrzedmiotu,_data,_ocena));
        }
        public void WypiszOceny()
        {
            foreach (Ocena tmp in ocenaLista)
            {
                tmp.WypiszInfo();
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }
        public void WypiszOceny(string _nazwaPrzedmiotu)
        {
            foreach (Ocena tmp in ocenaLista)
            {
                if (tmp.NazwaPrzedmiotu == _nazwaPrzedmiotu)
                {
                    tmp.WypiszInfo();
                    Console.WriteLine("\n");
                }
            }
            Console.WriteLine("\n\n");
        }
        public void UsunOcene(
            string _nazwaPrzedmiotu, string _data, double _ocena
            )
        {
            for (int i=0; i<ocenaLista.Count; i++) //jezeli nie ma elementow, petla sie nie wykona //gorzej jakby lista wgl nie istniała, to wtedy ocenyLista.Count wywali błąd xddd
            {
                if(
                    ocenaLista[i].NazwaPrzedmiotu == _nazwaPrzedmiotu &&
                    ocenaLista[i].Data == _data                       &&
                    ocenaLista[i].Wartosc == _ocena
                    )
                {
                    ocenaLista.RemoveAt(i);
                }


            }
               
            
        }
        public void UsunOceny(string _nazwaPrzedmiotu)
        {
            for (int i = 0; i < ocenaLista.Count; i++)
            {
                if (ocenaLista[i].NazwaPrzedmiotu == _nazwaPrzedmiotu)
                {
                    ocenaLista.RemoveAt(i);
                    i -= 1; //mniejsce obiektow w liscie przesowa sie o 1
                }
            }
        }
        public void UsunOceny()
        {
            ocenaLista.Clear();
        }
    }
}
