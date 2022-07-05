using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THEKENTUCKYUNDERGROUND
{
    class MainMenu
    {
        public static void Menu()
        {
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("Please choose one of the following options.");
                Console.WriteLine();
                Say("1", "Book a tunnel ticket");
                Say("2", "Buying in Euro's? Convert now");
                Say("3", "Quit");

                Console.WriteLine();
                string option = Console.ReadLine();
                if (option == "1")
                {
                    UndergroundRoutes[] allRoutes = UnderGroundRepository.InitializeRoutes();

                    Console.WriteLine("Where would you like to travel to?\n");
                    Console.WriteLine("Available Destinations: Covington, Lexington, Louisville, Owensboro?\n");
                    string location = Console.ReadLine()!;

                    UndergroundRoutes[] routes = FindTunnelsTo(allRoutes, location);

                    if (routes.Length > 0)
                        foreach (UndergroundRoutes route in routes)
                            Console.WriteLine($"Travel through tunnel {route}");

                    else
                        Console.WriteLine($"No tunnels travel to {location}! Please type N to cancel your request.\n");

                    Console.WriteLine("Would you like to buy a tunnel ticket?\n");

                    Console.WriteLine("Please Type Y for: Yes");
                    Console.WriteLine("Please Type N for: No");
                    var response = Console.ReadLine();
                    Console.WriteLine(response);
                    if (response == "Y")
                        Console.WriteLine("1) For the first route option, please type 1");
                    if (response == "Y")
                        Console.WriteLine("2) For the second route option, please type 2");
                    if (response == "Y")

                    Console.WriteLine(response);
                    if (response == "N")
                        Console.WriteLine("No Ticket Purchased: Have a great day!");

                    var response2 = Console.ReadLine();
                    if (response2 == "1")
                        Console.WriteLine("Please enter e-mail address to confirm your tunnel ticket");
                    if (response2 == "2")
                        Console.WriteLine("Please enter e-mail address to confrim your tunnel ticket");
                }

                else if (option == "2")
                {
                    float dollars, conversion_rate, euros;
                    conversion_rate = 1.06f;
                    Console.WriteLine("All tunnel tickets cost $20USD. To convert to EUR type 20:");
                    dollars = float.Parse(Console.ReadLine());
                    euros = dollars * conversion_rate;
                    Console.WriteLine("Total amount in Euros: " + euros);
                    Console.ReadLine();

                    Console.WriteLine("Press any key to return back to main menu...");
                    Console.ReadKey();
                }

                else if (option == "3")
                {
                    ConsoleExit.Exit();
                }

                else
                {
                    Console.WriteLine("Error, Please select a valid option!");
                    Thread.Sleep(1000);
                }
            }
        }

        private static UndergroundRoutes[] FindTunnelsTo(UndergroundRoutes[] routes, string location)
        {
            return Array.FindAll(routes, route => route.Serves(location));
        }



        public static void Say(string prefix, string message)
        {
            Console.Write("(");
            Console.Write(prefix);
            Console.Write(") " + message);
            Console.WriteLine();
        }

    }
}