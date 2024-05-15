using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Creating a new job instance named job1
        Job job1 = new Job();

        // Setting the member variables using the dot notation 
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        
        // Creating a new job instance named job2
        Job job2 = new Job();

        // Setting the member variables using the dot notation 
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        
        // Creating a new instance of the Resume class named myResume
        Resume myResume = new Resume();

        // Setting the member variable to store the name
        myResume._name = "Anani Sam";

        // Adding the two jobs created earlier, to the list of jobs in the resume object.
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Calling the Display method from the Resume class to display the 
        // name and all the jobs in one line.
        myResume.Display();



    }
}