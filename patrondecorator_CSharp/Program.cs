using System;
using ProblemasPatron.Interfaces;
using ProblemasPatron.Clases;

namespace patrondecorator_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto Normal = new Auto();
            Radio Auton_Con_Radio = new Radio(Normal);
            TV Auto_Con_TV_Y_Radio = new TV(Auton_Con_Radio);
            SensorDeRetro Auto_Con_Sensor_De_Retro = new SensorDeRetro(Auto_Con_TV_Y_Radio);
            AirBag Auto_Con_Airbag_TV_Radio_Y_Sensor_De_Retro = new AirBag(Auto_Con_Sensor_De_Retro);

            Console.WriteLine(Auto_Con_Airbag_TV_Radio_Y_Sensor_De_Retro.getDescripcion());

            Console.ReadKey();
        }
    }
}
