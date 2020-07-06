using System;
using System.Collections.Generic;
using System.Text;

namespace patronsingleton_CSharp
{
    class Clase
    {
        private static Clase instance = null;
        public string mensaje = "";

        protected Clase()
        {
            mensaje = "Dios le bendiga";
        }

        public static Clase Instance
        {
            get
            {
                if (instance == null)
                    instance = new Clase();

                return instance;
            }
        }
    }
}
