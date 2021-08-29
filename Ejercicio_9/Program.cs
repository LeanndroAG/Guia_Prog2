using System;

namespace Ejercicio_9
{
    /*
        Escribir un programa que imprima por pantalla una pirámide como
        la siguiente:
        *
        ***
        *****
        *******
        *********
        El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. Para el
        ejemplo anterior la altura ingresada fue de 5.
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
                for (int k = 0; k < alto; k++)
                {
                    if (k <= i)
                    {
                        Console.Write("*");
                    }
                    if (k == i)
                    {
                        Console.Write("\n");
                    }
                }
            }

        }
    }
}
