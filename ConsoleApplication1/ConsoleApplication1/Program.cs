using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOrdenadores
{
    class Program
    {
        private static Tienda TD;
        static void Main(string[] args)
        {
            TD = new Tienda("Pc Today");
            TD.MenuPrincipal();

        }
    }
}
