using System;

namespace VariableInHexFormat
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var hexFormat = Console.ReadLine();

			Console.WriteLine(Convert.ToInt32(hexFormat, 16));
		}
	}
}
