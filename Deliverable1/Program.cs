
class Program
{
    static void Main()
    {
        // List all variables below, we need the stock of the soda, restock value of soda, stock of chips, restock value of chips, stock of candy, and its restock value. 
        int stockSoda = 100;
        int sodaRestockVal = 40;
        int stockChip = 40;
        int chipsRestockVal = 20;
        int stockCandy = 60;
        int candyRestockVal = 40;
//------------------------------------------First Section: Greeting--------------------
        Console.WriteLine("Welcome to the restocking tool.");
//----------------------------------------------------------------------------------------

        Console.WriteLine("\nHow many Sodas have been sold today? 100 are in stock");
        int soldSoda = int.Parse(Console.ReadLine());
//^^ Create the variable based on the user input, the user tells how many soda cans were sold.
        if (soldSoda <= stockSoda)
        {
            stockSoda -= soldSoda;
            Console.WriteLine($"There are {stockSoda} Sodas left");
        }
        else
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
        }
        // This constraint should be 100 - sold soda, the error would be any number beyond 100. 
        Console.WriteLine("\nHow many Chips have been sold today? 40 are in stock");
        int soldChips = int.Parse(Console.ReadLine());

        if (soldChips <= stockChip)
        {
            stockChip -= soldChips;
            Console.WriteLine($"There are {stockChip} Chips left");
        }
        else
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
        }
        // This constraint is 40 - the sold chips. Anything beyond 40 is impossible. 
        Console.WriteLine("\nHow many Candy have been sold today? 60 are in stock");
        int soldCandy = int.Parse(Console.ReadLine());

        if (soldCandy <= stockCandy)
        {
            stockCandy -= soldCandy;
            Console.WriteLine($"There are {stockCandy} Candies left");
        }
        else
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
        }
        //This constraint is 60 - Candy sold. Anything beyond 60 is impossible.

        Console.WriteLine("\nThank you for filling out the values. Here’s what needs to be restocked.");

        if (stockSoda <= sodaRestockVal)// stockSoda <= 100
        {
            Console.WriteLine("Soda needs to be restocked");
        }
        if (stockChip <= chipsRestockVal)// StockChip <= 40
        {
            Console.WriteLine("Chips need to be restocked");
        }
        if (stockCandy <= candyRestockVal)// Stock Candy <= 60
        {
            Console.WriteLine("Candy needs to be restocked");
        }
//------------------------------Goodbye Message----------------------------------------------------
        Console.WriteLine("\nGoodbye!");
    }
}
