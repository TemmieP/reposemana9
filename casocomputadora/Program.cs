using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace casocomputadora
{
    class Program
    {
        static void Main(string[] args)
        {
            String marca;
            int cantidad,ob;
            double iC, iD, iP;
            Console.Write("Ingresar marca: ");
            marca = Console.ReadLine();
            Console.Write("Ingresar cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            //Llamamos a las funciones
            iC = importecompra(marca,cantidad);
            iD = importedescuento(cantidad,iC);
            iP = importepago(iC,iD);
            ob = obsequio(marca);
            //Resultados
            Console.WriteLine("Importe compra: " + iC);
            Console.WriteLine("Importe descuento: " + iD);
            Console.WriteLine("Importe pago: " + iP);
            Console.WriteLine("------------------------");
            Console.WriteLine("PROMOCION: Te llevas " + ob +" mousepads de regalo");
        }
        //Función que calcula y retorna el importe de compra
        //Si una variable se ingresa por el teclado, entonces se declara como parámetro
        static double importecompra(String marca,int cantidad)
        {
            double precio;
            switch (marca)
            {
                case "Dell":
                    precio = 11000;
                    break;
                case "HP":
                    precio = 9000;
                    break;
                case "Apple":
                    precio = 13000;
                    break;
                default:
                    precio = 12500;
                    break;
            }
            return cantidad*precio;
        }
        static int obsequio(String marca)
        {
            int obs;
            if (marca=="HP")
                obs = 3;
            else
                obs = 0;
            return obs;
        }
        //Función que calcula y retorna el descuento de compra
        //Si una variable se ingresa por el teclado, entonces, se declara como parámetro
        //Si una variable se calculó en una función anterior, entonces, se declara como parámetro
        static double importedescuento(int cantidad, double iCom )
        {
            double iDes;
            if (cantidad <= 3)
            {
                iDes = 3.5 / 100 * iCom;
            }
            else if (cantidad < 6)
            {
                iDes = 5.0 / 100 * iCom;
            }
            else if (cantidad < 9)
            {
                iDes = 6.5 / 100 * iCom;
            }
            else 
            iDes = 38.0 / 100 * iCom;
            return iDes;
        }
        static double importepago(double impCom,double iDes)
        {

            return impCom - iDes;
        }
    }
}
