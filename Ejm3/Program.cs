using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejm3
{
    class Program
    {
        //Valores globales
        static void Main(string[] args)
        {
            //Variables locales
            int n1, n2, sum, res, mult;
            double divi; 
            //Entrada 
            Console.Write("Numero 1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Numero 2: ");
            n2 = int.Parse(Console.ReadLine());
            //Llamamos la funcion con parametro
            sum = sumanumeros(n1,n2);
            res = restanumeros(n1, n2);
            mult = multinumeros(n1,n2);
            divi = divinumeros(n1,n2);
            Console.WriteLine("Suma: " + sum);
            Console.WriteLine("Resta: " + res);
            Console.WriteLine("La multiplicación es: " + mult);
            Console.WriteLine("La división es: " + divi);
        }
        //Creamos una función con parámetros que recibe valores
        //calcule y retorne la suma de 2 números
        static int sumanumeros(int a, int b)
        {
            int sum;
            sum = a + b;
            return sum;
        }
        static int restanumeros(int a, int b)
        {
            int res;
            res = a - b;
            return res;
        }
        static int multinumeros(int a, int b)
        {
            int mult;
            mult = a * b;
            return mult;
        }
        static double divinumeros(int a, int b)
        {
            double divi;
            divi = 1.0 * a / b;
            return divi;
        }
    }
}
