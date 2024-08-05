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
                string continuar = "s";
                while (continuar == "s") {
                    Console.Write("Edad:");
                    int edad = int.Parse(Console.ReadLine());

                    if (edad >= 18)
                    {
                        Console.WriteLine("Bienvenido al mundo de las responsabilidades.");
                    }
                    else
                    {
                        Console.WriteLine("Eres un adolecente, disfruta de la vida.");
                        if (edad < 0)
                        {
                            Console.WriteLine("Edad incorrecta.");
                        }
                        else if (edad <= 2)
                        {
                            Console.WriteLine("Eres un bebe");
                        }
                        else if (edad < 12)
                        {
                            Console.WriteLine("Eres un adolecente.");
                        }
                        else if (edad < 18)
                        {
                            Console.Write("Eres un adolecente.");
                        }
                        else if (edad <= 65)
                        {
                            Console.WriteLine("Bienvenido de las responsabilidades.");
                        }
                        else if (edad <= 80)
                        {
                            Console.WriteLine("Eres un adulto mayor");
                        }
                        else
                        {
                            Console.WriteLine("Larga vida");
                        }
                        Console.Write("Desea continuar presione s, sino cualquier tecla.");
                        continuar = Console.ReadLine();
                    }
                    //Pausa.
                    Console.ReadLine();

                            





        }
    }
}
