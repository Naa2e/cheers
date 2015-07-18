using System;

namespace Cheers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Whach yo name is!?");
			wstring name = Console.ReadLine ().ToUpper ();
			wstring anLetters = "AEFHILMNORSX";	
			foreach (char c in name) 
			{
				if (anLetters.Contains(c))
				{
					Console.WriteLine("Give me an ...  {0}");
				}
				else Console.WriteLine("Give me a ..... {0}");
			}
			Console.WriteLine("{0} is ... GRAND", name);
			Console.ReadLine();

		}

	}
}


