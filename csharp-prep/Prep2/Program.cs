using System;

class Program
{
    static void Main(string[] args)
    {
        // Asking the user for the grade percentage and converting it to integer.
        Console.Write("Enter the grade percentage ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        // Declaring a variable to hold the grade letter
        string letter = "";

        // Setting the conditions to find the grade letter
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage  >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage  >= 70)
        {
            letter = "C"; 
        }
        else if (gradePercentage  >= 60)
        {
            letter = "D"; 
        }
        else 
        {
            letter = "F"; 
        }

        /* Setting the condition to determine if the user passed the course or not
           and displaying the appropriate messages. First, a variable to hold the pass message
        */  

        string passMessage = "";
        
        if (gradePercentage >= 70)
            {
                passMessage = "Congratulations! You've passed.";
            }
        else
            {
                passMessage = "You didn't pass. Give it another try.";
            }

        // Stretch Challenge 1: Adding the + and - sign to the grade based on last digit
        // Declaring for the sign and the last digit.
        string sign = "";

        int lastDigit = gradePercentage % 10;

        // Setting the conditions to generate the signs
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
    
        // Stretch Challenge 2: Avoiding A+, F+ and F-
        if (gradePercentage >= 93)
        {
            sign = "";
        }
        
        // Stretch Challenge 3: Avoiding F+ or F-
        if (letter == "F")
        {
           sign = ""; 
        }
    
        // Displaying the grade and sign to the user.
        Console.WriteLine($"Your grade is {letter}{sign}");

        // Displaying the pass message to the user.
        Console.WriteLine(passMessage);
        
    }

}