# Inheritance

## Prompt

What is inheritance and why is it important?

Your response must:

- Explain the meaning of Inheritance.
- Highlight a benefit of Inheritance.
- Provide an application of Inheritance.

## Answer

<!-- Comment: Define inheritance more clearly as a way for a child class to reuse fields and methods from a parent class. -->
Inheritance is another concept in Object Oriented Programming which allows objects or subclasses to inherits behavior and attributes from a parents Class.

<!-- Comment: This example shows the idea in a real-life family relationship, then connects it to code. -->
Example in human world it means Me as a person has an attirbute of first_name of John. Then I inherit the last_name from my parents which is Domingo. I have a behavior of loveBasketBall because I also inherit it from my parents. If we can translate it to a code this is what it looks like.

```csharp
public class Domingo
{
    private string _lastName;

    public Domingo(string lastName)
    {
        _lastName = lastName;
    }

    public void ILoveBasketball()
    {
        Console.WriteLine("I love Basketball!");
    }
}

public class JohnDomingo : Domingo
{
    private string _firstName;

    public JohnDomingo(string firstName) : base("Domingo")
    {
        _firstName = firstName;
    }

    // Inherited attribute: _lastName comes from Domingo.
    // The child class sets its own first name.
    // Inherited behavior: ILoveBasketball() comes from Domingo.
}

// Example of using the classes.
JohnDomingo john = new JohnDomingo("John");
john.ILoveBasketball();
```

By implementing Inheritance we can now avoid repeating attributes or behavior per class. Basically we can reuse them.