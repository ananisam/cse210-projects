using System.IO;
public class Journal
{
    // Creating the member variable for the list of Entries and initializing it to a new list
    public List<Entry> _entries = new List<Entry>();
    
    // A method that Adds the entries
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
     // A method that iterate through each entry instance in the list of entries and display them
     // by calling the Display method in the Entry class.
     // Displays all the entries
    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }   
    }

    // A method that Saves the entries to file
    public void SaveToFile(string filename)
    {
        // A message to alert the user of the activity
        Console.WriteLine("Saving to file...");

        filename = "journal.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {

            foreach (Entry e in _entries)
            {
                outputFile.WriteLine(e);
            }
        }

    }

    // A method that Loads the entries from file
    public void LoadFromFile(string filename)
    {
        filename = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string prompt = parts[0];
            string response = parts[1];
        }
    }
}