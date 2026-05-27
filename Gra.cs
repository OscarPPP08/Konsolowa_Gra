using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolowa_TablicaDwuWymiarowa
{
    internal class Gra
    {
        private int[][] tablica;
        private int pozycjaX;
        private int pozycjaY;

        public Gra(int wiersze, int kolumny) {
            tablica = new int[wiersze][];
            for (int i = 0; i < wiersze; i++)
            {
                tablica[i] = new int[kolumny];
            }
            tablica[0][0] = 1;
            this.pozycjaX = 0;
            this.pozycjaY = 0;
            wypiszTablica();
        }

        public void wyczytajPozycje(int pozycja)
        {
            switch (pozycja)
            {
                case 0:
                    Console.WriteLine("gra zakonczona");
                    break;
                case 1:
                    if (pozycjaX <= 0) { wypiszTablica(); return; }
                    this.pozycjaX--;
                    break;
                case 2:
                    if (pozycjaX >= (tablica[0].Length - 1)) { wypiszTablica(); return; }
                    this.pozycjaX++;                   
                    break;
                case 3:
                    if (pozycjaY >= (tablica[1].Length - 1)) { wypiszTablica(); return; }
                    this.pozycjaY++;
                    break;
                case 4:
                    if (pozycjaY <= 0) { wypiszTablica(); return; }
                    this.pozycjaY--;
                    break;
            }
            zmienPozycje();
        }

        private void zmienPozycje()
        {
            wyczyscTablice();

            tablica[pozycjaY][pozycjaX] = 1;

            wypiszTablica();
        }

        private void wyczyscTablice()
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica[i].Length; j++)
                {
                    tablica[i][j] = 0;
                }
            }
        }

        public void wypiszTablica()
        {
            foreach (int[] tab in tablica)
            {
                foreach (int i in tab)
                {
                    if (i == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("{" + i + "}");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                    Console.Write("{" + i + "}");
                }
                Console.WriteLine();
            }
        }
    }
}
