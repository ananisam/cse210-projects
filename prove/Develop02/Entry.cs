public class Entry
{
    // Creating the member variables
    public string _date;
    public string _promptText;
    public string _entryText;
    
    // Member function to display the entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}