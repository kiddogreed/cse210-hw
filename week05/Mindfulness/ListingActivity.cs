namespace Mindfulness;

public class ListingActivity : Activity
{
	private readonly List<string> _prompts;
	private readonly Random _random = new();
	private int _count;

	public ListingActivity()
		: base("Listing", "This activity will help you reflect on the good things in your life by having you list as many items as you can in a short time.")
	{
		// These prompts give the user a simple topic to think about.
		_prompts =
		[
			"When have you felt peace this week?",
			"What are some things you are grateful for?",
			"Who are people that support you?",
			"What are some of your personal strengths?",
			"What are things you enjoy doing?"
		];
	}

	public void Run()
	{
		Console.Clear();
		// Tell the user what kind of answers to give.
		DisplayStartingMessage();

		Console.WriteLine("List as many responses as you can to the following prompt:");
		Console.WriteLine();
		Console.WriteLine(GetRandomPrompt());
		Console.WriteLine();
		Console.WriteLine("You may begin in:");
		ShowCountDown(5);
		Console.WriteLine();

		// Count each response the user types.
		_count = 0;
		// Keep accepting answers until the time is up.
		DateTime endTime = DateTime.Now.AddSeconds(_duration);
		while (DateTime.Now < endTime)
		{
			Console.Write("> ");
			string response = Console.ReadLine() ?? string.Empty;
			if (!string.IsNullOrWhiteSpace(response))
			{
				// Only count real answers.
				_count++;
			}
		}

		Console.WriteLine();
		// Show how many items the user listed.
		Console.WriteLine($"You listed {_count} items.");
		DisplayEndingMessage();
	}

	private string GetRandomPrompt()
	{
		return _prompts[_random.Next(_prompts.Count)];
	}
}
