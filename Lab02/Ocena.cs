namespace Lab02
{
    class Ocena
    {
        private string nazwaPrzedmiotu;
        private string data;
        private double wartosc;

        public string NazwaPrzedmiotu
        {
            get { return nazwaPrzedmiotu; } 
            set { nazwaPrzedmiotu = value; }
        }
        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        public double Wartosc
        {
            get { return wartosc; }
            set { wartosc = value; }
        }
        public Ocena()
        {
            nazwaPrzedmiotu = "brak";
            data = "brak";
            wartosc = 0;
        }
        public Ocena(
            string _nazwaPrzedmiotu, string _data, double _wartosc)
        {
            nazwaPrzedmiotu = _nazwaPrzedmiotu;
            data = _data;
            wartosc = _wartosc;
        }
        public void WypiszInfo()
        {
            Console.WriteLine($"Przedmiot: {nazwaPrzedmiotu}, ocena: {wartosc}, z dnia {data}");
        }
    }
}
