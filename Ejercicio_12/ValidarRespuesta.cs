﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
    un mensaje "¿Continuar? (S/N)".
    En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
    opciones.
    El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
    cualquier otro valor. 
 */
namespace Ejercicio_12
{
    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            if (c.ToString() == "s")
                return true;
            else
                return false;
        }
    }
}
