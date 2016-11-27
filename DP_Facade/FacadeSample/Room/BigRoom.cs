using System;
using Lamps;

namespace FacadeSample
{
	public class BigRoom
	{
		public Lamp[] WhiteLamps;
		public Lamp[] RedLamps;
		public Lamp[] GreenLamps;
		public Lamp[] YellowLamps;
		public Lamp[] BlueLamps;

		public BigRoom()
		{
			InstalWhiteLamps();
			InstalRedLamps();
			InstalGreenLamps();
			InstalYellowLamps();
			InstalBlueLamps();
		}

		#region light modes

		public void WiteFullLight() {
			Console.WriteLine("Full light");

			foreach (var lamp in WhiteLamps)
			{
				lamp.TurnOn(10);
			}
		}


		public void NightLight()
		{
			Console.WriteLine("Night light");
			foreach (var lamp in WhiteLamps)
			{
				lamp.TurnOn(5);
			}

			foreach (var lamp in YellowLamps)
			{
				lamp.TurnOn(3);
			}
		}


		public void DiscoLight()
		{
			Console.WriteLine("Disco light");
			WhiteLamps[0].TurnOn(6);
			WhiteLamps[2].TurnOn(7);
			WhiteLamps[4].TurnOn(6);

			foreach (var lamp in YellowLamps)
			{
				lamp.TurnOn(7);
			}

			foreach (var lamp in GreenLamps)
			{
				lamp.TurnOn(7);
			}

			foreach (var lamp in RedLamps)
			{
				lamp.TurnOn(6);
			}

			foreach (var lamp in BlueLamps)
			{
				lamp.TurnOn(6);
			}
		}


		public void TurnOff()
		{
			Console.WriteLine("The light is off");
			foreach (var lamp in WhiteLamps)
			{
				lamp.TurnOff();
			}

			foreach (var lamp in GreenLamps)
			{
				lamp.TurnOff();
			}

			foreach (var lamp in RedLamps)
			{
				lamp.TurnOff();
			}

			foreach (var lamp in BlueLamps)
			{
				lamp.TurnOff();
			}
		}


		#endregion light modes

		#region private methods

		private void InstalWhiteLamps()
		{
			WhiteLamps = new Lamp [5]{ 
				new Lamp(1, LampColor.white),
			    new Lamp(2, LampColor.white),
				new Lamp(3, LampColor.white),
				new Lamp(4, LampColor.white),
				new Lamp(5, LampColor.white)
			};
		}


		private void InstalRedLamps()
		{
			RedLamps = new Lamp[3]{
				new Lamp(1, LampColor.red),
				new Lamp(2, LampColor.red),
				new Lamp(3, LampColor.red)
			};
		}


		private void InstalGreenLamps()
		{
			GreenLamps = new Lamp[3]{
				new Lamp(1, LampColor.green),
				new Lamp(2, LampColor.green),
				new Lamp(3, LampColor.green)
			};
		}


		private void InstalYellowLamps()
		{
			YellowLamps = new Lamp[3]{
				new Lamp(1, LampColor.yellow),
				new Lamp(2, LampColor.yellow),
				new Lamp(3, LampColor.yellow)
			};
		}


		private void InstalBlueLamps()
		{
			BlueLamps = new Lamp[3]{
				new Lamp(1, LampColor.blue),
				new Lamp(2, LampColor.blue),
				new Lamp(3, LampColor.blue)
			};
		}

		#endregion private methods
	}
}
