using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    class Tabuada
    {
        public static void CalculoTabuada(int valor)
        {
            for (int c = 0; c < 11; c++)
            {
                Console.WriteLine($"{c} x {valor} = {c * valor}");
            }
        }
    }
}
