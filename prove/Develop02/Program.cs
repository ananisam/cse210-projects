using System;

class Program
{
    static void Main(string[] args)
    {
        // Displaying the Welcome Message and the Menu
        Console.WriteLine("Welcome to the Journal Program!");

        // Declaring and initializing variables for the menu options.
        string menuOption = "";
        
        // I used string variables to avoid errors if non-numerical entries are mistakenly entered.
        
        // Keep repeating the menu options until the user chooses 'quit'.
        while (menuOption != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            // Declaring variable to accept the user response
            menuOption = Console.ReadLine();

            // Coding the decisions to perform the appropriate action when the user chooses one of the menu options.
            if (menuOption == "1")
            {

            }
        



        }


        
    }
}