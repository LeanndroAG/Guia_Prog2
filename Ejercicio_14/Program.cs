using System;

namespace Ejercicio_14
{
    /*
     *  Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el
        cálculo del área que corresponda:
        a. double CalcularCuadrado(double)
        b. double CalcularTriangulo(double, double)
        c. double CalcularCirculo(double)
        El ingreso de los datos como la visualización se deberán realizar desde el método Main().
     */
    class Program
    {
        static void Main(string[] args)
        {
            double lado,laBase,laAltura,radio;
            Console.WriteLine("----------------------");
            Console.WriteLine("Area de un Cuadrado");
            Console.Write("Ingresar lado: ");
            lado = Convert.ToDouble(Console.ReadLine());
            Console.Write("Area: {0}\n", CalculoDeArea.CalcularCuadrado(lado));
            Console.WriteLine("----------------------");
            Console.WriteLine("Area de un Triangulo");
            Console.Write("Ingresar base: ");
            laBase = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresar Altura: ");
            laAltura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Area: {0}\n", CalculoDeArea.CalcularTriangulo(laBase,laAltura));
            Console.WriteLine("----------------------");
            Console.WriteLine("Area de un Circulo");
            Console.Write("Ingresar radio: ");
            radio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Area: {0}\n", CalculoDeArea.CalcularCirculo(radio));


        }
    }
}
