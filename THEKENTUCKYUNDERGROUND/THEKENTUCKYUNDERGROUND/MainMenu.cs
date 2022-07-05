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
                Say("1", "Book a Tunnel Ticket:");
                Say("2", "Buying in Euro's? No problem! Convert to see cost in Euro's:");
                Say("3", "New Routes coming soon! See Routes & Countdown:");
                Say("4", "Quit:");

                Console.WriteLine();
                string option = Console.ReadLine()!;
                if (option == "1")
                {
                    UndergroundRoutes[] allRoutes = UnderGroundRepository.InitializeRoutes();
                    Console.Clear();
                    Console.WriteLine("Where would you like to travel to?\n");
                    Console.WriteLine("Available Destinations: Covington, Lexington, Louisville, Owensboro?\n");
                    string location = Console.ReadLine()!;
                    Console.Clear();

                    UndergroundRoutes[] routes = FindTunnelsTo(allRoutes, location);

                    if (routes.Length > 0)
                        foreach (UndergroundRoutes route in routes)
                            Console.WriteLine($"Travel through Tunnel {route}\n");

                    else
                        Console.WriteLine($"No Tunnels travel to {location}! Please type N to cancel your request.\n");

                    Console.WriteLine("Would you like to buy a Tunnel Ticket?\n");

                    Console.WriteLine("Please Type Y for: Yes");
                    Console.WriteLine("Please Type N for: No");
                    var response = Console.ReadLine();
                    Console.WriteLine(response);
                    if (response == "Y")
                        Console.WriteLine("1) For the first route option, please type 1");
                    if (response == "Y")
                        Console.WriteLine("2) For the second route option, please type 2");

                    Console.WriteLine(response);
                    if (response == "N" || response =="n")
                        Console.WriteLine("No Ticket Purchased: Have a great day!");

                    var response2 = Console.ReadLine();
                    if (response2 == "1" || response2 == "2")
                        Console.WriteLine("Ticket Purchased: Pick up at tunnel entrance");

                }

                else if (option == "2")
                {
                    Console.Clear();
                    float dollars, conversion_rate, euros;
                    conversion_rate = .98f;
                    Console.WriteLine("All Tunnel Tickets cost $20USD. To see converion from Euro's to US Dollars type 20:");
                    dollars = float.Parse(Console.ReadLine());
                    euros = dollars * conversion_rate;
                    Console.WriteLine("Tunnel Ticket cost in Euros: " + euros);
                    Console.ReadLine();
                }

                else if (option == "3")
                {
                    Console.Clear();
                    Console.Write("Our Future Routes:\n");
                    Console.WriteLine();

                    Console.WriteLine("Newport to Owensboro:");
                    var currentDate = DateTime.Now;
                    var endDate = new DateTime(2022, 10, 30);
                    double remainingDays = endDate.Subtract(currentDate).TotalDays;
                    Console.WriteLine("Days until completion: {0}\n", remainingDays);
             
                    Console.WriteLine("Georgetown to Bowling Green");
                    var currentDate1 = DateTime.Now;
                    var endDate1 = new DateTime(2022, 12, 10);
                    double remainingDays1 = endDate1.Subtract(currentDate1).TotalDays;
                    Console.WriteLine("Days until completion: {0}\n", remainingDays1);

                    Console.WriteLine("Florence to Louisville");
                    var currentDate2 = DateTime.Now;
                    var endDate2 = new DateTime(2023, 07, 28);
                    double remainingDays2 = endDate2.Subtract(currentDate2).TotalDays;
                    Console.WriteLine("Days until completion: {0}\n", remainingDays2);

                    Console.WriteLine("Richmond to Lexington");
                    var currentDate3 = DateTime.Now;
                    var endDate3 = new DateTime(2023, 12, 15);
                    double remainingDays3 = endDate3.Subtract(currentDate3).TotalDays;
                    Console.WriteLine("Days until completion: {0}\n", remainingDays3);
                    Console.ReadLine();
                }

                else if (option == "4")
                {
                    ConsoleExit.Exit();
                }

                else
                {
                    Console.WriteLine("Error: Please select a valid option!");
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