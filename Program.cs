using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Galactic Pizza Challenge!");
        Console.WriteLine("What is your name?");
        string? name = Console.ReadLine();

        string? userPlanetChoice = "";
        string planet = "";
        int deliveryCost = 0;
        int pizzaA = 0, pizzaB = 0, pizzaC = 0, pizzaD = 0;

        // With delivery fee
        var planetOptions = new Dictionary<string, (string Name, int Cost)>
            {
                { "A", ("Earth", 5)},
                { "B", ("Mars",10) },
                { "C", ("Jupiter Station",15) },
                { "D", ("Venus Outpost",8) }
            };

        Console.WriteLine();
        Console.WriteLine($"Hello, {name}! What is your destination planet?");
        foreach (var option in planetOptions)
        {
            Console.WriteLine($"{option.Key}: {option.Value.Name}");
        }

        while (true)
        {
            userPlanetChoice = Console.ReadLine()?.ToUpper();

            if (planetOptions.ContainsKey(userPlanetChoice))
            {
                Console.WriteLine();
                Console.WriteLine($"You have selected {planetOptions[userPlanetChoice].Name} as your destination. Is that correct? (yes/no)");

                while (true)
                {
                    string? confirmation = Console.ReadLine()?.ToLower();
                    if (confirmation == "yes")
                    {
                        planet = planetOptions[userPlanetChoice].Name;
                        deliveryCost = planetOptions[userPlanetChoice].Cost;
                        Console.WriteLine($"Great! Preparing a pizza for delivery to {planet} for {name}.");
                        break;
                    }
                    else if (confirmation == "no")
                    {
                        Console.WriteLine("Please select your destination planet again:");
                        foreach (var option in planetOptions)
                        {
                            Console.WriteLine($"{option.Key}: {option.Value}");
                        }
                        userPlanetChoice = Console.ReadLine()?.ToUpper();
                        if (planetOptions.ContainsKey(userPlanetChoice))
                        {
                            Console.WriteLine($"You have selected {planetOptions[userPlanetChoice].Name} as your destination. Is that correct? (yes/no)");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please respond with 'yes' or 'no'.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid planet option (A, B, C, or D).");
            }
            break;
        }


        Console.WriteLine();
        Console.WriteLine("Next, please choose your pizza type:");
        Console.WriteLine("Pizza Type".PadRight(25) + "Cost (credits)");
        Console.WriteLine(new string('-', 45));

        var pizzaTypes = new Dictionary<string, (string Name, int pizzaCost)>
            {
                { "A", ("Galactic Cheese", 10)},
                { "B", ("Meteor Meat Lover", 15) },
                { "C", ("Veggie Nebula", 12) },
                { "D", ("Black Hole BBQ", 18) }
            };


        foreach (var option in pizzaTypes)
        {
            Console.WriteLine($"{option.Key}: {option.Value.Name.PadRight(25)} {option.Value.pizzaCost} credits");
        }
        Console.WriteLine();
        Console.WriteLine("What type of pizza would you like? Continue to enter requests and type \"done\" when finished.");
        //string? pizzaRequest = "";
        int totalPizzaCost = 0;

        while (true)
        {
            string? pizzaRequest = Console.ReadLine()?.ToUpper();

            if (pizzaTypes.ContainsKey(pizzaRequest))
            {
                Console.WriteLine();
                totalPizzaCost += pizzaTypes[pizzaRequest].pizzaCost;
                switch (pizzaRequest)
                {
                    case "A":
                        pizzaA++;
                        break;
                    case "B":
                        pizzaB++;
                        break;
                    case "C":
                        pizzaC++;
                        break;
                    case "D":
                        pizzaD++;
                        break;
                }

                Console.WriteLine($"You have selected {pizzaTypes[pizzaRequest]} as your pizza type. Your total is {totalPizzaCost}. Enter another pizza type or type \"done\" to finish.");
            }
            else if (pizzaRequest.ToLower() == "done")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid pizza type (A, B, C, or D).");
            }
        }

        //create summary
        Console.WriteLine();
        Console.WriteLine($"Thank you, {name}, for your order! See summary below");
        Console.WriteLine($"Order for {name} to {planet}");
        Console.WriteLine(new string('-', 30));
        if (pizzaA > 0)
        {
            Console.WriteLine($"{pizzaA} x Galactic Cheese @ 10 = {pizzaA * 10}");
        }
        if (pizzaB > 0)
        {
            Console.WriteLine($"{pizzaB} x Meteor Meat Lover @ 15 = {pizzaA * 15}");
        }
        if (pizzaC > 0)
        {
            Console.WriteLine($"{pizzaC} x Veggie Nebula @ 12 = {pizzaA * 12}");
        }
        if (pizzaD > 0)
        {
            Console.WriteLine($"{pizzaC} x Black Hole BBQ @ 18 = {pizzaA * 18}");
        }
        Console.WriteLine($"Subtotal: {totalPizzaCost}");
        
        //apply discount
        double discount = 0;
        if (pizzaA+pizzaB+pizzaC+pizzaD > 2)
        {
            discount = totalPizzaCost * 0.1;
        }
        Console.WriteLine($"Discount (10%): {discount}");

        Console.WriteLine($"Delivery Fee: {planetOptions[userPlanetChoice].Cost}");
        Console.WriteLine($"Total Due: {totalPizzaCost-discount+planetOptions[userPlanetChoice].Cost} credits");
    }
}