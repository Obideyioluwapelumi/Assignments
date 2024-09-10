

// Class Assignment

/*
 * variables
 * limitOfPap
 * limitOfAkara
 * priceOfPap
 * PriceOfAkara
 * orderOfPap
 * orderOfAkara
 
 */

/*
int orderOfPap;
int orderOfAkara;
decimal priceOfAkara = 50;
decimal priceOfPap = 100;
decimal totalAmount;
Console.WriteLine("Hello!! Welcome to our store.");
Console.WriteLine("We sell pap and akara");
int limitOfPap = 100;
int limitOfAkara = 100;

Console.WriteLine("Please what would you like to order");
Console.WriteLine("Input 1 for Akara, 2 for pap and 3 for pap and akara");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:

        Console.WriteLine($"Hey, you selected Akara, a piece of akara cost {priceOfAkara}. How many akara would you like to buy?");
        orderOfAkara = Convert.ToInt32(Console.ReadLine());
        if (orderOfAkara > limitOfAkara)
        {
            Console.WriteLine("You exceeded the available number of akara available");
            return;
        }
        totalAmount = orderOfAkara * priceOfAkara;
        break;
    case 2:
        Console.WriteLine($"Hey, you selected Pap, a scop of pap cost {priceOfPap}. How many scoops of pap would you like to buy?");
        orderOfPap = Convert.ToInt32(Console.ReadLine());
        if (orderOfPap > limitOfPap)
        {
            Console.WriteLine("You exceeded the available number of pap available");
            return;
        }
        totalAmount = priceOfPap * orderOfPap;
        break;
    case 3:
        Console.WriteLine($"Hey, you selected Pap and akara, \n a scoop of pap cost {priceOfPap} and a  pice of akara cost {priceOfAkara}" +
            $". How many scoops of pap and pieces of akara would you like to buy?");
        Console.WriteLine("Input quantity of pap");
        orderOfPap = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input quantity of akara");
        orderOfAkara = Convert.ToInt32(Console.ReadLine());
        totalAmount = (orderOfAkara * priceOfAkara) + (orderOfPap * priceOfPap);
        break;
    default:
        Console.WriteLine("Invalid input!");
        return;
}

*/

// Class 5

/*
 * variables
 * limitOfPap
 * limitOfAkara
 * priceOfPap
 * PriceOfAkara
 * orderOfPap
 * orderOfAkara
 
 */
int orderOfPap;
int orderOfAkara;
decimal priceOfAkara = 50;
decimal priceOfPap = 100;
decimal totalAmount;
Console.WriteLine("Hello!! Welcome to our store.");
Console.WriteLine("We sell pap and akara");
int limitOfPap = 100;
int limitOfAkara = 100;

Console.WriteLine("Please what would you like to order");
Console.WriteLine("Input 1 for Akara, 2 for pap and 3 for pap and akara");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:

        Console.WriteLine($"Hey, you selected Akara, a piece of akara cost {priceOfAkara}. How many akara would you like to buy?");
        orderOfAkara = Convert.ToInt32(Console.ReadLine());
        if (orderOfAkara > limitOfAkara)
        {
            Console.WriteLine("You exceeded the available number of akara available");
            return;
        }
        totalAmount = orderOfAkara * priceOfAkara;
        break;
    case 2:
        Console.WriteLine($"Hey, you selected Pap, a scop of pap cost {priceOfPap}. How many scoops of pap would you like to buy?");
        orderOfPap = Convert.ToInt32(Console.ReadLine());
        if (orderOfPap > limitOfPap)
        {
            Console.WriteLine("You exceeded the available number of pap available");
            return;
        }
        totalAmount = priceOfPap * orderOfPap;
        break;
    case 3:
        Console.WriteLine($"Hey, you selected Pap and akara, \n a scoop of pap cost {priceOfPap} and a  pice of akara cost {priceOfAkara}" +
            $". How many scoops of pap and pieces of akara would you like to buy?");
        Console.WriteLine("Input quantity of pap");
        orderOfPap = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input quantity of akara");
        orderOfAkara = Convert.ToInt32(Console.ReadLine());
        totalAmount = (orderOfAkara * priceOfAkara) + (orderOfPap * priceOfPap);
        break;
    default:
        Console.WriteLine("Invalid input!");
        return;
}

Console.WriteLine($"Your total expense is {totalAmount}");
Console.WriteLine("Input 1 to proceed to payment? ");
int option = Convert.ToInt32(Console.ReadLine());
if (option == 1)
{

    decimal atmCurrentBalance = 200000m;
    decimal userAccountBalance = 50000.0m;
    decimal charge;
    string password = string.Empty;
    string correctPassword = "TJ";

    Console.WriteLine("Please input Password");
    password = Console.ReadLine();


    int limit = 5;
    int index = 1;
    bool get = true;


    while (index < limit && (password != correctPassword))
    {
        index += 1;

        Console.WriteLine(index);
        Console.WriteLine("Please input Password");
        password = Console.ReadLine();

        if (index == 5)
        {
            Console.WriteLine("You exceeded the limit");
            return;
        }

    }

    Console.WriteLine("Please input an account type");
    Console.WriteLine("Input S for savings account and C for current account");
    string accountType = Console.ReadLine().ToLower();

    switch (accountType)
    {
        case "s":

            charge = (0.5m / 100) * totalAmount;
            totalAmount = totalAmount + charge;

            if (totalAmount > userAccountBalance)
            {
                Console.WriteLine("Insufficient balance!!!!");
                return;
            }

            if (totalAmount < 1000.00m)
            {
                Console.WriteLine("Please input an amount greater than 999!!");
                return;
            }

            if (atmCurrentBalance < 1000.00m)
            {
                Console.WriteLine("Temporarily unable to dispense cash!!");
                return;
            }

            if (atmCurrentBalance > 1000.00m && atmCurrentBalance < totalAmount)
            {
                Console.WriteLine("Dey play! Please withdraw a lower amount!!");
                return;
            }

            Console.WriteLine("Cash dispensed successfully!!!");
            break;
        case "c":
            Console.WriteLine("Kindly be informed that we do not support current accounts");
            break;
        default:
            Console.WriteLine("Inapproatiate Entry, Please try again!");
            break;

    }

}
else
{
    Console.WriteLine("It would be nice of you to try our tasty akara and smooth pap!");
}