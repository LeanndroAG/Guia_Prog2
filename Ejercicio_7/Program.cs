using System;

namespace Ejercicio_7
{
    /*
        Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
        calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
        con DateTime.Now).
        Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.
     */
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaDeNacimiento, fechaActual;
            TimeSpan diasVividos;
            int edad;
            fechaActual = DateTime.Today;

            Console.WriteLine("Ingresar fecha de nacimiento: DD-MM-YYYY");
            Console.WriteLine("-----------------");
            fechaDeNacimiento = Convert.ToDateTime(Console.ReadLine());
            
            if(fechaDeNacimiento.Year > fechaActual.Year)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Su fecha de nacimiento no existe.");
            }
            else
            {
                edad = DateTime.Today.AddTicks(-fechaDeNacimiento.Ticks).Year - 1;
                Console.WriteLine("Edad: {0}", edad);
                //Hacen lo mismo
                diasVividos = fechaActual.Date - fechaDeNacimiento.Date;
                Console.WriteLine("Total de dias vividos: {0}", diasVividos);
                Console.WriteLine("Total de dias vividos: " + fechaActual.Subtract(fechaDeNacimiento).Days);

            }
            if (fechaDeNacimiento.Year % 4 == 0 && fechaDeNacimiento.Year % 100 != 0 || fechaDeNacimiento.Year % 400 == 0)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Es año bisiesto.");
            }
            else
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("No es año bisiesto.");
            }
        }
    }
}
