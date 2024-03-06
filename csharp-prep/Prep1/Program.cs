using System;

class Program
{
    static void Main(string[] args)
    {
        // Asking the user for his or her first name and the storing it in a variable
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Asking the user for his or her Last Name and the storing it in a variable
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Inserting a blank line
        Console.WriteLine();
        
        // Displaying the user input to the console
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

    }
}