using System;

namespace Ejercicio_15
{
    class Program
    {
        /*
            Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta,
            multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la
            operación que desea realizar (pulsando el caracter +, -, * o /).
            El usuario decidirá cuándo finalizar el programa.
            Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
            a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la
            operación matemática. El método devolverá el resultado de la operación.
            b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe
            utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
            TRUE si el número es distinto de CERO. 
         */
        static void Main(string[] args)
        {
            int operandoA, operandoB;
            char operador;
            Console.WriteLine("CALCULADORA");
            Console.Write("Ingrese 1er operando: ");
            operandoA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese 2do operando: ");
            operandoB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese operador + - * / : ");
            operador =Convert.ToChar(Console.ReadLine());

            Console.Write("Resultado: {0}", Calculadora.Calcular(operandoA, operandoB, operador));
        }
    }
}
