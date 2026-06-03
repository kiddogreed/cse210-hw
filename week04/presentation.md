https://www.canva.com/design/DAHKrFw5AHo/McckUUC4DL26LIW8umZcPw/edit
BYU-Idaho Presentation Script: Foundation Programs Design (W04)

Slide 1: Title Slide

Slide Title: Foundation Programs Design Workshop

Visual Cue: Title slide showing "Foundation Programs Design Workshop - W04 Team Activity".

Talk Track:

"Hello everyone, and welcome to our Week 4 Team Activity design workshop. I'm really grateful to be gathering with you all today as BYU-Idaho students.

Today, we are focusing on two of the key pillars of Object-Oriented Programming: Abstraction and Encapsulation. Our goal during this activity is to work collaboratively, leveraging the BYU-I Learning Model to 'Teach One Another' so we can all walk away with a clear blueprint for this week's assignments."

Slide 2: The Meeting Roadmap

Slide Title: The Meeting Roadmap

Visual Cue: Minimalist slide with a blue highlight bar and roadmap visual.

Talk Track:

"Before we dive in, let's take a quick look at our roadmap. As we work through our agenda, remember that a successful design session isn't just about writing code—it's about learning to communicate and problem-solve together.

We've already completed our individual 'Preparation' before this meeting, and now we are in the 'Teach One Another' phase. Let's make sure we're keeping an open, encouraging environment where everyone feels comfortable sharing their thoughts and questions."

Slide 3: Team Meeting Agenda

Slide Title: Team Meeting Agenda

Visual Cue: Three distinct tiles: Preparation, Discussion, and Conclusion.

Talk Track:

"To start on the right foot, let’s verify our roles. I am happy to lead today, but we'll also need to make sure we keep track of our thoughts for the final diagrams.

As is our custom and privilege here at BYU-Idaho, we always want to invite the Spirit to guide our learning and help us collaborate with charity. Would someone in the group be willing to offer our opening prayer?

[Pause for prayer]

Thank you so much. With that foundation, let's dive into our discussion on Program #1—the YouTube Abstraction model—and Program #2—the Online Ordering Encapsulation model."

Slide 4: Program #1: Abstraction (YouTube Video Modeling)

Slide Title: Program #1: Abstraction

Visual Cue: Two-column split layout. Left: "YouTube Video Modeling" with text. Right: High-impact abstract technology imagery.

Talk Track:

"Let's begin with Program #1, which focuses on Abstraction.

If we think about it, abstraction is actually a divine principle. Heavenly Father doesn't overwhelm us with the infinite complexities of how the physical universe is run all at once; instead, He abstracts those laws into clear, simple principles we can understand and act upon.

In software, abstraction does the same thing. A real YouTube video is incredibly complex—it involves database queries, video rendering codecs, and server networks. For our program, we want to abstract all of that away, focusing only on the core details: tracking video metadata and organizing user comments."

Slide 5: Identifying Candidates (YouTube)

Slide Title: Identifying Candidates

Visual Cue: Two gray tiled boxes detailing the "Video Class" and "Comment Class".

Talk Track:

"To build this model, we've identified two main candidate classes: Video and Comment.

The Video class has the primary responsibility of acting as the parent container. It abstracts the entire 'video experience' for the user.

Instead of saving comments as simple, unstructured strings inside the Video class, we create a dedicated Comment class. This allows each individual comment to be its own object, keeping the author and text neatly grouped together. What do you guys think? Does this division of labor make sense to everyone?"

Slide 6: Attributes & Behaviors: YouTube

Slide Title: Attributes & Behaviors: YouTube

Visual Cue: Structured table mapping out the Class, Member Variables, and Methods for Video and Comment.

Talk Track:

"Here is how we can map out the actual state and behavior for these two classes.

For the Video class, our attributes are the title, author, length in seconds, and a list of Comment objects. Its behaviors will be to calculate the total comment count and display the video details alongside its comments.

