### week01/Exercise3
The `Program.cs` file in Exercise3 was corrected and improved:

- The program now uses a random number generator to select the magic number, instead of asking the user to provide it.
- The user is prompted to guess the number, and after each guess, the program tells the user to guess higher or lower until the correct number is guessed.
- The program tracks and displays the number of guesses taken.
- The code uses a loop and if statements to implement the game logic.

This ensures the Guess My Number game works as intended and provides a better user experience.
# cse210-ww-student-template
John Russelle Domingo

This repository contains the starter code for many different projects. They are arranged in folders by week. There is also an empty sandbox project that can be used to play around with any concept you would like.

## Recent Changes (Simple)

### week01/Exercise3
The guessing game now works:
- The computer picks a random number.
- You keep guessing until you get it right.
- It tells you if you need to guess higher or lower.
- It counts your tries.

**Changes:**
- Uses a random number generator instead of asking the user.
- Fixed the display of the guess counter.

### week01/Exercise5
The program now:
- Asks for your name.
- Asks for your favorite number.
- Tells you the square of your number.
- All steps work as expected.

**Changes:**
- Calls the functions in the main program.

---



## week02/Resumes

This is a simple program that prints out a fake resume in the terminal.

- You type in jobs (where, what, and years).
- It puts all the jobs together for one person.
- It shows the person's name and all their jobs in a list.


**What I learned:**
- How to use classes to organize code (each job and the resume are their own class).
- Abstraction: hiding details inside classes so the main program is simple and easy to use.


## week02/Journal


This is a simple journal you use in the terminal. It asks you a question, you type your answer, and it saves everything for you.

- Gives you a random question to help you start writing.
- Saves your answer, the question, and the date.
- You can see all your old entries.
- You can save your journal to a file or load it back later.
- You can add your own questions or see the full list of questions.

How it works:
- The program is split into four parts (files) to keep things organized.
- It uses a default file name so you don’t have to remember one.
- When you add a new question, it saves it for next time.
- Each entry is shown with lines to make it easy to read.

Extra stuff:
- You can add new questions while using the app.
- You can see all the questions for ideas.
- Entries look neat in the terminal.

What I learned:
- Abstraction, how to define class, behaviors and attributes
- How to look / check class diagram
- How to colab with other team
- How to break a big program into smaller pieces (classes and files).
- How to keep a list of things (like entries or questions).
- How to save and load stuff from a file so it’s not lost.
---

## week03/Fractions

This program creates fractions (like 1/2 or 3/4) and shows them in the terminal.

- You can make a fraction from a whole number (like 5, which becomes 5/1).
- You can make a fraction from two numbers (like 3 and 4, which becomes 3/4).
- It shows the fraction as a string (like "3/4").
- It also shows the decimal value (like 0.75 for 3/4).

How it works:
- The `Fraction` class stores the top number (numerator) and bottom number (denominator).
- You can get or set either number using simple methods.
- The program creates a few test fractions and prints them out to show everything works.

What I learned:
- How to use a class to represent a math concept (a fraction).
- How to write multiple constructors so you can create objects in different ways.
- How to use getter and setter methods to read and change values inside a class.
- How encapsulation keeps the inside details private while still letting you use the class.

---

## week03/ScriptureMemorizer

A scripture memorizer game. It shows a verse, then hides random words one by one until everything is blank.

Controls: Enter = hide more words | Left Arrow = undo | Q = quit

Files:
- `Reference.cs` — holds the book, chapter, and verse
- `Word.cs` — one word that can be hidden or shown
- `Scripture.cs` — holds all the words together and handles hiding/revealing
- `ScriptureManager.cs` — loads and manages a list of scriptures from a file
- `Program.cs` — runs the main loop

**Latest changes:**
- Added `scripture.txt` with 20 real scriptures (one per line, pipe-separated format).
- Created `ScriptureManager` class to load scriptures from the file and pick one at random.
- The program no longer has a hardcoded scripture — it picks a different one every time it starts.

**Challenges overcome:**

- **Reading from a file:** Needed a clean format the program could parse. Used `Book|Chapter|Verse|Text` so splitting on `|` gives each piece cleanly, even for book names with spaces like `1 John`.
- **Where to put the file-loading code:** Decided against stuffing it into `Reference`, `Scripture`, or `Word` — none of those are the right place. Created a dedicated `ScriptureManager` class that owns the list and handles loading, adding, and picking a random scripture.
- **File not found at runtime:** The `.csproj` needed a setting to copy `scripture.txt` into the output folder so the program can find it when it runs.

What I learned:
- How to split a program into classes that each do one job (Single Responsibility).
- The difference between `ReadLine()` (reads typed text) and `ReadKey()` (reads any keypress).
- How to fix an infinite loop by filtering your options before picking randomly.
- How to read and parse a text file into real objects at runtime.
- How to use a manager/coordinator class to keep file I/O out of model classes.

---

## week05/Homework

This homework project uses inheritance to build different kinds of assignments.

