using System;
using System.Collections.Generic;
using System.Text;
using ProblemasPatron.Interfaces;
namespace ProblemasPatron.Clases
{
    class AirBag:DecoradordeAuto
    {
        public AirBag(IFuncionalidades auto) : base(auto)
        {

        }
        public override string getDescripcion()
        {
            return this.auto.getDescripcion() + "AirBag\n";
        }
    }
}
