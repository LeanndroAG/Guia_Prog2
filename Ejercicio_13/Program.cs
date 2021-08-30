using System;

namespace Ejercicio_13
{
    /*
        Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
        string DecimalBinario(int). Convierte un número de entero a binario.
        int BinarioDecimal(string). Convierte un número binario a entero.
        NOTA: no utilizar los atajos del lenguaje, hacerlo mediante estructuras repetitivas y de control.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string binario;

            Console.Write("Decimal a Binario: ");
            numero = Convert.ToInt32(Console.ReadLine());
            binario = Conversor.DecimalBinario(numero);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Binario: {0}", binario);
            Console.WriteLine("------------------------------------------------------------");
            numero = 0;
            binario = "";
          
            Console.Write("Binario a Decimal: ");
            binario = Console.ReadLine();
            numero = Conversor.BinarioDecimal(binario);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Decimal: {0}", numero);
            Console.WriteLine("------------------------------------------------------------");


        }
    }
}
