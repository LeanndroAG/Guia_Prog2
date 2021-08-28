using System;

namespace Ejercicio_6
{
    /*
        Escribir un programa que determine si un año es bisiesto.
        Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos
        también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
        Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
        Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
     */
    class Program
    {
        static void Main(string[] args)
        {
            int añoUno, añoDos;
            
            Console.Write("Ingrese año 1: ");
            añoUno = int.Parse(Console.ReadLine());
            Console.Write("Ingrese año 2: ");
            añoDos = int.Parse(Console.ReadLine());

            for(int añoBisiesto = añoUno; añoBisiesto <= añoDos; añoBisiesto++)
            {
                if (añoBisiesto % 4 == 0 && añoBisiesto % 100 != 0 || añoBisiesto % 400 == 0) 
                {
                    Console.WriteLine("El año {0} es bisiesto", añoBisiesto);
                }
            }
            Console.ReadKey();
        }
    }
}
