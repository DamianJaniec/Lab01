namespace Lab02
{
    class Pilkarz:Osoba
    {
        protected string pozycja;
        protected string klub;
        protected int liczbaGoli;

        public string Pozycja
        { 
            get { return pozycja; } 
            set { pozycja = value; } 
        }
        public string Klub
        {
            get { return klub; } 
            set {  klub = value; }
        }
        public int LiczbaGoli
        {
            get { return liczbaGoli; }
            set { liczbaGoli = value; }
        }
        public Pilkarz()
        {
            imie = "brak";
            nazwisko = "brak";
            dataUrodzenia = "brak";
            pozycja = "brak";
            klub = "brak";
            liczbaGoli = 0;
        }
        public Pilkarz(
            string _imie, string _nazwisko, string _dataUrodzenia, string _pozycja, string _klub, int _liczbaGoli = 0)
        {
            imie = _imie;
            nazwisko = _nazwisko;
            dataUrodzenia = _dataUrodzenia;
            pozycja = _pozycja;
            klub = _klub;
            liczbaGoli = _liczbaGoli;
        }

        public virtual void StrzelGola()
        {
            liczbaGoli += 1;
        }
        public override void WypiszInfo()
        {
            Console.WriteLine($"{imie} {nazwisko}, urodzony: {dataUrodzenia} \n" +
                $"gra w klubie: {klub} na pozycji {pozycja} i ma na karcie {liczbaGoli} goli");
        }
    }
    class PilkarzReczny:Pilkarz
    {
        public PilkarzReczny(
            string _imie, string _nazwisko, string _dataUrodzenia, string _pozycja, string _klub, int _liczbaGoli = 0)
        {
            imie = _imie;
            nazwisko = _nazwisko;
            dataUrodzenia = _dataUrodzenia;
            pozycja = _pozycja;
            klub = _klub;
            liczbaGoli = _liczbaGoli;
        }
        public PilkarzReczny()
        {
            imie = "brak";
            nazwisko = "brak";
            dataUrodzenia = "brak";
            pozycja = "brak";
            klub = "brak";
            liczbaGoli = 0;
        }
        public override void StrzelGola()
        {
            base.StrzelGola();
        }
    }
    class PilkarzNozny:Pilkarz
    {
        public PilkarzNozny(
            string _imie, string _nazwisko, string _dataUrodzenia, string _pozycja, string _klub, int _liczbaGoli = 0)
        {
            imie = _imie;
            nazwisko = _nazwisko;
            dataUrodzenia = _dataUrodzenia;
            pozycja = _pozycja;
            klub = _klub;
            liczbaGoli = _liczbaGoli;
        }
        public PilkarzNozny()
        {
            imie = "brak";
            nazwisko = "brak";
            dataUrodzenia = "brak";
            pozycja = "brak";
            klub = "brak";
            liczbaGoli = 0;
        }
        public override void StrzelGola()
        {
            base.StrzelGola();
        }
    }
}

