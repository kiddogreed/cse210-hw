
# Week 3: Encapsulation Reflection

## Assignment Prompt

Now that you have learned about the principle of encapsulation, and designed and developed a program using it, return to Canvas and answer the following question (the way you would in a job interview):

**What is encapsulation and why is it important?**

Your response must:

- Explain the meaning of Encapsulation.
- Highlight a benefit of Encapsulation.
- Provide an application of Encapsulation.
- Use a code example of Encapsulation from the program you wrote. (You should copy and paste a few lines of code that demonstrate the use of the principle.)
- Thoroughly explain these concepts. (This likely cannot be done in less than 100 words.)

---

## My Answer

For me, encapsulation is one of the OOP concepts that hides information, much like a capsule—hence the name. It means restricting access to certain parts of the data so that only the relevant methods, classes, or variables can interact with it. This ensures better control over how data is used.

The main benefit of encapsulation is that it helps organize and modularize code, which is especially useful in large projects.

**Example:**

```java
public class Car {
	private int year;
	private String name;

	public int getYear() { return year; }
	public void setYear(int year) { this.year = year; }
	public String getName() { return name; }
	public void setName(String name) { this.name = name; }
}
```

Here, the attributes are private and can only be accessed within the `Car` class. This prevents unrelated classes from directly modifying them. To allow controlled access, we add public methods such as getters and setters.

This way, encapsulation ensures that data is protected while still being accessible through safe, controlled methods.