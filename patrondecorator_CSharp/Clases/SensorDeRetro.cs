using System;
using System.Collections.Generic;
using System.Text;
using ProblemasPatron.Interfaces;
namespace ProblemasPatron.Clases
{
    public class  SensorDeRetro:DecoradordeAuto
    {
        public SensorDeRetro(IFuncionalidades auto) : base(auto)
        {

        }
        public override string getDescripcion()
        {
            return this.auto.getDescripcion() + "Sensor de Retro\n";
        }
    }
}
