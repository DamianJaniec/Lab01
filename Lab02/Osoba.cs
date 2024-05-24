namespace Lab02
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected string dataUrodzenia;
        
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
        public string DataUrodzenia
        {
            get { return dataUrodzenia; }
            set { dataUrodzenia = value; }
        }


        public Osoba(string _imie, string _nazwisko, string _dataUrodzenia)
        {
            imie = _imie;
            nazwisko = _nazwisko;
            dataUrodzenia = _dataUrodzenia;
        }
        public Osoba()
        {
            imie = "brak";
            nazwisko = "brak";
            dataUrodzenia = "brak";
        }
        public virtual void WypiszInfo()
        {
            Console.WriteLine($"{imie} {nazwisko} {dataUrodzenia}");
        }
    }
}
