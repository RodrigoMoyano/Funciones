using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos.
            //   Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar.
            //   Usar la función.

            int precioArticulo = 0, cantidadVendida = 0, resultado;

            Console.WriteLine("Ingrese el precio del articulo: ");
            precioArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantidadVendida = int.Parse(Console.ReadLine());

            resultado = producto(precioArticulo, cantidadVendida);





            Console.WriteLine("El precio total es: " + resultado);
        }

        static int producto (int a, int b){

            int r;
            r = a * b;
            return r;
        }
    }
}
