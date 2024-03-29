﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kardex.Controller
{
    class Datagenerators
    {
        public static int GenerateNU()
        {
            Random random = new Random();
            int NU = random.Next(1, 99999);
            return NU;
        }

        public static string GeneratePassword(int longitud)
        {
            string contraseña = string.Empty;
            string[] letras = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
            Random EleccionAleatoria = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int LetraAleatoria = EleccionAleatoria.Next(0, 100);
                int NumeroAleatorio = EleccionAleatoria.Next(0, 9);

                if (LetraAleatoria < letras.Length)
                {
                    contraseña += letras[LetraAleatoria];
                }
                else
                {
                    contraseña += NumeroAleatorio.ToString();
                }
            }
            return contraseña;
        }

        public static string GetActualSemester()
        {
            int period = 1;
            DateTime fechaActual = DateTime.Today;
            if (fechaActual.Month > 6)
            {
                period = 2;
            }
            return string.Format("{0}-0{1}", fechaActual.Year, period);            
        }
    }
}
