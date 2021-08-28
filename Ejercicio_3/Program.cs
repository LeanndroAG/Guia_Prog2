using System;
/*
    Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
    por consola.
    Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
*/
namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 2;
            int divisible = 0;
            Console.Write("Ingresar un numero: ");
            int numeroFinal = int.Parse(Console.ReadLine());

            while (numero <= numeroFinal)
            {
                for (int i = 1; i <= numero; i++)
                {
                    if ((numero % i) == 0)
                    {
                        divisible++;
                    }
                    if (divisible > 2)
                    {
                        break;
                    }
                }
                if (divisible == 2)
                {
                    Console.WriteLine("Numeros primos: {0}", numero);
                }
                divisible = 0;
                numero++;
            }
            Console.ReadKey();
        }
    }
}
