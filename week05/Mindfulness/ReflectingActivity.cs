namespace Mindfulness;

public class ReflectingActivity : Activity
{
	private readonly List<string> _prompts;
	private readonly List<string> _questions;
	private readonly Random _random = new();

	public ReflectingActivity()
		: base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
	{
		// These prompts help the user pick a memory to think about.
		_prompts =
		[
			"Think of a time when you stood up for someone else.",
			"Think of a time when you did something really difficult.",
			"Think of a time when you helped someone in need.",
			"Think of a time when you did something truly selfless."
		];

		_questions =
		[
			"Why was this experience meaningful to you?",
			"What did you learn about yourself?",
			"How did you feel when it was happening?",
			"What could you learn from this experience again?",
			"How can you apply this in the future?"
		];
	}

	public void Run()
	{
		Console.Clear();
		// Give the user a thought to focus on.
		DisplayStartingMessage();

		Console.WriteLine("Consider the following prompt:");
		Console.WriteLine();
		Console.WriteLine(GetRandomPrompt());
		Console.WriteLine();
		Console.WriteLine("When you have something in mind, press Enter to continue.");
		Console.ReadLine();

		Console.WriteLine();
		// Ask short follow-up questions during the reflection time.
		Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
		Console.Write("You may begin in:");
		ShowCountDown(5);
		Console.WriteLine();

		// Keep showing questions until the timer ends.
		DateTime endTime = DateTime.Now.AddSeconds(_duration);
		while (DateTime.Now < endTime)
		{
			Console.WriteLine();
			// Pick a new question each time through the loop.
			Console.WriteLine(GetRandomQuestion());
			ShowSpinner(5);
		}

		DisplayEndingMessage();
	}

	private string GetRandomPrompt()
	{
		return _prompts[_random.Next(_prompts.Count)];
	}

	private string GetRandomQuestion()
	{
		return _questions[_random.Next(_questions.Count)];
	}
}
