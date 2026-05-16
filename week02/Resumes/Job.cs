// This class represents a job that a person has had
public class Job
{
  // The name of the company where the person worked
  public string _company;
  // The title or position the person held
  public string _jobTitle;
  // The year the person started the job
  public int _startYear;
  // The year the person ended the job (or "Present" if still working)
  public int _endYear;

  // This method prints out the job details in a simple format
  public void Display()
  {
    Console.WriteLine($"{_jobTitle} at {_company} ({_startYear} - {_endYear})");
  }
}