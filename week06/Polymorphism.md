
# Question
What is polymorphism and why is it important?



# Polymorphism
A Polymorphism is another concept in object‑oriented programming where it means “one in many forms.” For example, I will reuse my previous example from inheritance since they are related.

Parent or base class Domingo has a method WatchTv() that returns “news,” which means my parents can use the TV and watch it. Now the JohnDomingo derived or child class will inherit this method WatchTv() but override it to return “cartoons.”

## Code Example

```csharp
public class Domingo
{
  // using virtual indicate allowing a method to be reused
  public virtual string WatchTv()
  {
    return "news channel";
  }
}

public class JohnDomingo : Domingo
{ 
  //using override indicate reusing the parents method
  public override string WatchTv()
  {
    return "cartoon channel";
  }
}
```

## Why This Matters

By using a method from the parent or base class (Virtual) and then changing its behavior in the child class (Override) , we can keep the shared structure while customizing what each derived class does.

This makes code more flexible, reusable, and easier to expand.