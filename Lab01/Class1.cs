namespace Lab01
{
    class Garaz
    {
        private string adres;
        private int pojemnosc;
        private static int liczbaGarazowanychSamochodow;

        private Stack<Samochod> samochodyGarazowane = new Stack<Samochod>();

        public Garaz()
        {
            liczbaGarazowanychSamochodow += 1;
        }
        public Garaz(string _adres, int _pojemnosc)
        {
            adres = _adres;
            pojemnosc = _pojemnosc;
            liczbaGarazowanychSamochodow += 1;
        }
        public void WprowadzSamochod(Samochod s1)
        {
            samochodyGarazowane.Push(s1);
        }
        public Samochod WyprowadzSamochod()
        {
            Samochod s2 = new Samochod();
            if (samochodyGarazowane.Any()) 
            {
                Samochod s1 = samochodyGarazowane.Peek();
                samochodyGarazowane.Pop();
                return s1;

            }
            return s2; //na razie robimy takie gówno, aby działało xddd
            
            
        }
        public void WypiszInfo()
        {

        }
    }
}
