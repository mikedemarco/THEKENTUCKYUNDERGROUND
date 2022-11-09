# THEKENTUCKYUNDERGROUND
THEKENTUCKYUNDERGROUND
Project: In a climate of alarming energy costs, lack of mass public transportation, and congested highway system The Kentucky Underground seeks to elevate the issues. The Kentucky Underground, is a futuristic application coded in C# that allows customers to purchase tickets for pickup and view direct hypothetical tunnel routes that are burrowed under the Earth’s surface within the state of Kentucky.  The Kentucky Underground will be implemented on Microsoft’s Visual Studio and will utilize Visual Studio’s built-in command console. Michael De Marco will be the student coding The Kentucky Underground.

The project will include the following features:

1)	Creation of a list. The Kentucky Underground populates the days of the week along with their respective operation times. The list takes advantage of populating the list with several values and retrives at least one value and uses it in my program. (Option 5 on MainMenu.cs).
2)	The Kentucky Underground utilizes 2 SOLID principals. 1) The ConsoleExit.cs displays the SOLID Principal: Single Responsibility Principle (The ConsoleExit.cs handles a single concern). 2) The CharityCalulator.cs uses the Solid Feature: Open Closed Principle. The CharityCalulator is closed for modification and opened for an extension if needed.
3)	The Kentucky Underground utlizes a Query your database using a raw SQL query, not EF. (Located in MainMenu.cs)
4)  The Kentucky Underground creates a generic class and uses it. (CharityCalculator.cs)

**Additional NuGet Packages needed to run application:**
1) The database was built using SQlite (NuGet Package: System.Data.SQLite.Core) and was built with the assitance of DB Browser for SQLite: https://sqlitebrowser.org/
2) NuGet Package: System.IO

**If uusing Visual Stuido Code: Run the project from the bin/Debug/net6.0 folder.**

The Kentucky Underground system uses the following: 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data.SQLite;

The application will work on: Linux, macOS and Windows as well.