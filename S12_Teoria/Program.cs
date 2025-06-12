using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S12_Teoria
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] deposito = { 3700, 3200, 2300, 2200, 3500, 2100, 3900, 8000, 2500, 3100 };
            //Llamar la función
            //int longitud = tamano(deposito);
            //Console.WriteLine("Tamaño: " + tamanio);
            Console.WriteLine("Tamaño: " + tamano(deposito));
            //Llamar funcion obtenerDeposito
            Console.WriteLine("Depósito obtenido: " + obtenerDeposito(deposito,3));
            //Llamar funcion promedioDepositos
            Console.WriteLine("Promedio obtenido: " + promedioDepositos(deposito));
            //Llamar funcion depositoMayor
            Console.WriteLine("Depósito mayor: " + depositoMayor(deposito));
            //Llamar funcion depositoMenor
            Console.WriteLine("Depósito menor: " + depositoMenor(deposito));
            //Llamar funcion cantidadMayor3000
            Console.WriteLine("Cantidad de depósitos mayores a 3000: " + cantidadMayores3000(deposito));
            //Llamar funcion cantidadMenor2500
            Console.WriteLine("Cantidad de depósitos menores a 2500: " + cantidadMenores2500(deposito));
            //Llamar funcion posPrimerDeposito
            Console.WriteLine("Primer valor del rango de 2000 a 2500: " + posPrimerDeposito(deposito));
            //Llamar funcion posUltimoDeposito
            Console.WriteLine("Ultimo valor del rango de 3500 a 4000: " + posUltimoDeposito(deposito));

            //Llamamos a la funcion reemplazarDeposito()
            reemplazarDeposito(2, deposito, 5555);
            //Listamos los datos
            listarDatos(deposito);
        }
        //Funcion que retorna la longitud del arreglo
        //Recibirá un parametro de tipo [] arreglo 
        static int tamano(int[] deposito)
        {
            int tamano = deposito.Length;
            return tamano;
        }

        //Un método obtenerDeposito que reciba una posición y retorne el depósito almacenado en
        //dicha posición.
        static int obtenerDeposito( int[]deposito,int pos)
        {
            return deposito[pos];
        } 
         //Un metodo promedioDepositos que retorne el promedio de todos los depositos
         static double promedioDepositos(int[]deposito)
        {
            int suma=0;
            double promedio;
            for(int i = 0; i < deposito.Length; i++)
            {
                suma += deposito[i];
            }
            promedio =1.0*suma / deposito.Length;
            return promedio;
        }
        //Un método depositoMayor y depositoMenor que retorne el mayor y menor de los depósitos almacenados.
        static int depositoMayor(int[] deposito)
        {
            int mayor=deposito[0];
            for (int i = 0; i < deposito.Length; i++)
                if (deposito[i] > mayor)
                    mayor = deposito[i];
                return mayor;
        }
        static int depositoMenor(int[] deposito)
        {
            int menor = deposito[0];
            for (int i = 0; i < deposito.Length; i++)
                if (deposito[i] < menor)
                    menor = deposito[i];
            return menor;
        }
        //Un método cantidadMayores3000 y cantidadMenores2500 que retorne la cantidad de numeros mayores a 3000 y menores a 2500 de los depositos almacenados.
        static int cantidadMayores3000(int[] deposito)
        {
            int mayor3000 = 0;
            for (int i = 0; i < deposito.Length; i++)
                if (deposito[i] > 3000)
                    mayor3000++;
            return mayor3000;
        }
        static int cantidadMenores2500(int[] deposito)
        {
            int menor3000 = 0;
            for (int i = 0; i < deposito.Length; i++)
                if (deposito[i] < 2500)
                    menor3000++;
            return menor3000;
        }
        //Un método posPrimerDeposito que retorne la posición del primer depósito encontrado en el rango de 2000 a 2500. En caso no exista, deberá retornar -1.
        static int posPrimerDeposito(int[] deposito)
        {
            for (int i = 0; i < deposito.Length; i++)
            {
                if (deposito[i] >= 2000 && deposito[i] <= 2500)
                    return deposito[i];
            }
            //en caso no exista un deposito en el rango asignado, retorna -1
            return -1;
        }

        //Un método posUltimoDeposito que retorne la posición del último depósito encontrado en el rango de 3500 a 4000. En caso no exista, deberá retornar -1.
        static int posUltimoDeposito(int[] deposito)
        {
            //Recorrido inverso,desde la ultima posicion.
            for (int i = deposito.Length-1; i>=0; i--)
            {
                if (deposito[i] >= 3500 && deposito[i] <= 4000)
                    return deposito[i];
            }
            //en caso no exista un deposito en el rango asignado, retorna -1
            return -1;
        }

        //Un método reemplazarDepósito que reciba como parámetros la posición y el nuevo depósito y ejecute el reemplazo en el arreglo.
        static void reemplazarDeposito(int pos, int[] deposito, int nuevoDep)
        {
            deposito[pos] = nuevoDep;
        }
        static void listarDatos(int[] deposito)
        {
            for (int i = 0; i < deposito.Length; i++)
            {
                Console.WriteLine(deposito[i]);
            }
        }
    }
}
