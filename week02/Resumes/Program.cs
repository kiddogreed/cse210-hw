using System;

// This is the main entry point of the program
class Program
{
    static void Main(string[] args)
    {
        // Print a welcome message to the user
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // Create a job for BYU and fill in the details
        Job job1 = new Job {
            _company = "BYU", // The company name
            _jobTitle = "Software Engineer", // The job title
            _startYear = 2020, // The year the job started
            _endYear = 2024 // The year the job ended
        };
        // Show the details of job1 on the screen
      //  job1.Display();

        // Create a job for Google
        Job job2 = new Job {
            _company = "Google",
            _jobTitle = "Senior Software Engineer",
            _startYear = 2024,
            _endYear = 2027 // "Present" means the job is ongoing
        };
        // Show the details of job2
      //  job2.Display();

        // Create a job for Microsoft
        Job job3 = new Job {
            _company = "Microsoft",
            _jobTitle = "Principal Software Engineer",
            _startYear = 2025,
            _endYear = 2027
        };
       // job3.Display();

        Job job4 = new Job {
            _company = "Amazon",
            _jobTitle = "Software Development Manager",
            _startYear = 2027,
            _endYear = 2029
        };
        //job4.Display();

         Job job5 = new Job {
            _company = "Facebook",
            _jobTitle = "Director of Software Engineering",
            _startYear = 2029,
            _endYear = 2031
        };
        //job5.Display();

         Job job6 = new Job {
            _company = "Apple",
            _jobTitle = "Vice President of Software Engineering",
            _startYear = 2031,
            _endYear = 2033
        };
       // job6.Display();

         Job job7 = new Job {
            _company = "Netflix",
            _jobTitle = "Chief Technology Officer",
            _startYear = 2033,
            _endYear = 2035
        };
       // job7.Display();

         Job job8 = new Job {
            _company = "Tesla",
            _jobTitle = "Chief Executive Officer",
            _startYear = 2035,
            _endYear = 2037
        };
       // job8.Display();

         Job job9 = new Job {
            _company = "SpaceX",
            _jobTitle = "Founder and CEO",
            _startYear = 2037,
            _endYear = 2040
        };
       // job9.Display();

         Job job10 = new Job {
            _company = "OpenAI",
            _jobTitle = "Chairman of the Board",
            _startYear = 2040,
            _endYear = 2045
        };
        // Show the details of job3
       // job10.Display();

        // Create a resume for John Doe
        Resume myResume = new Resume {
            _name = "John Doe" // The person's name
        };
        // Add all the jobs to the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);
        myResume._jobs.Add(job4);
        myResume._jobs.Add(job5);
        myResume._jobs.Add(job6);
        myResume._jobs.Add(job7);
        myResume._jobs.Add(job8);
        myResume._jobs.Add(job9);  
        myResume._jobs.Add(job10);
      
        // Show the resume, which lists the name and all jobs
        myResume.Display();
    }
}
    
