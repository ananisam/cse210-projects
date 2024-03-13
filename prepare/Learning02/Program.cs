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
        
        // Calling the method (member function) to display the job details
        job1.DisplayJobDetails();

        // Creating a new job instance named job2
        Job job2 = new Job();

        // Setting the member variables using the dot notation 
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        
        // Calling the method (member function) to display the job details
        job2.DisplayJobDetails();

        // Creating a new instance of the Resume class named resume1
        Resume resume1 = new Resume();

        // Setting the member variable for store the name
        resume1._name = "Anani Sam";

        // Adding the two jobs you created earlier, to the list of jobs in the resume object.
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        // Calling the Display method from the Resume class to display the 
        // name and all the jobs in one line.
        resume1.Display();



    }
}