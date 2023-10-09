using System;

namespace Ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, resultado;

            pedirDatos(ref n1, ref n2);

            //logica
            //resultado = n1 + n2;
            resultado = sumar(n1, n2);
            //fin logica

            
            Console.WriteLine("El resultado es: " +resultado);
        }

        static int sumar(int a, int b){

            int r;
            r = a + b + 2;
            return r;
        }

        static void pedirDatos(ref int j ref int h){

            Console.WriteLine("Ingrese un nro: ");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro nro: ");
            h = int.Parse(Console.ReadLine());
        }
    }
}
