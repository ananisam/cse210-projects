public class Resume
{
    // Creating the member variables for the person's name.
    public string _name = "";
        
    // Creating the member variable for the list of Jobs and initializing it to a new list
    public List<Job> _jobs = new List<Job>();    
    
    // A method that displays the person's name and then iterate through each Job 
    // instance in the list of jobs and display them.
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        
        foreach (Job j in _jobs)
        {
            j.DisplayJobDetails();
        }   
    }
}