The Comment class is beautifully simple. It just stores the commenter's name and the text, with a behavior to format that comment nicely. This keeps our design clean and easy to read."

Slide 7: Program #2: Encapsulation (Online Ordering Logistics)

Slide Title: Program #2: Encapsulation

Visual Cue: Split layout with "Online Ordering Logistics" text and shipping imagery.

Talk Track:

"Now, let’s transition to Program #2, which shifts our focus to Encapsulation.

In the gospel, we often talk about the principle of stewardship—the idea that we are given specific responsibilities and boundaries, and we are accountable for managing them.

Encapsulation in object-oriented programming is essentially the software equivalent of stewardship. It’s the practice of bundling data and behaviors together inside a class, while restricting direct access from the outside. Each class is a 'steward' of its own data and logic, preventing outside classes from accidentally messing things up. Let's see how we apply this to online logistics."

Slide 8: Core Encapsulated Classes

Slide Title: Core Encapsulated Classes

Visual Cue: Three tiles with custom icons for "Order", "Product", and "Address".

Talk Track:

"For this e-commerce model, we are designing three distinct stewards: Order, Product, and Address (with the Customer containing an Address).

The Product class is the steward of item details, like pricing and quantities.

The Address class is the steward of physical location details and knows how to format them.

And finally, the Order class acts as the coordinator, pulling products and customers together, calculating costs, and generating the labels. Because each class has a defined stewardship, our system remains highly organized and modular."

Slide 9: Business Logic: Shipping Rates

Slide Title: Business Logic: Shipping Rates

Visual Cue: Clean table comparing "Destination Type", "Shipping Cost", and "Label Requirements".

Talk Track:

"Let's look at how this stewardship plays out in our business logic, particularly with shipping calculations.

Our requirements say domestic shipping is $5.00, and international shipping is $35.00.

Rather than the Order class stepping outside its boundaries to dig into the raw address strings of the customer, we respect encapsulation. The Order class simply asks the Customer: 'Are you in the USA?' The Customer then delegates that question to the Address class, which handles the internal check. The Order class gets its answer without ever having to peek at the Address's private variables."

Slide 10: Visualization via UML

Slide Title: Visualization via UML

Visual Cue: Circle-cropped image showing a UML class diagram structure with accompanying text.

Talk Track:

"As we read in Doctrine and Covenants section 132, verse 8: 'Behold, mine house is a house of order, saith the Lord God, and not a house of confusion.'

Creating UML class diagrams is how we bring order to our code before we write a single line.

When drawing your UML diagrams, remember to clearly partition your class name, attributes, and methods. Use a minus sign (-) to mark your attributes as private—ensuring proper encapsulation—and a plus sign (+) for your public methods. Let's also make sure we use composition arrows to show how an Order has a list of Products."

Slide 11: Post-Meeting Deliverables

Slide Title: Post-Meeting Deliverables

Visual Cue: Clean bullet list highlighted by green checkmarks.

Talk Track:

"After we conclude our meeting today, we each move into the 'Ponder and Prove' phase of the Learning Model.

Individually, we will finalize our designs. Make sure your final document has:
First, the finalized list of variables and methods for both programs.
Second, your hand-drawn or digital UML class diagrams.
And third, a brief description or flowchart demonstrating how the Main() program coordinates these classes.

Once you've completed this, compile your designs into a single PDF document and upload it to Canvas."

Slide 12: Questions?

Slide Title: Questions?

Visual Cue: Q&A slide featuring a team collaboration image and course resources.

Talk Track:

"That brings us to the end of our structured presentation. Now, let’s open up the floor to teach one another.

Let's discuss: Do we feel confident in these candidate classes? Are there any methods or attributes we might want to adjust for either the YouTube model or the shipping logistics?

Let's share our insights and make sure we are all on the same page. Thank you, everyone, for your preparation and participation today!"