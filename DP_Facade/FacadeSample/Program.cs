using System;

namespace FacadeSample
{
    class Program
    {
        static void Main(string[] args)
        {
			var room = new BigRoom();
			room.DiscoLight();
			room.NightLight();
			room.WiteFullLight();
			room.TurnOff();

            Console.ReadLine();
        }
    }
}
