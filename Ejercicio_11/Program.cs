using System;

namespace Ejercicio_11
{
    /*
        Realizar una clase llamada Validación que posea un método estático llamado Validar, que posea la
        siguiente firma: bool Validar(int valor, int min, int max):
        a. valor: dato a validar
        b. min y max: rango en el cual deberá estar la variable valor.
        Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
        anteriormente que estén dentro del rango -100 y 100.
        Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
        Nota: Utilizar variables escalares, NO utilizar vectores.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int valor, promedio; 
            int acumulador = 0;
            int min = 100;
            int max = -100;

            for(int i = 0; i <= 10; i++)
            {
                Console.Write("Ingrese un valor: ");
                valor = Convert.ToInt32(Console.ReadLine());

                if(Validacion.Validar(valor, -100, 100))
                {
                    if(valor > max)
                    {
                        max = valor;
                    }
                    if (valor < min)
                    {
                        min = valor;
                    }
                    acumulador = acumulador + valor; 
                }
                else
                {
                    Console.WriteLine("Ingresar un valor VALIDO.");
                }
            }
            promedio = acumulador / 10;
            Console.WriteLine("El maximo es: {0}", max);
            Console.WriteLine("El minimo es: {0}", min);
            Console.WriteLine("El promedio es: {0}", promedio);
        
        }
    }
}
