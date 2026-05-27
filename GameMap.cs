using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolowa_TablicaDwuWymiarowa
{
    public static class GameMap
    {
        public static Fields[][] map;

        public static void CreateMap(int wiersze, int kolumny)
        {
            map = new Fields[wiersze][];

            Random rnd = new Random();
            for (int i = 0; i < wiersze; i++)
            {
                map[i] = new Fields[kolumny];

                for (int j = 0; j < kolumny; j++)
                {
                    int number = rnd.Next(0, 5);
                    if (number == 2)
                    {
                        Blokada blokada = new Blokada();
                        
                        map[i][j] = new Fields(null, blokada);
                    } else
                    {
                        map[i][j] = new Fields(null, null);
                    }
                }
            }
        }

        public static void StworzStartowegoGracza(Player player)
        {
            map[0][0] = new Fields(player, null);
        }
    }
}
