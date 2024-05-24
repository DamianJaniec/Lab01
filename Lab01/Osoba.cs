namespace Lab01
{
    class Osoba
    {
        private string[] posiadaneSamochody;
        private string imie;
        private string nazwisko;
        private string adresZamieszkania;
        private int iloscSamochodow = 0;

        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }
        public string AdresZamieszkania
        {
            get { return adresZamieszkania; }
            set { nazwisko = value; }
        }

        public Osoba()
        {
            imie = "bezimienny";
            nazwisko = "brak";
            adresZamieszkania = "brak";
            iloscSamochodow = 0;
            
            posiadaneSamochody = new string[3];
        }
        public Osoba(string _imie, string _nazwisko, string _adresZamieszkania, int _iloscSamochodow)
        {
            imie = _imie;
            nazwisko= _nazwisko;
            adresZamieszkania = _adresZamieszkania;
            iloscSamochodow = _iloscSamochodow;

            posiadaneSamochody = new string[3];
        }
        public void DodajSamochod(Samochod s1)
        {
            if (iloscSamochodow > 2)
                Console.WriteLine("Brak miejsca");
            else
            {
                posiadaneSamochody[iloscSamochodow] = s1.NrRejestracyjny;
                iloscSamochodow++;
            }
        }
        public void UsunSamochod(string nr)
        {
            if(iloscSamochodow>0)
            {
                for (int i=0; i<posiadaneSamochody.Length; i++)
                {
                    if (nr == posiadaneSamochody[i])
                        posiadaneSamochody[i] = null;
                }
            }
            else
                Console.WriteLine("nie ma aut");
        }
        public void WypiszInfo()
        {
            Console.WriteLine($"\n\nImie: {imie}");
            foreach (string tmp in  posiadaneSamochody)
            {
                if (tmp != null)
                    Console.WriteLine($"Posiadany samochod o numerze: {tmp}");
            }
        }
    }
}
