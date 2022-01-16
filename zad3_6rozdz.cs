using System;

namespace Rozdzial6_tak
{
    class Program
    {
       class Prostokat
        {
            private double dlugosc;
            private double szerokosc;
            // jak wykorzystuje pola wlasne klasy w metodzie
            //zamiast self.  jest this.  
            private double powierzchnia()
            {
                return this.dlugosc * this.szerokosc;
            }
            private double obwod()
            {
                return 2.0 * this.dlugosc + 2.0 * this.szerokosc;
            }
            //jak wyswietla to typ metody bedzie void
            public void Prezentuj()
            {//ReadLine to scanf, WriteLine to print
                Console.WriteLine("Pole prostokata ={0} a Obwod ={1}", this.powierzchnia(), this.obwod());
            }
            // konstruktor z argumentami przy tworzeniu obiektu nadaje odpowiednie wartosci
            // KONSTRUKTOR NIE MOZE BYC VOID, BO ZWRACA OBIEKT!!!!
            // KONSTRUKTOR TO JEST METODA O NAZWIE!!! KLASY!!!!
            //Konstruktor ustawia zmienne dla danego obiektu tylko raz
            //dzieki konsturktorowi, bo jest publiczny, moge korzystac z innych zmiennych krocej
            public Prostokat(double dlu, double szer)
            {
                this.dlugosc = dlu;
                this.szerokosc = szer;

            }

            public double wyswietl_pow()
            {
                return this.powierzchnia();
            }
        }
        //nazwy metod mala lotera, duze dla konstruktorow
            static void najwiekszy_prostokat(Prostokat [] tablica) // bo analizujemy obiekty z tablicy, a wyjdzie tylko najwiekszy
        {
            int pozycja = 0;
            double max = 0;
            for (int i = 0; i < 5; i++)
            {     
                if (max < tablica[i].wyswietl_pow())//trzeba stworzyc metode publiczna, ktora wykonuje metode prywatna
                {
                    max = tablica[i].wyswietl_pow();
                    pozycja = i;
                }
            }

            Console.WriteLine("Powierzchnia najwiekszego prostokata to {0} i jest pod indeksem {1}", max, pozycja);

        }

        static void Main()
        {
            Prostokat[] tab = new Prostokat[5];

            for(int i=0; i<5; i++)
            {
                tab[i] = new Prostokat(i+1, 2 * i+1);
            }
            foreach (Prostokat el in tab)
            {
                el.Prezentuj();
            }
            //modyfikator static to tworze raz i istnieje ciagle
            najwiekszy_prostokat(tab);
            
        }
    }
}


// tylko ta klasa, w ktorej zmienna zostala zadeklarowana moze uzywa private
