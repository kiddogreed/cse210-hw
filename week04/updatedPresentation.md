Hello team, Greetings, This is John, lead student for our Week 04 Foundation Programs Design activity. I’m based here in Makati, Metro Manila, Philippines (PHT+8). current time was :  Before we begin, let’s allow about 5 minutes for everyone to catch up or join the meeting. While waiting others to join please comment your timezone to verify time and location for our class.


Verify time, location, and lead student.

Alright team, thank you for waiting. Let’s officially begin our Week 04 Foundation Programs Design meeting. 

slide 2 - Here are the agendas for today’s meeting

---------------------------------------------------------------------
---------------------------------------------------------------------

TEAM MEETING AGENDA
PREPARATION
Script (Leader):  
“Welcome. Please confirm you read the Week 04 materials. If anyone hasn’t read them, please take a moment now to skim the key sections.”

Checklist read-aloud:


Confirm everyone read Week 04 materials.
---------------------------------------------------------------------
---------------------------------------------------------------------
OPENING PRAYER
Script (Leader):  
“Let us open with a short prayer.”
(Pause for prayer)

---------------------------------------------------------------------
---------------------------------------------------------------------
lets proceed with 1st DISCUSSION

Program 1 — ABSTRACTION: YOUTUBE VIDEO MODELING
Intro (Leader):  
ask someone to read the Program specifications

in other words "we need to have class for Video and Comment. We need to keep track of YouTube videos and comments left on them."

“The goal is to abstract the complexities of a video hosting service into a simple software model.”

---------------------------------------------------------------------
Scripted prompts and flow

Leader: “What does this program do?”
Suggested reply: “It models a video and its user interactions (comments) and metadata (title, author, length).”
we need to have class for Video and Comment to keep track of YouTube videos or comments left on them
---------------------------------------------------------------------
Leader: “What are candidate classes?”
Suggested reply: “Video and Comment.”
---------------------------------------------------------------------
Leader: “What are the responsibilities of each class?”
Suggested reply:

Video: Manage primary video metadata and the collection of comments; act as the parent container that abstracts the whole video experience.

Comment: Store individual user feedback; be reusable and decoupled from Video.
---------------------------------------------------------------------

Leader: “What attributes and behaviors do we need?”
Suggested reply:

Video attributes: _title : string; _author : string; _length : int; _comments : List\<Comment\>

Video behaviors: getCommentCount() : int; displayInfo() : void

Comment attributes: _commenterName : string; _text : string

Comment behaviors: displayInfo() : void


---------------------------------------------------------------------

Diagram task (Leader):  
“Can someone sketch the Video ↔ Comment class diagram now? Use the agreed attribute and method names.”

Short spoken demo (for presentation):  
“Create a Video object with title, author, and length. Add two Comment objects to its comments list. Call displayInfo() on the Video; it prints metadata and iterates comments calling each comment’s displayInfo().”

---------------------------------------------------------------------
---------------------------------------------------------------------
Program 2 — ENCAPSULATION: ONLINE ORDERING LOGISTICS
Intro (Leader):  
“This program encapsulates the logic for e-commerce transactions, separating shipping details from product lists.”

Scripted prompts and flow
---------------------------------------------------------------------
Leader: “What does this program do?”
Suggested reply: “It orchestrates/handles Customer orders, holds products, calculates totals, and separates shipping/address logic from product data.”
---------------------------------------------------------------------
Leader: “What are candidate classes?”
Suggested reply: “Order, Product, Customer, Address.”
---------------------------------------------------------------------
Leader: “What are the responsibilities of each class?”
Suggested reply:

Order: Hold products, reference Customer, calculate totals, produce packing and shipping labels.

Product: Store name, id, price, quantity; compute item total.

Customer: Store name and Address; provide name and residency checks.

Address: Store street, city, state, country; determine domestic vs international.
---------------------------------------------------------------------
Leader: “What attributes and behaviors do we need?”
Suggested reply:

Order attributes: _products : List\<Product\>; _customer : Customer

Order behaviors: CalculateTotalCost() : decimal; GetPackagingLabel() : string; GetShippingLabel() : string

Product attributes: _name : string; _productId : string; _price : decimal; _quantity : int

Product behaviors: GetTotalCost() : decimal

Customer attributes: _name : string; _address : Address

Customer behaviors: GetNames() : string; LivesInUSA() : bool

Address attributes: _street : string; _city : string; _state : string; _country : string

Address behaviors: IsInUSA() : bool; GetFullAddress() : string

Diagram task (Leader):  
“Who will draft the Order, Product, Customer, and Address class diagram? Make sure Order delegates country checks to Address.”

Short spoken demo (for presentation):  
“Create a Customer with an Address. Create two Product objects and add them to an Order. Call Order.CalculateTotalCost() to compute the sum of product totals. Call GetShippingLabel() which uses Address.GetFullAddress() and Address.IsInUSA() to format the label.”

CREATE CLASS DIAGRAMS (IN-MEETING ACTION)
Script (Leader):  
“Let’s create two diagrams now: one for YouTube (Video, Comment) and one for Ordering (Order, Product, Customer, Address). Assign one person to draw each diagram and one person to verify method names and types.”

CONCLUSION & NEXT STEPS
Script (Leader):  
“We’ve agreed on the candidate classes, responsibilities, attributes, and behaviors. Each of you should now finish your individual designs and submit them to Canvas.”

After-meeting checklist (read aloud):

Add any missing classes you think are necessary.

Determine behaviors (methods) for each class.

Determine attributes (member variables) for each class.

Include a class diagram for each program.

Include a run-flow description or chart showing how methods relate and how the program executes.

Combine both program designs into one document and submit to Canvas.

Assignment of deliverables (Leader):

Diagram owner: produce final class diagrams for both programs.

Method/attribute owner: finalize method names and attribute types.

Documentation owner: write class descriptions and run-flow charts.

All members: individually finish and submit on Canvas.

---------------------------------------------------------------------
---------------------------------------------------------------------
Before we close Lets dicuss the next student leader for next week. 

CLOSING
Script (Leader):  
“Any final questions? If none, let’s close with a short prayer.”
(Pause for prayer)

