using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.
using System.Text;
using System.Threading.Tasks;

namespace miPrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejerccio obtner el promedio de una serie de numeros
            int[] serie = new int[] { 5, 6, 8, 9 }; //32
            int sum = 0;
            foreach (int num in serie){
                sum += num;
            }
            decimal prom = sum / serie.Length;
            Console.WriteLine("La suma es {0}, el promedio {1}", sum, prom);



            //Pausa.
            Console.ReadLine ( ) ;
        }
    }
}
