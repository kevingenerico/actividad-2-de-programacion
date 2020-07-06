using System;
using System.Collections.Generic;
using System.Text;
using ProblemasPatron.Interfaces;
namespace ProblemasPatron.Clases
{
    public class Auto:IFuncionalidades
    {
        public string getDescripcion()
        {
            return "4 Ruedas\nChasis\nPuertas\nVolante\nmotor\nfrenos";
        }
    }
}
