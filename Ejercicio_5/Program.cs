using System;

namespace Ejercicio_5
{
    /*
        Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en
        dos grupos de números, cuyas sumas son iguales.
        El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8)
        cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a
        49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
        Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
        usuario ingrese por consola.
        Nota: Utilizar estructuras repetitivas y selectivas.
     */
    class Program
    {
        //AC antes del centro
        //DC despues del centro
        static void Main(string[] args)
        {
            int sumaAC, sumaDC, numeroIncrementador, numeroIngresado;
            sumaAC = 0;
            sumaDC = 1;
            numeroIncrementador = 1;
            String listaAC, listaDC;
            listaAC = listaDC = " ";

            Console.Write("Ingrese un numero: ");
            numeroIngresado = int.Parse(Console.ReadLine());


            while(numeroIncrementador < numeroIngresado + 1) //agregar un +1 para que haga otra iteracion y evitar problemas.
            { 
                for (int i = 1; i < numeroIncrementador; i++)  //Sumo n° AC y los acumulo para mostrar.
                {
                    sumaAC = sumaAC + i;
                    listaAC = listaAC + i + " | ";
                }
                for(int k = numeroIncrementador + 1; k < numeroIncrementador * 2; k++) //Sumo n° DC y los acumulo para mostrar.
                {
                    if(sumaAC == sumaDC) //Muestro y salgo
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nLista de numeros antes del centro: \n" + listaAC);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(numeroIncrementador + " Es un centro numerico");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Lista de numeros despues del centro: \n" + listaDC);
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Suma de listas: " + sumaDC);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                    else //Aca sumo y acumulo
                    {
                        sumaDC = sumaDC + k;
                        listaDC = listaDC + k  + " | ";
                    }
                }
                numeroIncrementador++;   //incrementar el n° para generar lista
                sumaAC = 0;              //resetear contadores
                sumaDC = 0;
                listaAC = listaDC = " ";
            }
        }
    }
}
