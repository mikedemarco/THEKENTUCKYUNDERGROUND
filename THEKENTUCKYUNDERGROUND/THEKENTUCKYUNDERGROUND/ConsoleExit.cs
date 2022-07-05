using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THEKENTUCKYUNDERGROUND
{
    internal class ConsoleExit
    {
        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Are you sure you want to Exit? (Y/N)");
            Console.WriteLine();

            string exit = Console.ReadLine();

            if (exit == "Y")
            {
                Environment.Exit(0);
            }
        }

    }

}