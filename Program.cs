// Escribir un programa que pida ingresar la coordenada de un punto en el plano, 
//es decir dos valores enteros x e y (distintos a cero).
//Posteriormente imprimir en pantalla en que cuadrante se ubica dicho punto. 
//(1º Cuadrante si x > 0 Y y > 0 , 2º Cuadrante: x < 0 Y y > 0, etc.)
using System;

namespace coordenadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor de y: ");
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Las coordenadas estan en el 1er cuadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Las coordenadas estan en el 2do cuadrante");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Las coordenadas estan en el 3er cuadrante");
            }
            else
            {
                Console.WriteLine("Las coordenadas estan en el 4to cuadrante");
            }



            Console.ReadKey();
        }
    }
}