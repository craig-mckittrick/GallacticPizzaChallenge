# C# Coding Challenge: The Galactic Pizza Delivery Service

A quick challenge to demonstrate your coding  

## Story  

You've just been hired by **Intergalactic Pizza Co.**, the most popular delivery company in the Milky Way.  

Your task? Build a simple console app that calculates delivery costs and order summaries for customers scattered across different planets.

---

## Objectives

Use your best coding skills to provide a solution for the requirements

---

## Requirements
  

### 1. Collect Customer Info

- Ask for customer name and destination planet.

- Valid destinations: `Earth`, `Mars`, `Jupiter Station`, `Venus 
Outpost`.

### 2. Menu System

Show the following pizzas (and costs):

| Pizza Type        | Cost (credits) |
|-------------------|----------------|
| Galactic Cheese   | 10             |
| Meteor Meat Lover | 15             |
| Veggie Nebula     | 12             |
| Black Hole BBQ    | 18             |

Allow customers to order multiple pizzas until they type **"done"**.

### 3. Delivery Fee by Planet
- Earth → +5 credits  
- Mars → +10 credits  
- Jupiter Station → +15 credits  
- Venus Outpost → +8 credits

### 4. Discounts
If the customer orders **3 or more pizzas**, apply a **10% discount** (before adding delivery).

### 5. Output Summary Example
```
Order for Captain Lila to Mars
---------------------------------
2 x Galactic Cheese @ 10 = 20
1 x Black Hole BBQ @ 18 = 18
Subtotal: 38
Discount (10%): -3.8
Delivery Fee: 10
Total Due: 44.2 credits
```

---

## Bonus Extensions (Optional if time allows)
- Add **random delivery time** (e.g., `Random.Next(15, 61)` → “Estimated delivery time: 42 minutes”)
- Add **enum** for planets and a **class** for Pizza.
- Handle **invalid planet or pizza names** gracefully.
- Add an **ASCII spaceship animation** (“🚀 delivering your pizza…”).

---
