using System;

namespace patonobserver_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creo usuarios
            Usuario user1 = new Usuario("luis1535");
            Usuario user2 = new Usuario("matiasblog");
            Usuario user3 = new Usuario("pofesorjuan");
            Usuario user4 = new Usuario("joseplay");

            // Los subscribo 
            user1.subscribirseA(user4);
            user2.subscribirseA(user4);
            user3.subscribirseA(user4);
            user4.subscribirseA(user3);

            // Subo video
            user4.subirVideo("la mejor partida de fornite");
            user3.subirVideo("cusro de angular 10");

            Console.ReadKey();
        }
    }
}
