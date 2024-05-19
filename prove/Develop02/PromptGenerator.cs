
using System.Collections.Generic;

public class PromptGenerator
{
    // Creating the member variable for the list of prompts and initializing it to a new list
    public List<string> _prompts = new List<string>
    {
    // Adding the prompts to the list
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"
    };

    // A method to get random prompts
    public string GetRandomPrompt()
    {
        /* Creating an instance of the Random class, and then using it to
        generate a random string (prompts) from a list of prompts using the items indexes.
        */
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        return _prompts[index];
    }
}