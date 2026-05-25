# Week 04 – YouTubeVideos Challenge

## What was the challenge?
Build a program that tracks YouTube videos and their comments using classes.
No real YouTube connection needed — just practice organizing data with **abstraction** (hiding details inside classes).

---

## Steps I took

**1. Created the `Comment` class**
- Needed to store who wrote the comment (`_commenterName`) and what they said (`_text`).
- Added a constructor to set both values at once.
- Added getter methods so other classes can read the data without touching the private fields.

**2. Created the `Video` class**
- Stored the title, author, and length (in seconds).
- Added a `List<Comment>` inside the class to hold all comments for that video.
- Wrote `NumberOfComments()` — just returns how many items are in the list.
- Wrote `AddComment()` to push a new comment into the list.
- Wrote `DisplayInfo()` to print everything: title, author, length, comment count, and each comment.

**3. Wired it all up in `Program.cs`**
- Created 3 videos with sample titles, authors, and lengths.
- Added 3 comments to each video using `AddComment()`.
- Put all videos in a `List<Video>`.
- Looped through the list and called `DisplayInfo()` on each one.

---

## Challenges I ran into

| Challenge | How I overcame it |
|---|---|
| Figuring out where the comment list should live | Realized the `Video` owns the comments, so the list belongs inside `Video`, not `Program.cs`. |
| Calling `NumberOfComments()` vs just using `.Count` directly | Kept `NumberOfComments()` as a method on `Video` to follow the spec and hide the internal list. |
| Displaying comments cleanly | Used a `foreach` loop inside `DisplayInfo()` and called the getter methods on each `Comment`. |
| Understanding abstraction in practice | Each class only knows its own data — `Video` doesn't care how `Comment` stores its text, it just calls the getter. That's abstraction. |

---

## Result
Program creates 3 videos, each with 3 comments, loops through them, and prints all info to the console — no user input needed.

---
---

# Week 04 – OnlineOrdering Challenge

## What was the challenge?
Build an ordering system using **encapsulation** — keep each class's data private and only expose what other classes actually need.
Four classes work together: `Address`, `Customer`, `Product`, and `Order`.

---

## Steps I took

**1. Created the `Address` class**
- Stored street, city, state, and country as private fields.
- Wrote `IsInUSA()` — checks if country equals "usa" (case-insensitive).
- Wrote `GetFullAddress()` — joins all fields into one printable string.

**2. Created the `Customer` class**
- Stored name (string) and address (`Address` object) as private fields.
- Wrote `LivesInUSA()` — just calls `address.IsInUSA()`, doesn't duplicate the logic.
- Wrote `GetAddressString()` — calls `address.GetFullAddress()` to return the formatted address.

**3. Created the `Product` class**
- Stored name, productId, price, and quantity as private fields.
- Wrote `GetTotalCost()` — multiplies price × quantity for that line item.
- Wrote `GetPackingLabel()` — returns "name (ID: productId)" for the packing slip.

**4. Created the `Order` class**
- Stored a `List<Product>` and a `Customer` as private fields.
- Wrote `CalculateTotalCost()` — loops through all products, sums their costs, then adds $5 (USA) or $35 (international) shipping.
- Wrote `GetPackingLabel()` — loops through products and builds a list of packing label lines.
- Wrote `GetShippingLabel()` — uses the customer's name and full address.

**5. Wired it all up in `Program.cs`**
- Created 2 addresses (one USA, one Canada).
- Created 2 customers linked to those addresses.
- Built 2 product lists (2–3 items each).
- Created 2 orders pairing each customer with their products.
- Looped through orders and printed packing label, shipping label, and total cost.

---

## Challenges I ran into

| Challenge | How I overcame it |
|---|---|
| Figuring out the chain: `Order` → `Customer` → `Address` | Drew out the relationship — `Order` holds a `Customer`, `Customer` holds an `Address`. Each class only talks to its direct neighbor. |
| Shipping cost logic inside `Order` | Used a ternary: `customer.LivesInUSA() ? 5 : 35` — clean one-liner that reads like plain English. |
| Keeping all fields private | Made sure every field used `private`, then only added getters/methods for what other classes actually needed. |
| `Customer` needed address info but shouldn't expose `Address` directly | Wrote `GetAddressString()` on `Customer` so `Order` never had to touch the `Address` object itself — that's encapsulation. |

---

## Result
Program creates 2 orders with different customers (USA and international), prints packing labels, shipping labels, and correct totals with the right shipping cost applied — no user input needed.
