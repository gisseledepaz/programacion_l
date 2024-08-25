using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio 
{
    class Program
    {
        static void Main()
        {

            string[][] Conversores = new string[][]
               { //selecione la opcion
                new string[]{"Dolar", "Euro", "Quetzal", "Lempira", "Cordoba", "ColonSV", "ColonCR", "Yenes", "Rupias india", "Libras esterlinas"},
                new string[]{"Libra", "Kilogramo", "Gramo", "Tonelada", "Miligramo", "Microgramo", "Tonelada Larga", "Tonelada Corta", "Stone", "Onza"},
                new string[]{"Litro", "Galon estadunidence", "Cuarto estadunidence", "Pinta estadunidence", "Taza estadunidence", "Onza liquida estadunidence", "Cucharada USA", "Cucharadita USA", "Metro Cubico", "Mililitro"},
                new string[]{"Metro", "Kilometro", "Centimetro", "Milimetro", "Micrometro", "Nanometro", "Milla", "Yarda", "Pie", "Pulgada"},
                new string[]{"Megabyte", "Gigabyte", "Terabyte", "Petabyte", "Kilobyte", "Byte", "Petabit", "Terabit", "Gigabit", "Megabit"},
                new string[]{"Minuto", "Segundo", "Hora", "Dia", "Semana", "Mes", "Año", "Decada", "Siglo", "Milisegundo"},
               };
            //selecione la opcion
            double[][] monedas = {
                new double[]{1, 0.92, 7.86, 24.62, 36.56, 8.75, 535.14, 145.52, 83.32, 0.79 },
                new double[]{1, 0.453592, 453.592, 0.000453592, 453592, 453600000, 0.000446429, 0.0005, 0.0714286, 16},
                new double[]{1, 0.264172, 1.05669, 2.11338, 4.16667, 33.814, 67.628, 202.884, 0.001, 1000},
                new double[]{1, 0.001, 100, 1000, 1000000, 1000000000, 0.000621371, 1.09361, 3.28084, 39.3701},
                new double[]{1, 0.001, 0.000001, 0.000000001, 1000, 1000000, 0.000000001, 0.000001, 0.008, 8},
                new double[]{1, 60, 0.0166667, 0.000694444, 0.000099206, 0.000022831, 0.0000019026, 0.00000019026, 0.00000001903, 60000},
            };

            Console.WriteLine("Seleccione el tipo de conversor:");
            for (int i = 0; i < Conversores.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {string.Join(", ", Conversores[i])}");
            }

            int tipoConversor = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Seleccione la unidad de origen:");
            for (int i = 0; i < Conversores[tipoConversor].Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Conversores[tipoConversor][i]}");
            }

            int de = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Seleccione la unidad que desea convertir:");
            for (int i = 0; i < Conversores[tipoConversor].Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Conversores[tipoConversor][i]}");
            }

            int a = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Ingrese la cantidad a convertir:");
            double cantidad = double.Parse(Console.ReadLine());

            double respuesta = monedas[tipoConversor][a] / monedas[tipoConversor][de] * cantidad;
            Console.WriteLine("Respuesta: " + Math.Round(respuesta, 3));

            Console.ReadLine();

        }
    }
}   


























            