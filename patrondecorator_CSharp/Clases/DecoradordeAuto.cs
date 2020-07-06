using System;
using System.Collections.Generic;
using System.Text;
using ProblemasPatron.Interfaces;

namespace ProblemasPatron.Clases
{
    public abstract class DecoradordeAuto:IFuncionalidades
    {
        protected IFuncionalidades auto;

        public DecoradordeAuto(IFuncionalidades auto) { this.auto = auto; }

        public abstract string getDescripcion();
    }
}
