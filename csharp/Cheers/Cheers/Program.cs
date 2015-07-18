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

			Console.WriteLine ("When yo birfday is!?");
			var bday = Console.ReadLine ();

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
			Console.WriteLine(bday);

			TimeSpan conversion = DateTime.Now.Subtract(DateTime.Parse(bday));
			Console.WriteLine(conversion);

			double daysAgo = conversion.TotalDays;
			Console.WriteLine("{0} was {1} days ago",
				DateTime.Parse(bday),
				daysAgo.ToString("0"));
			//Console.WriteLine(Convert.ToDateTime(conversion));
			//Console.WriteLine("Your birfday is in ", today.Subtract(thisDate), "days");


	}
}

}
