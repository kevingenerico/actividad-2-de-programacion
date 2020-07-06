using System;
using System.Collections.Generic;
using System.Text;
using ProblemasPatron.Interfaces;
namespace ProblemasPatron.Clases
{
    class Radio:DecoradordeAuto
    {
        public Radio(IFuncionalidades auto):base(auto)
        {

        }
        public override string getDescripcion()
        {
            return this.auto.getDescripcion() + "Radio\n";
        }
    }
}

    