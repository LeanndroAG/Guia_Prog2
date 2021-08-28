using System;
/*
     Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
     (excluido el mismo) que son divisores del número.
     El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
     Escribir una aplicación que encuentre los 4 primeros números perfectos.
     Nota: Utilizar estructuras repetitivas y selectivas.
 */
namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            short perfectosEncontrados = 0;
            //Numero actual, comenzando en 1
            int numero = 1;
            do
            {
                int sumador = 0;
                //Busco los divisores del numero actual
                for (int i = 1; i < numero; i++)
                {
                    if((numero % i) == 0)
                    {
                        //Sumo los divisores en busca del numero Perfecto
                        sumador += i;
                        if (sumador > numero)
                            break;
                    }
                }
                //Si la suma de los divisores es igual al numero, es PERFECTO
                if(sumador == numero)
                {
                    perfectosEncontrados++;
                    Console.WriteLine("El numero {0} es PERFECTO", numero);
                }
                //Incremento el número actual
                numero++;
            } while (perfectosEncontrados < 4);
            Console.ReadKey();
        }
    }
}
