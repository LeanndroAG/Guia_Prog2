using System;
/*
    Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el
    valor máximo, el valor mínimo y el promedio.     ><
*/
namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string numerosIngresados;
            int auxiliar;
            int max = int.MinValue;
            int min = int.MaxValue;
            float promedio = 0;
            int numero = 1;
            for(int i = 0; i < 5 ; i++)
            {
                Console.WriteLine("Ingresar el {0} numero: ", numero);
                numerosIngresados = Console.ReadLine();
                if(int.TryParse(numerosIngresados, out auxiliar))
                {
                    numero++;
                    if (auxiliar > max)
                    {
                        max = auxiliar;
                    }
                    if(auxiliar < min)
                    {
                        min = auxiliar;
                    }
                    promedio = promedio + auxiliar;
                }
                else
                {
                    Console.WriteLine("Ingresar numero valido");
                    i--;
                }
            }
            promedio = promedio / 5;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nMaximo: {0}", max);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Minimo: {0}", min);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Promedio: {0:#.##}", promedio);
            Console.ReadKey();
            
        }
    }
}
