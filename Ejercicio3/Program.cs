﻿using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es.
            //   Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero.
            //   Informar el promedio teniendo en cuenta sólo los números primos.
            int n, promedio, acuP = 0, conP = 0;
            
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                if (primo (n)){
                 conP++;
                 acuP+= n;}




               Console.WriteLine("Ingrese otro nro: ");
               n = int.Parse(Console.ReadLine());
               
            }
             promedio = acuP / conP;
             Console.WriteLine("El promedio de nros primos es: " + promedio);

 


            
        }
        static bool primo(int a){
            int con = 0;
            for (int x = 1; x <= a; x++)
            {
                if (a % x == 0)
                con++;
            }
            if(con == 2)
            return true;
            else
            return false;
            

        }
    }
}
