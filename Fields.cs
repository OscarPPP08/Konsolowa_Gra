using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolowa_TablicaDwuWymiarowa
{
    public class Fields
    {
        public Player player;
        public Blokada blokada;
        public Fields(Player player, Blokada blokada) { 
            this.player = player;
            this.blokada = blokada;
        }
    }
}
