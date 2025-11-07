using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Galactic Pizza Challenge!");
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        string userPlanetChoice = "";
        string planet = "";

        var planetOptions = new Dictionary<string, string>
        {
            { "A", "Earth" },
            { "B", "Mars" },
            { "C", "Jupiter Station" },
            { "D", "Venus Outpost" }
        };

        Console.WriteLine();
        Console.WriteLine($"Hello, {name}! What is your destination planet?");
        foreach (var option in planetOptions)
        {
            Console.WriteLine($"{option.Key}: {option.Value}");
        }

        while (true)
        {
            userPlanetChoice = Console.ReadLine().ToUpper();

            if (planetOptions.ContainsKey(userPlanetChoice))
            {
                Console.WriteLine();
                Console.WriteLine($"You have selected {planetOptions[userPlanetChoice]} as your destination.");
                planet = planetOptions[userPlanetChoice];
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid planet option (A, B, C, or D).");
            }
        }

        Console.WriteLine($"Great! Preparing a pizza for delivery to {planet} for {name}.");
        Console.WriteLine();
        Console.WriteLine("Next, please choose your pizza type:");
        Console.WriteLine("Pizza Type".PadRight(25) + "Cost (credits)");
        Console.WriteLine(new string('-', 45));

        var pizzaTypes = new Dictionary<string, (string Name, int Cost)>
        {
            { "A", ("Galactic Cheese", 10)},
            { "B", ("Meteor Meat Lover", 15) },
            { "C", ("Veggie Nebula", 12) },
            { "D", ("Black Hole BBQ", 18) }
        };


        foreach (var option in pizzaTypes)
        {
            Console.WriteLine($"{option.Key}: {option.Value.Name.PadRight(25)} {option.Value.Cost} credits");
        }
        Console.WriteLine();
        Console.WriteLine("What type of pizza would you like? Continue to enter requests and type \"done\" when finished.");
        string pizzaRequest = "";
        int totalCost = 0;

        while (true)
        {
            pizzaRequest = Console.ReadLine().ToUpper();

            if (pizzaTypes.ContainsKey(pizzaRequest))
            {
                Console.WriteLine();
    // Update total cost
                Console.WriteLine($"You have selected {pizzaTypes[pizzaRequest]} as your pizza type. Your total is {totalCost}. Enter another pizza type or type \"done\" to finish.");
                break;
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
    }
}