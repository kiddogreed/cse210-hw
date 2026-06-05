namespace Mindfulness;

public class BreathingActivity : Activity
{
	public BreathingActivity()
		: base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.")
	{
	}
	public void Run()
	{
		Console.Clear();
		// Explain the activity before starting the breathing loop.
		DisplayStartingMessage();

		// Keep breathing until the time runs out.
		DateTime endTime = DateTime.Now.AddSeconds(_duration);
		while (DateTime.Now < endTime)
		{
			// Breathe in, then breathe out.
			Console.Write("Breathe in... ");
			ShowCountDown(4);

			// Stop if the timer is already finished.
			if (DateTime.Now >= endTime)
			{
				break;
			}

			// Give the user a short pause to breathe out.
			Console.Write("Breathe out... ");
			ShowCountDown(4);
		}

		DisplayEndingMessage();
	}
}