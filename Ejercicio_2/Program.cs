using System;
/*
        Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
        mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
        Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación. 
        ><
 */
namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int numero = 0;
            int auxCuadrado = 0;
            int auxCubo = 0;

            Console.Write("Ingresar un numero: ");
            try
            {
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero > 0)
                {
                    auxCuadrado = Convert.ToInt32(Math.Pow(numero, 2));
                    auxCubo = Convert.ToInt32(Math.Pow(numero, 3));
                    Console.WriteLine("\nPotencia de {0}: {1}", numero, auxCuadrado);
                    Console.WriteLine("Cubo de {0}: {1}", numero, auxCubo);
                }
                else
                {
                    Console.Write("El numero debe ser +0");
                }
            }
            catch(Exception exp)
            {
                Console.WriteLine("ERROR. ¡Ingresar un dato numerico!", exp);
            }
            */
            string numero;
            int auxCuadrado = 0;
            int auxCubo = 0;
            int auxNumero = 0;

            Console.Write("Ingresar un numero: ");
            numero = Console.ReadLine();
            if (int.TryParse(numero, out auxNumero) && auxNumero > 0)
            {
                auxCuadrado = Convert.ToInt32(Math.Pow(auxNumero, 2));
                auxCubo = Convert.ToInt32(Math.Pow(auxNumero, 3));
                Console.WriteLine("\nPotencia de {0}: {1}", numero, auxCuadrado);
                Console.WriteLine("Cubo de {0}: {1}", numero, auxCubo);
            }
            else
            {
                Console.Write("ERROR. ¡Reingresar número!");
            }
        }
    }
}