- `Assignment.cs` stores the shared student name and topic.
- `MathAssignment.cs` inherits from `Assignment` and adds the textbook section and problems.
- `WritingAssignment.cs` also inherits from `Assignment` and adds a title.

What I learned:
- How inheritance lets one class reuse another class's code.
- How a base class can hold shared data for multiple assignment types.
- How child classes can add their own extra details while still using the base class.

## week05/Mindfulness

This project is a simple mindfulness app with three activities:
- Breathing activity
- Listing activity
- Reflecting activity

How inheritance is used:
- `Activity` holds the shared parts like the name, description, timer, spinner, and countdown.
- `BreathingActivity`, `ListingActivity`, and `ReflectingActivity` inherit from `Activity`.
- Each child class adds its own `Run()` method and activity-specific steps.

Issue I overcame:
- The base `Activity` class did not match the child classes at first, so I added a shared constructor and made the activity classes call it correctly.
- After that, the project built and the menu could run each activity.

What I learned:
- How inheritance helps reduce repeated code.
- How one base class can support several different activities.
- How to fix constructor problems when a child class depends on a parent class.

## week06/Shapes

This project practices polymorphism using different kinds of shapes.

- `Shape` is the parent class that stores the color and defines `GetArea()`.
- `Square`, `Rectangle`, and `Circle` inherit from `Shape`.
- Each child class has its own area formula, but they all use the same method name: `GetArea()`.

How polymorphism works here:
- A `List<Shape>` can hold a square, rectangle, and circle together.
- When the program loops through the list, it calls `GetArea()` on each item.
- C# automatically uses the correct version of `GetArea()` based on the real object type.
- In simple terms: the program can treat them all like "shapes," while each one still does its own specific job.

What I learned:
- Inheritance is for sharing common parts, like color.
- Polymorphism means one base type can work with many child types.
- Overriding lets each child class replace a parent method with its own behavior.
- A `List<Shape>` is useful because it lets one loop work with different objects in the same way.

---

## week06/EternalQuest

A goal-tracking program that uses gamification to keep you motivated. You can create different kinds of goals, record progress, earn points, and save everything to a file so nothing is lost between sessions.

### How it works

The program has three goal types, each in its own file:

- `SimpleGoal` — done once and marked complete (e.g., run a marathon, earn 1000 points).
- `EternalGoal` — repeats forever, every time you record it you earn points (e.g., read scriptures daily).
- `ChecklistGoal` — must be done a set number of times; you earn regular points each time and a bonus when you hit the target (e.g., attend the temple 10 times).

`GoalManager` owns the list of goals and the player's running score. `Program.cs` drives the interactive menu.

### How I applied polymorphism

All three goal types inherit from one base class called `Goal`. The base class defines three `virtual` methods:

- `RecordEvent()` — awards points; each child overrides it with its own rules.
- `IsComplete()` — returns whether the goal is done; each child decides its own logic.
- `GetDisplayString()` — returns the one-line display text shown in the goal list, with `[ ]` or `[X]` status and any extra detail like `Completed 2/5 times`.

Because these are `virtual`/`override`, `GoalManager` can hold a `List<Goal>` containing any mix of goal types, call `RecordEvent()` on whichever one the player picks, and C# automatically runs the right version for that object — without needing to check the type manually. That is polymorphism in action.

### Challenges I overcame

- **`RecordEvent()` was `void`** — the score was never actually added. Fixed by making `RecordEvent()` return `int` (the points earned), and having `GoalManager.RecordEvent()` add that return value to the score.
- **`IsComplete()` was hiding, not overriding** — derived classes declared `public bool IsComplete()` without `override`, so the base version was always called through a `Goal` reference. Fixed by making the base method `virtual` and all derived versions `override`.
- **`LoadGoals` had wrong field indices** — `ChecklistGoal` was reading `amountCompleted` and `target` from the wrong positions in the pipe-separated line. Fixed by mapping each `parts[n]` to the correct field name.
- **`SimpleGoal` load didn't restore `_isComplete`** — completed goals would reset to incomplete after loading. Fixed by adding a second constructor that accepts the saved `bool` value.
- **`Program.cs` was empty** — the whole user interface was missing. Built a full interactive menu covering all nine functional requirements: create goals, list goals, record events, display score, and save/load.

### How I exceeded the requirements

I added a **level progression system** inside `GoalManager.GetLevel()`. As the player earns points they advance through five named levels:

| Score | Level Title |
|---|---|
| 0 | Novice Seeker |
| 500+ | Rising Seeker |
| 2000+ | Faithful Adventurer |
| 5000+ | Celestial Champion |
| 10000+ | Eternal Master |

The current level title is shown next to the score at the top of every menu loop, so the player always knows how far they have come. This is described in the comment block at the top of `Program.cs`.

### What I learned

- Polymorphism lets one list hold many different object types and still call the right method on each one.
- `virtual` + `override` is what makes polymorphism actually work — using `new` hides the method instead and breaks it when accessed through a base class reference.
- Returning a value from a method (instead of `void`) is important when the caller needs to use the result, like adding earned points to a score.
- Load constructors are needed when an object has state that must be fully restored from a file, not just initialized fresh.


