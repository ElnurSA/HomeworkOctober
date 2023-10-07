using System;
namespace PracticeOctober.Models
{
	internal class Car
	{
		public int speed;
		public string color;
		private string vin = "sadasdasdaass";
		public string Vin
		{
			get
			{
				if(speed > 450)
				{
					return vin;
				}
				return null;
			}
			set
			{
				vin = value;

			}
		}
	}
}

