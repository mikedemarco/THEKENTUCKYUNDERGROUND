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
		// Admission priceing.  Need to implement
		List<String> admissionPrice = new List<String>();
		{
			admissionPrice.Add("$20");
			admissionPrice.Add("$30");
			admissionPrice.Add("$40");
			admissionPrice.Add("$50");
			admissionPrice.Add("60");
		}
		if (admissionPrice.Contains("1"))
			Console.WriteLine(admissionPrice);

		bool continueBooking = true;
		while (continueBooking == true)
		{
			UndergroundRoutes[] allRoutes = UnderGroundRepository.InitializeRoutes();
			Console.WriteLine("Thank you for choosing Kentucky Underground!");
			Console.WriteLine();
			Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
			Console.WriteLine();
			Console.WriteLine("Where would you like to travel to?");
			Console.WriteLine("Available Destinations: Covington, Lexington, Louisville, Owensboro?");
			Console.WriteLine();
			string location = Console.ReadLine()!;

			UndergroundRoutes[] routes = FindTunnelsTo(allRoutes, location);

			if (routes.Length > 0)
				foreach (UndergroundRoutes route in routes)
					Console.WriteLine($"Travel through tunnel {route}");

			else
				Console.WriteLine($"No tunnels travel to {location}! Please type N to cancel your request.");

			Console.WriteLine();
			Console.WriteLine("Would you like to buy a tunnel ticket?");

			Console.WriteLine("Please Type Y for: Yes");
			Console.WriteLine("Please Type N for: No");
			var response = Console.ReadLine();
			Console.WriteLine(response);
			if (response == "Y")
				Console.WriteLine("1) For the first route option, please type 1");
			if (response == "Y")
				Console.WriteLine("2) For the second route option, please type 2");

			Console.WriteLine(response);
			if (response == "N")
				Console.WriteLine("No Ticket Purchased: Have a great day!");

			var response2 = Console.ReadLine();
			if (response2 == "1")
				Console.WriteLine("Please enter e-mail address to confirm your tunnel ticket");
			if (response2 == "2")
				Console.WriteLine("Please enter e-mail address to confrim your tunnel ticket");
		}
	}

	public static UndergroundRoutes[] FindTunnelsTo(UndergroundRoutes[] routes, string location)
	{
		return Array.FindAll(routes, route => route.Serves(location));
	}
}
