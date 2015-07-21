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

			TimeSpan conversion = DateTime.Now.Subtract(DateTime.Parse(bday));
			double daysAgo = conversion.TotalDays;
			Console.WriteLine(daysAgo);

			int difference = 0; 

			//DateTime conversion2 = DateTime.Now.Add(DateTime.Parse(bday));
			DateTime lastDay = new DateTime(2015,12,31);
			if (DateTime.Today < DateTime.Parse(bday)) {
				difference = DateTime.Parse(bday).DayOfYear - DateTime.Today.DayOfYear;
				
			} else {
			difference = lastDay.DayOfYear - DateTime.Today.DayOfYear + DateTime.Parse(bday).DayOfYear;
			}



			//TimeSpan convert2 = DateTime.Now.AddDays(DateTime.Parse(bday));
			//double daysUntil = convert2.TotalDays;

			//string a = String.Concat(DateTime.Parse(bday), " was ", daysAgo.ToString());
				//Console.WriteLine(a);

			//string b = String.Concat(DateTime.Parse (bday), " is in ", );
			//string b = "{0} was {1} days ago", DateTime.Parse(bday),daysUntil.ToString("0"));

			//int value = daysAgo.ToString() == "0" ? a : b;

			//Console.WriteLine(value);

			//Console.WriteLine("{0} was {1} days ago", DateTime.Parse(bday),daysAgo.ToString("0"));

			//Console.WriteLine(Convert.ToDateTime(conversion));
			Console.WriteLine("Your birfday is in {0} days ", difference);


}
}

}
