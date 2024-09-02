using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {

            
            try
            {
                Console.WriteLine("Ingrese el monto de la actividad económica:");
                double monto = Convert.ToDouble(Console.ReadLine());
                double impuesto = CalcularImpuesto(monto);
                Console.WriteLine($"El impuesto a pagar es: ${impuesto:F2}");
            }
            catch(FormatException)
            {
                Console.WriteLine("Error: Ingrese un valor numérico válido.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Presione cualquier tecla para salir...");
                Console.ReadKey();  // Evita el cierre automático de la consola
            }
            

            double CalcularImpuesto(double monto)
            {
                double impuesto = 0;

                if (monto >= 0.01 && monto <= 500)
                {
                    impuesto = 1.5;
                }
                else if (monto > 500 && monto <= 1000)
                {
                    impuesto = 1.5 + ((monto - 500) / 1000 * 3);
                }
                else if (monto > 1000 && monto <= 2000)
                {
                    impuesto = 3 + ((monto - 1000) / 1000 * 3);
                }
                else if (monto > 2000 && monto <= 3000)
                {
                    impuesto = 6 + ((monto - 2000) / 1000 * 3);
                }
                else if (monto > 3000 && monto <= 6000)
                {
                    impuesto = 9 + ((monto - 3000) / 1000 * 2);
                }
                else if (monto > 6000 && monto <= 8000)
                {
                    impuesto = 15 + ((monto - 6000) / 1000 * 2);
                }
                else if (monto > 8000 && monto <= 18000)
                {
                    impuesto = 19 + ((monto - 8000) / 1000 * 2);
                }
                else if (monto > 18000 && monto <= 30000)
                {
                    impuesto = 39 + ((monto - 18000) / 1000 * 2);
                }
                else if (monto > 30000 && monto <= 60000)
                {
                    impuesto = 63 + ((monto - 30000) / 1000 * 1);
                }
                else if (monto > 60000 && monto <= 100000)
                {
                    impuesto = 93 + ((monto - 60000) / 1000 * 0.8);
                }
                else if (monto > 100000 && monto <= 200000)
                {
                    impuesto = 125 + ((monto - 100000) / 1000 * 0.7);
                }
                else if (monto > 200000 && monto <= 300000)
                {
                    impuesto = 195 + ((monto - 200000) / 1000 * 0.6);
                }
                else if (monto > 300000 && monto <= 400000)
                {
                    impuesto = 255 + ((monto - 300000) / 1000 * 0.45);
                }
                else if (monto > 400000 && monto <= 500000)
                {
                    impuesto = 300 + ((monto - 400000) / 1000 * 0.4);
                }
                else if (monto > 500000 && monto <= 1000000)
                {
                    impuesto = 340 + ((monto - 500000) / 1000 * 0.3);
                }
                else if (monto > 1000000)
                {
                    impuesto = 490 + ((monto - 1000000) / 1000 * 0.18);
                }

                return impuesto;
            }
        }

        static void Main()
        {



            string[] unidades = { "Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzana", "Hectárea" };
            double[] factoresConversion = { 1, 0.698896, 0.111111, 0.092903, 0.000157, 0.0000358701, 0.0000092903 };

            Console.WriteLine("Conversor de Área");
            Console.WriteLine("=================");
            Console.WriteLine("Unidades disponibles:");

            for (int i = 0; i < unidades.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {unidades[i]}");
            }

            // Solicitar al usuario la unidad de origen y destino
            Console.Write("\nSeleccione la unidad de origen (1-7): ");
            int unidadOrigen = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Seleccione la unidad de destino (1-7): ");
            int unidadDestino = int.Parse(Console.ReadLine()) - 1;

            // Solicitar al usuario el valor de la superficie a convertir
            Console.Write("Ingrese el valor del área a convertir: ");
            double valor = double.Parse(Console.ReadLine());

            // Realizar la conversión
            double resultado = ConvertirArea(valor, factoresConversion[unidadOrigen], factoresConversion[unidadDestino]);

            Console.WriteLine($"\n{valor} {unidades[unidadOrigen]} es igual a {resultado} {unidades[unidadDestino]}.");
        }

        // Función para convertir entre las unidades
        static double ConvertirArea(double valor, double factorOrigen, double factorDestino)
        {
            return valor * factorOrigen / factorDestino;

        }
    }
}















































            