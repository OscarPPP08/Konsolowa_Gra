using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolowa_TablicaDwuWymiarowa
{
    public class Blokada
    {
        public static int countNumber;
        public int id;

        public Blokada()
        {
            countNumber++;
            id = countNumber;
        }
    }
}
