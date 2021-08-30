using System;

namespace Ejercicio_12
{
    /*
        Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
        un mensaje "¿Continuar? (S/N)".
        En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
        opciones.
        El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
        cualquier otro valor. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int numero = 0;
            bool seguir = true;
            char respuesta;
            do
            {
                Console.Write("Ingresar un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.Write("¿Continuar? (S/N): ");
                respuesta = Convert.ToChar(Console.ReadLine());
                suma = suma + numero;
                Console.WriteLine("------------");
                Console.WriteLine("Total: {0}", suma);
                Console.WriteLine("------------");
            } while(seguir = ValidarRespuesta.ValidaS_N(respuesta));
        }
    }
}
