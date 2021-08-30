using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
       Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
       string DecimalBinario(int). Convierte un número de entero a binario.
       int BinarioDecimal(string). Convierte un número binario a entero.
       NOTA: no utilizar los atajos del lenguaje, hacerlo mediante estructuras repetitivas y de control.
*/
namespace Ejercicio_13
{
    public class Conversor
    {
        public static string DecimalBinario(int numero)
        {
            string binario = "";

            while (numero > 0)
            {
                binario = numero % 2 + binario;
                numero = numero / 2;
            }

            return binario;
        }
        public static int BinarioDecimal(string binario)
        {
             int exponente = binario.Length - 1;
             int numeroDecimal = 0;

             for (int i = 0; i < binario.Length; i++)
             {
                 if (int.Parse(binario.Substring(i, 1)) == 1)
                 {
                     numeroDecimal = numeroDecimal + Convert.ToInt32(Math.Pow(2, Convert.ToDouble(exponente.ToString())).ToString());
                 }
                 exponente--;
             }
             return numeroDecimal;
        }
    }
}
