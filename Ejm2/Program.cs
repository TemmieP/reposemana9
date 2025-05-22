using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejm2
{
    class Program
    {
        //Variables globales:
        //Se pueden usar en cualquier parte del programa
        static int n1, n2, sum, rest, mult;
            static double divi;
        static void Main(string[] args)
        {
            Console.Write("Numero 1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Numero 2: ");
            n2 = int.Parse(Console.ReadLine());

            //Llamamos a la funcion creada
            sum = sumanumeros();
            rest = restanumeros();
            mult = multinumeros();
            divi = divinumeros();

            Console.WriteLine("La suma es: " + sum);
            Console.WriteLine("La resta es: " + rest);
            Console.WriteLine("La multiplicación es: " + mult);
            Console.WriteLine("La división es: " + divi);
        }
        //Creamos una función sin parámetros que
        //calcule y retorne la suma de 2 números

         static int sumanumeros()
        {
            sum = n1 + n2;
            return sum;
        }
        static int restanumeros()
        {
            rest = n1 - n2;
            return rest;
        }
        static int multinumeros()
        {
            mult = n1 * n2;
            return mult;
        }
        static double divinumeros()
        {
            divi = 1.0*n1 / n2;
            return divi;
        }
    }
}
