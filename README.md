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

This program helps you memorize a scripture by slowly hiding the words one by one.

- It shows you the full scripture with its reference (like "John 3:16").
- Each time you press Enter, it hides a few more random words (shown as underscores).
- When all the words are hidden, the program ends.
- If you type "quit" at any time, it exits early.

How it works:
- The program is split into four files to keep things organized:
  - `Reference.cs` — Stores the book, chapter, and verse (like "John 3:16" or "Proverbs 3:5-6").
  - `Word.cs` — Stores each single word and can hide or show it.
  - `Scripture.cs` — Holds all the words and the reference together, and handles hiding random words.
  - `Program.cs` — Runs the main loop and ties everything together.
- Hidden words show as underscores (the same number as letters in the word).
- The program only hides words that are not already hidden.
- It checks if all words are hidden to know when to stop.

What I learned:
- How to break a big problem into smaller classes, each doing one job.
- How to use a list to keep track of many Word objects.
- How to pick random items from a list.
- How to loop and check conditions to control when the program ends.
- How classes work together (Scripture uses Reference and Word inside it).


