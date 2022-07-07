using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THEKENTUCKYUNDERGROUND;

class Program
{
	static void Main(string[] args)
	{
		Console.Title = "The Kentucky Underground";
		Console.WriteLine("Thank you for choosing The Kentucky Underground!\n");
		Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy HH:mm\n"));
		Console.WriteLine("Ready to travel? (Type any key to continue.)");
		Console.ReadKey(true);
		MainMenu.Menu();
	}
}

