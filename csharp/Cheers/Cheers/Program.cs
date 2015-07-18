using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.IO;

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
					Console.WriteLine("Give me an {0}", c);
				}
				else Console.WriteLine("Give me a {0}", c);
			}
			Console.WriteLine("{0} is GRAND", name);
			Console.ReadLine();

		}

	}
}


