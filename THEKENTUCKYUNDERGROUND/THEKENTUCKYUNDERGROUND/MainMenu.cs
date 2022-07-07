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
                Say("1", "View Tunnel Routes and Destinations:");
                Say("2", "Book a Tunnel Ticket:");
                Say("3", "Coming in from Europe? No Problem! See how much tickets cost in Euros:");
                Say("4", "New Routes coming soon! See Routes & Countdown:");
                Say("5", "Quit:");

                Console.WriteLine();
                string option = Console.ReadLine()!;
                if (option == "1")               
                {
                    {
                        UndergroundRoutes[] allRoutes = UnderGroundRepository.InitializeRoutes();
                        Console.Clear();
                        Console.WriteLine("Where would you like to travel to? Please type one of our destinations below to see routes:\n");
                        Console.WriteLine("Available Destinations: COVINGTON, LEXINGTON, LOUISVILLE, OWENSBORO?\n");
                        string input = Console.ReadLine()!;
                        string location = input.ToUpper();
                        Console.Clear();

                        UndergroundRoutes[] routes = FindTunnelsTo(allRoutes, location);

                        if (routes.Length > 0)
                            foreach (UndergroundRoutes route in routes)
                                Console.WriteLine($"Travel through Tunnel {route}\n");
                        else
                            Console.WriteLine($"No Tunnels travel to {location}! Press any key to continue back to main menu.\n");

                        Console.ReadKey();                  
                    }
                }
                else if (option == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Welcome! All Tunnel Tickets are $20. Please insert cash.");

                    int cash = Convert.ToInt32(Console.ReadLine());

                    if (cash < 20)
                    {
                        Console.WriteLine("Sorry that's not enough money; Here is your money back.");
                    }
                    else if (cash == 20)
                    {
                        Console.WriteLine("Ticket Purchased! Please fill out the following information to get your ticket!\n");

                        string name;

                        int age;

                        int birthyear;

                        Console.Write("Please enter your name: ");

                        name = Console.ReadLine()!;

                        Console.Write("Please enter your age: ");

                        age = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Please enter the year you born?: ");

                        birthyear = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        Console.WriteLine("Thank you {0}.", name);

                        Console.WriteLine("Age is {0}.", age);

                        Console.WriteLine("Birth year is {0}.\n", birthyear);

                        Console.WriteLine("Enjoy your travel!");

                    }
                    else
                    {
                        int change = cash - 20;
                        Console.WriteLine("Ticket Purchased! " + change + " dollars is your change.  Please fill out the following information to get your ticket!\n");

                        string name;

                        int age;

                        int birthyear;

                        Console.Write("Please enter your name: ");

                        name = Console.ReadLine()!;

                        Console.Write("Please enter your age: ");

                        age = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Please enter the year you born?: ");

                        birthyear = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        Console.WriteLine("Thank you {0}.", name);

                        Console.WriteLine("Age is {0}.", age);

                        Console.WriteLine("Birth year is {0}.\n", birthyear);

                        Console.WriteLine("Enjoy your travel!");
                    }
                    Console.ReadKey();
                }
                else if (option == "3")
                {
                    Console.Clear();
                    const decimal conversion_rate = .98m;
                    decimal dollars = 0.00m;
                    do
                    {
                        Console.WriteLine("All Tunnel Tickets cost $20 USD. To see and convert to EUROs, please type 20:");
                    }
                    while (!decimal.TryParse(Console.ReadLine(), out dollars));
                    Console.WriteLine("${0}USD are equal to {1} Euros",
                    dollars, dollars * conversion_rate);
                    Console.ReadLine();
                }
                else if (option == "4")
                {
                    Console.Clear();
                    Console.Write("Our Future Routes:\n");
                    Console.WriteLine();

                    Console.WriteLine("Newport to Owensboro:");
                    var currentDate = DateTime.Now;
                    var endDate = new DateTime(2022, 10, 30);
                    double remainingDays = endDate.Subtract(currentDate).TotalDays;
                    Console.WriteLine("Days until completion: {0:F2}\n", remainingDays);

                    Console.WriteLine("Georgetown to Bowling Green");
                    var currentDate1 = DateTime.Now;
                    var endDate1 = new DateTime(2022, 12, 10);
                    double remainingDays1 = endDate1.Subtract(currentDate1).TotalDays;
                    Console.WriteLine("Days until completion: {0:F2}\n", remainingDays1);

                    Console.WriteLine("Florence to Louisville");
                    var currentDate2 = DateTime.Now;
                    var endDate2 = new DateTime(2023, 07, 28);
                    double remainingDays2 = endDate2.Subtract(currentDate2).TotalDays;
                    Console.WriteLine("Days until completion: {0:F2}\n", remainingDays2);

                    Console.WriteLine("Richmond to Lexington");
                    var currentDate3 = DateTime.Now;
                    var endDate3 = new DateTime(2023, 12, 15);
                    double remainingDays3 = endDate3.Subtract(currentDate3).TotalDays;
                    Console.WriteLine("Days until completion: {0:F2}\n", remainingDays3);
                    Console.ReadLine();
                }
                else if (option == "5")
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