namespace Lab01
{
    class Garaz
    {
        private int pojemnosc; //ile samochodow MOZE zmiescic ten konkretny garaz
        private int liczbaGarazowanychSamochodow; //ile lacznie JEST w tym garazu
        private string adres; //jakas zmienna dla beki

        //private Stack<Samochod> samochodyGarazowane = new Stack<Samochod>();
        //jednak nie tak trza zrobić xDDDD

        private Samochod[] samochodyGarazowane;

        public string Adres
        {
            get { return adres; } 
            set {  adres = value; }
        }
        public int Pojemnosc
        {
            get { return pojemnosc; }
            set { 
                pojemnosc = value;
                samochodyGarazowane = new Samochod[pojemnosc];
            }
        }


        public Garaz()
        {
            adres = "nieznany";
            pojemnosc = 0;
            liczbaGarazowanychSamochodow = 0;
            samochodyGarazowane = null;
            

        }
        public Garaz(string _adres, int _pojemnosc)
        {
            adres = _adres;
            pojemnosc = _pojemnosc;
            liczbaGarazowanychSamochodow = 0;
            samochodyGarazowane = new Samochod[pojemnosc];
        }
        public void WprowadzSamochod(Samochod s1)
        {
            //samochodyGarazowane.Push(s1);
            //jednak robimy na tablicy a nie na stosie xdd

            /*for (int i =0; i<samochodyGarazowane.Length; i++)
            {
                if (samochodyGarazowane[i] == null)
                {
                    samochodyGarazowane[i] = s1;
                    break;
                }
            }//wpiszemy samochod do pierwszego wolnego miejsca
            */ 
            //tak też nie robimy xdd
            //if(samochodyGarazowane != null)
            if(liczbaGarazowanychSamochodow+1>pojemnosc)
            {
                Console.WriteLine("Garaż zapełniony wieśniaku, nie można dodać samochodu");
            }
            else
            {
                samochodyGarazowane[liczbaGarazowanychSamochodow] = s1;
                liczbaGarazowanychSamochodow += 1;
                Console.WriteLine("Pomyślnie dodano Samochod :)");
            }
        }
        public Samochod WyprowadzSamochod()
        {
            /*if (samochodyGarazowane.Any()) 
            {
                Samochod s1 = samochodyGarazowane.Peek();
                samochodyGarazowane.Pop();
                return s1;

            }*/
            if (liczbaGarazowanychSamochodow >= 1)
            {
                liczbaGarazowanychSamochodow -= 1;
                Samochod s1 = samochodyGarazowane[liczbaGarazowanychSamochodow];
                samochodyGarazowane[liczbaGarazowanychSamochodow] = null;
                return s1;
            }

            return null;
            //na razie dam zeby zwracal cokolwiek, bo wypierdala bledy chujek

        }
        public void WypiszInfo()
        {
            if (liczbaGarazowanychSamochodow>=1)
            {
                Console.WriteLine("Wypisuje wszystkie informacje o Samochodach w garazu");
                foreach (Samochod tmp in samochodyGarazowane)
                    if (tmp != null)
                        tmp.WypiszInfo();

            }
            else
                Console.WriteLine("Nie ma aut do wypisania");
        }
    }
}
