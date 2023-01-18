//using static System.Net.Mime.MediaTypeNames;
//using System.Diagnostics.Metrics;
//using System.Drawing;
//using System.Runtime.Intrinsics.X86;
//using System.Threading.Tasks;





//When they’re done adding items, display a list of all items ordered with prices in columns.
//Display the sum price of the items ordered.

//Build Specifications/Grading Points
//Application uses a Dictionary<string, decimal> to keep track of the menu of items.  You can code it with literals. (2 points for instantiation & initialization)
//Use a List<string> for the shopping list and store the name of the items the customer ordered.
//Application takes item name input and:
//Responds if that item doesn’t exist(1 point)
//Adds its name to the relevant List if it does (1 point)
//Application asks user if they want to quit or continue, and loops appropriately (1 point)
//Application displays list of items with their prices (2 points)
//Application displays the correct total predict for the list (1 point)
//To determine the sum: Loop through the shopping list’s List collection, obtain the name, and look up the name’s price in the Menu Dictionary.
bool run = true;
{ Console.WriteLine("Welcome to Bridge Street Market.");
List<string> cart = new List<string>();

    Dictionary<string, decimal> inventory = new Dictionary<string, decimal>();
    {
        inventory.Add("pineapple", 6.99m);
        inventory.Add("rhubarb", 3.75m);
        inventory.Add("cheese", 6.50m);
        inventory.Add("bread", 5.99m);
        inventory.Add("eggs", 32.99m);
        inventory.Add("milk", 4.45m);
        inventory.Add("butter", 5.55m);
        inventory.Add("potatoes", 2.25m);
    }
    Console.WriteLine("Item\t\tPrice");
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
    foreach (KeyValuePair<string, decimal> kvp in inventory)
    {
        Console.WriteLine(String.Format("{0,8}{1,8}", kvp.Key, kvp.Value));
    }
do
{
    Console.WriteLine("What would you like to add to your cart?");
    string userInput = Console.ReadLine();
    if (inventory.ContainsKey(userInput))
    {
        
        cart.Add(userInput);
        Console.WriteLine($"{userInput} has been added to your cart");
        Console.WriteLine("Would you like to add another item to the cart? y/n");
        string proceed = Console.ReadLine();
        if (proceed == "y")
        {
            run= true;
        }
        else
        {
            run = false;

           
        }
    }
    else
    {
        Console.WriteLine("That item does not exist. Please choose from the menu:");
        run = true;

    }
} while (run == true);

   Console.WriteLine("Please check your cart: ");
decimal total = 0;
foreach (string f in cart)
{
    Console.WriteLine($"{f}: \t{inventory[f]}");
    total += inventory[f];
}
Console.WriteLine($"Your total is ${total}");
}