using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data.SQLite;

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
                Say("5", "See Days and Hours of Operation");
                Say("6", "Rail Names and Seat Capacity Database:");
                Say("7", "When you buy tickets, we donate to charity! See amount:");
                Say("8", "Quit");
                

                Console.WriteLine();
                string option = Console.ReadLine()!;
                if (option == "1")
                {
                    {
                        UndergroundRoutes[] allRoutes = UnderGroundRepository.InitializeRoutes();
                        Console.Clear();
                        Console.WriteLine("Where would you like to travel to? Please type one of our destinations below to see routes:\n");
                        Console.WriteLine("Available Destinations: COVINGTON, FRANKFORT, LEXINGTON, LOUISVILLE, NEWPORT, OWENSBORO?\n");
                        string input = Console.ReadLine()!;
                        string location = input.ToUpper();
                        Console.Clear();
                        Console.WriteLine("Available Tunnel Routes:\n");
                        UndergroundRoutes[] routes = FindTunnelsTo(allRoutes, location);

                        if (routes.Length > 0)
                            foreach (UndergroundRoutes route in routes)
                                Console.WriteLine($"You can travel through Tunnel {route}\n");
                        else
                            Console.WriteLine($"No Tunnels travel to {location}! \n");
                        Console.WriteLine("Press any key to go back to main menu.\n");
                        Console.ReadKey();
                    }
                }
                else if (option == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Welcome! All Tunnel Tickets are $20. Please type 20:");
                    string numInput = Console.ReadLine()!;
                    Console.WriteLine(numInput);

                    int num = 0;
                    Int32.TryParse(numInput, out num);
                    Console.Clear();

                    if (num < 20)
                    {
                        Console.WriteLine("Sorry that's not enough money; Please try again with $20 or more.");
                    }
                    else if (num == 20)
                    {
                        Console.WriteLine("Ticket Purchased! Please fill out the following information to get your ticket!\n");
                        string name;
                        Console.Write("Please enter your name that you wish to be printed on your ticket: ");
                        name = Console.ReadLine()!;
                        Console.WriteLine();
                        Console.WriteLine("*Thank you {0}; your ticket has been confirmed.*\n", name);
                        Console.WriteLine("Enjoy your travel!");

                    }
                    else
                    {
                        int change = num - 20;
                        Console.WriteLine("Ticket Purchased! " + change + " dollars is your change.  Please fill out the following information to get your ticket!\n");
                        string name;
                        Console.Write("Please enter your name that you wish to be printed on your ticket: ");
                        name = Console.ReadLine()!;
                        Console.WriteLine();
                        Console.WriteLine("*Thank you {0}; your ticket has been confirmed.*\n", name);
                        Console.WriteLine("Enjoy your travel!");
                    }
                    Console.ReadKey();
                }
                else if (option == "3")
                {
                    Console.Clear();
                    const decimal conversion_rate = 1.01m;
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
                    var endDate = new DateTime(2022, 11, 30);
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

                    Console.WriteLine("Louisville to Frankfort");
                    var currentDate4 = DateTime.Now;
                    var endDate4 = new DateTime(2024, 10, 18);
                    double remainingDays4 = endDate4.Subtract(currentDate4).TotalDays;
                    Console.WriteLine("Days until completion: {0:F2}\n", remainingDays4);
                    Console.ReadLine();
                }
                else if (option == "5")
                {
                    // LIST FEATURE
                    List<string> time = new List<string>();
                    time.Add("4am-11pm");
                    time.Add("5am-11pm");
                    time.Add("5am-11:30pm");
                    time.Add("5am-10:30pm");
                    time.Add("5:30am-11:30pm");
                    time.Add("10am-11:30pm");
                    time.Add("10am-10pm");
                    Console.Clear();

                    Console.WriteLine("Please choose the number corresponding to one of the following days:\n");
                    Say("1", "Monday:");
                    Say("2", "Tuesday:");
                    Say("3", "Wednesday:");
                    Say("4", "Thursday:");
                    Say("5", "Friday:");
                    Say("6", "Saturday:");
                    Say("7", "Sunday:");


                    Console.WriteLine();
                    string option1 = Console.ReadLine()!;
                    Console.Clear();
                    if (option1 == "1")

                    Console.WriteLine("Monday's Operation Hours:" + time[0]);
                   
                    if (option1 == "2")
                    Console.WriteLine("Tuesday's Operation Hours:" + time[1]);
                    
                    if (option1 == "3")
                    Console.WriteLine("Wednesday's Operation Hours:" + time[2]);
                   
                    if (option1 == "4")
                    Console.WriteLine("Thursday's Operation Hours:" + time[3]);
                   
                    if (option1 == "5")
                    Console.WriteLine("Friday Operation Hours:" + time[4]);
                   
                    if (option1 == "6")
                    Console.WriteLine("Saturday Operation Hours:" + time[5]);
                  
                    if (option1 == "7")
                    Console.WriteLine("Sunday Operation Hours:" + time[6]);
                    Console.ReadKey();
                }                
                else if (option == "6")
                {
                    Database databaseObject = new Database();
                    // Database Requirement

                    // **Insert into Database**
                    //string query = "INSERT INTO HighSpeedRails ('name', 'seats') VALUES (@name, @seats)";
                    //SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
                    //databaseObject.OpenConnection();
                    //myCommand.Parameters.AddWithValue("@name", "Hawk");
                    //myCommand.Parameters.AddWithValue("@seats", "One Hundred and Twenty");
                    //var result = myCommand.ExecuteNonQuery();
                    //databaseObject.CloseCOnnection();


                    //Console.WriteLine("Rows Added : {0}", result);
                    //Console.ReadKey();


                    // Feature: Query your database using a raw SQL query, not EF
                    Console.Clear();
                    string query = "SELECT * FROM HighSpeedRails";
                    SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
                    databaseObject.OpenConnection();
                    SQLiteDataReader result = myCommand.ExecuteReader();
                    myCommand.Parameters.AddWithValue("@seats", "One Hundred and Twenty");
                    if (result.HasRows)
                    {
                        Console.Clear();
                        Console.WriteLine("Type 1 to see High Speed Rail Names OR Type 2 to see High Speed Rails with the amount of Seats.");
                        string numInput1 = Console.ReadLine()!;
                        Console.WriteLine(numInput1);

                        int num1 = 0;
                        Int32.TryParse(numInput1, out num1);
                        Console.Clear();
                        while (result.Read())
                        {
                            if (num1 == 1)
                            {
                                Console.WriteLine("High Speed Rail Name: {0}", result["name"]);
                            }
                            else if (num1 > 1)
                            {
                                Console.WriteLine("High Speed Rail Name: {0} - Seats: {1}", result["name"], result["seats"]);
                            }
                        }
                    }
                      databaseObject.CloseCOnnection();
                      Console.ReadLine();
                }
                else if (option == "7")
                {
                    Console.Clear();
                    {
                        var chaCalculations = new List<BaseCharityCalculator>
                    {
                        new SPCA(new CharityReport {Id = 1, Name = "Cha1", Level = "SPCA", Rate = 50, Tickets = 190 }),
                        new HabitatForHumanity(new CharityReport {Id = 2, Name = "Cha2", Level = "HabitatForHumanity", Rate = 80, Tickets = 210 }),
                    };

                        var calculator = new CharityCalculator(chaCalculations);
                        Console.WriteLine($"Sum of all the charitable donations are {calculator.CalculateTotalSalaries()} dollars!");
                        Console.ReadLine();
                    }
                }
                else if (option == "8")
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