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
            foreach (int num in serie)
            {
                sum += num;

                //estructuras de control
                //1.if.ejercicio.pedir al usuario la edad si es mayar de edad que le diga bienenido 
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad <= 18)
                {
                    Console.WriteLine("Bienvenido al mundo de las responsabiliddes ");
                }
                else
                {
                    Console.WriteLine("Es un adolecente, disfruta de la vida.");
                }
                decimal promedio = sum / serie.Length;
                Console.WriteLine("La suma es: {0}, el promedio {1}", sum, promedio);
            }


               //Pausa.
            Console.ReadLine ( ) ;
        }
    }
}
