using System;

namespace Cheers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Whach yo name is!?");
			var name = Console.ReadLine ().ToUpper ();
			var anLetters = "AEFHILMNORSX";	
			foreach (char c in name) 
			{
				if (anLetters.Contains(c))
				{
					Console.WriteLine("Give me an ...  {0}", 1);
				}
				else Console.WriteLine("Give me a ..... {0}", 1);
			}
			Console.WriteLine("{0} is ... GRAND", name);
			Console.ReadLine();

		}

	}
}


