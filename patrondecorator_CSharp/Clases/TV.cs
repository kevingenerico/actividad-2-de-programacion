using System;
using System.Collections.Generic;
using System.Text;
using ProblemasPatron.Interfaces;
namespace ProblemasPatron.Clases
{
    class TV:DecoradordeAuto
    {
        public TV(IFuncionalidades auto) : base(auto)
        {

        }
        public override string getDescripcion()
        {
            return this.auto.getDescripcion() + "TV\n";
        }
    }
}
