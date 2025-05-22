using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S9_Fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            int ba = 3, exp = 2;
            double pot;
            pot = Math.Pow(ba, exp);
            Console.WriteLine("Potencia: " + pot);
        }
    }
}
