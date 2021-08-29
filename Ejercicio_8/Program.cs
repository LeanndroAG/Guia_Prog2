using System;

namespace Ejercicio_8
{
    /*
        Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas
        trabajadas en el mes de N empleados de una fábrica.
        Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el
        valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
        multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
        descuentos.
        Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
        bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
        Nota: Utilizar estructuras repetitivas y selectivas.
    */
    class Program
    {
        static void Main(string[] args)
        {
            string seguir = "s";
            string nombre;
            int antiguedad;
            int valorXhora;
            int horasMensuales;
            int sueldoBruto;
            int impuestos;
            int sueldoNeto;
            

            do
            {
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Antiguedad: ");
                antiguedad = int.Parse(Console.ReadLine());
                Console.Write("Valor x hora: ");
                valorXhora = int.Parse(Console.ReadLine());
                Console.Write("Horas/Mes: ");
                horasMensuales = int.Parse(Console.ReadLine());

                sueldoBruto = (valorXhora * horasMensuales) + (antiguedad * 150);
                impuestos = (sueldoBruto * 13) / 100;
                sueldoNeto = sueldoBruto - impuestos;

                Console.WriteLine("----------------------");
                Console.WriteLine("Nombre: {0}", nombre);
                Console.WriteLine("Antiguedad: {0}", antiguedad);
                Console.WriteLine("Valor por hora: {0}", valorXhora);
                Console.WriteLine("Sueldo bruto: {0}", sueldoBruto);
                Console.WriteLine("Impuestos: {0}", impuestos);
                Console.WriteLine("Sueldo neto: {0}", sueldoNeto);
                Console.WriteLine("----------------------");
                Console.Write("Ingresar otro empleado? S/N: ");
                seguir = Console.ReadLine();
                Console.WriteLine("----------------------");

            } while (seguir == "s");

        }
    }
}
