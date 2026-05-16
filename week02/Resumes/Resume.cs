// This class represents a person's resume, which lists their jobs
public class Resume
{
  // The name of the person whose resume this is
  public string _name;
  // A list to store all the jobs the person has had
  public List<Job> _jobs = new List<Job>();

  // This method prints out the resume details: the name and all jobs
  public void Display()
  {
    Console.WriteLine($"Name: {_name}");
    Console.WriteLine("list of Jobs:"+ "{");
    // Go through each job in the list and print its details
    foreach (Job job in _jobs)
    {
      if (job == _jobs.Last()) // Check if this is the last job in the list
      {
        job.Display(); // If it's the last job, just display it without a comma
      }
       else
       {
      job.Display();  Console.WriteLine(","); // Add a comma after each job for formatting 
       } 
    }
    Console.WriteLine("}");
  }
}