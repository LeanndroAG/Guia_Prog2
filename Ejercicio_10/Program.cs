using System;

namespace Ejercicio_10
{
    /*
        Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla
        una pirámide como la siguiente:
                                            *
                                           ***
                                          *****
                                         *******
                                        *********
        Nota: Utilizar estructuras repetitivas y selectivas. 
    */
    class Program
    {
        static void Main(string[] args)
        {

            int alto;
            Console.WriteLine("Alto: ");
            alto = int.Parse(Console.ReadLine());

            for (int i = 0; i < alto; i++)
            {
                Console.WriteLine(new String(' ', alto - i - 1) + new String('*', i + i + 1));
            }
        }
    }
}
