using System;

namespace Lamps
{
	public class Lamp
	{
		private byte Number;
		private LampColor lampColor;
		private byte Brightness { get; set; }

		public Lamp(byte number, LampColor color)
		{
			lampColor = color;
			Number = number;
		}

		public void TurnOn(byte brightness)
		{
			Brightness = brightness;
			Console.WriteLine($"The {lampColor} lamp [{Number}] is turned on with {brightness} brightness.");
		}

		public void TurnOff()
		{
			Brightness = 0;
			Console.WriteLine($"The {lampColor} lamp [{Number}] is off");
		}

	}

	public enum LampColor
	{
		white,
		yellow,
		green,
		red,
		blue
	}
}
