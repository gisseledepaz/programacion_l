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
            //Prioridad de los operadores aritmeticos.
            //ejercicios obtener el promedio de una serie de numeros
            int[] serie = new int[] { 5, 4, 6, 8, 9 }; //32
            int suma = 0;
            foreach ( int num in serie) {
                suma += num ;
            }
             decimal prom = suma / serie.Length;
            Console.WriteLine("la suma es: {0}, el promedio es {1}", suma, prom);
            Console.WriteLine("Num1 :");
            int num1 = int.Parse(Console.ReadLine());
            num1 = sbyte.Parse(Console.ReadLine());

            Console.WriteLine("Num 2:");
            int num2 = int.Parse(Console.ReadLine());
            num2 = sbyte.Parse(Console.ReadLine());

            int respuesta = num1 + num2;
            Console.WriteLine("la suma de {0} + {1} = {2}", num1 + num2, respuesta);
            
            //Pausa.
            Console.ReadLine();
        }
    }
}
