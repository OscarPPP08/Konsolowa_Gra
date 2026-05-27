using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolowa_TablicaDwuWymiarowa
{
    internal class Gra
    {

        private int pozycjaX;
        private int pozycjaY;

        public Gra(int wiersze, int kolumny, Player gracz) {
            GameMap.CreateMap(wiersze, kolumny);
            GameMap.StworzStartowegoGracza(gracz);
            this.pozycjaX = 0;
            this.pozycjaY = 0;
            wypiszTablica();
        }

        public void wyczytajPozycje(int pozycja)
        {
            int nowaX = pozycjaX;
            int nowaY = pozycjaY;

            switch (pozycja)
            {
                case 0:
                    Console.WriteLine("gra zakonczona");
                    break;
                case 1:
                    if (pozycjaX <= 0) { wypiszTablica(); return; }
                    nowaX--;
                    break;
                case 2:
                    if (pozycjaX >= (GameMap.map[0].Length - 1)) { wypiszTablica(); return; }
                    nowaX++;                   
                    break;
                case 3:
                    if (pozycjaY >= (GameMap.map[1].Length - 1)) { wypiszTablica(); return; }
                    nowaY++;
                    break;
                case 4:
                    if (pozycjaY <= 0) { wypiszTablica(); return; }
                    nowaY--;
                    break;
            }
            if (GameMap.map[nowaY][nowaX].blokada != null)
            {
                wypiszTablica();
                return;
            }
            zmienPozycje(nowaY, nowaX);
        }

        private void zmienPozycje(int nowaY, int nowaX)
        {
            Player gracz = GameMap.map[pozycjaY][pozycjaX].player;
            GameMap.map[pozycjaY][pozycjaX] = new Fields(null, null);

            GameMap.map[nowaY][nowaX] = new Fields(gracz, null);

            pozycjaX = nowaX;
            pozycjaY = nowaY;

            wypiszTablica();
        }

        public void wypiszTablica()
        {
            Console.Clear();
            for (int i = 0; i < GameMap.map.Length; i++)
            {
                for (int j = 0; j < GameMap.map[i].Length; j++)
                {
                    Fields pole = GameMap.map[i][j];

                    if (pole.player != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{ 1 }");
                        Console.ForegroundColor = ConsoleColor.White;
                    } else if (pole.blokada != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{ | }");
                        Console.ForegroundColor = ConsoleColor.White;
                    } else
                    {
                        Console.Write("{ - }");
                    }
                   
                }
                Console.WriteLine();
            }
        }
    }
}
