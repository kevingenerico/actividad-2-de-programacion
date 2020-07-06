using System;

namespace patronsingleton_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Clase.Instance.mensaje);
            Clase.Instance.mensaje = "\nDios le siga bendiciendo";
            Console.WriteLine(Clase.Instance.mensaje);
            Console.ReadKey();
        }
    }
}
