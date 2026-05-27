using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Konsolowa_TablicaDwuWymiarowa
{
    internal class Działanie
    {
        public static int wiersze = 4;
        public static int kolumny = 4;

        public void Konfiguracja()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Konfiguracja" + '\n');
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Zmien ilość wierszy");
            Console.WriteLine("2. Zmien ilość kolumn");
            Console.WriteLine("3. Zmien ogólną wielkość (wiersze i kolumny te same)");
            Console.WriteLine("4. Wyczyść ustawienia");
            Console.WriteLine("0. Wróć");

            int wiadomosc = int.Parse(Console.ReadLine());
            OdczytajWiadomosc(wiadomosc);
        }
        public void StartGra()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Stworz Gracza");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("1. Baba");
            Console.WriteLine("2. Chłop");

            int wiadomosc = int.Parse(Console.ReadLine());

            Console.WriteLine('\n' + "Wypisz nazwe gracza");

            string nazwa = Console.ReadLine();

            Console.Clear();

            //Player newPlayer = new Player(Unit.UnitType.Player, nazwa);

            RestartGry();
        }

        private void OdczytajWiadomosc(int wiadomosc)
        {
            switch (wiadomosc)
            {
                case 0:
                    RestartGry();
                    return;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Wypisz wiersze");
                    Console.ForegroundColor = ConsoleColor.White;
                    int wierszeGracza = int.Parse(Console.ReadLine());
                    wiersze = wierszeGracza;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Wypisz kolumny");
                    Console.ForegroundColor = ConsoleColor.White;
                    int kolumnyGracza = int.Parse(Console.ReadLine());
                    kolumny = kolumnyGracza;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Wypisz wielkosc");
                    Console.ForegroundColor = ConsoleColor.White;
                    int wielkosc = int.Parse(Console.ReadLine());
                    wiersze = wielkosc;
                    kolumny = wielkosc;
                    break;
                case 4:
                    wiersze = 4;
                    kolumny = 4;
                    break;
            }
            RestartGry();
        }

        public void RestartGry()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Gra Pola !" + '\n');
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Konfiguracja");
            Console.WriteLine("2. Zagraj");

            int wiadomosc = int.Parse(Console.ReadLine());

            if (wiadomosc == 1)
            {
                Konfiguracja();
                return;
            }

            Gra gra = new Gra(wiersze, kolumny);
            Console.Clear();

            gra.wypiszTablica();
            while (true)
            {
                Console.WriteLine('\n' + "Gdzie chcesz sie poruszyć");
                Console.WriteLine("0. powrót | 1.<- | 2.-> | 3. dół | 4. góra");

                int pozycja = int.Parse(Console.ReadLine());
                if (pozycja == 0)
                {
                    RestartGry();
                    break;
                }
                gra.wyczytajPozycje(pozycja);
            }
        }
    }
}
