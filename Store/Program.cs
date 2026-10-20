// Currents Bugs:
// when i press/hold Enter it spams reprints the shop as Enter counts as a invalid amount and continue; makes it reprint



int m = 100; 
int price = 0;


  while(m > 0)
{
  Console.Clear();
  Thread.Sleep(200);
  Console.WriteLine("-------------------------------");
  Thread.Sleep(100);
  Console.WriteLine("[WARNING] FAKE CURRENCYS!     |");
  Thread.Sleep(100);
  Console.WriteLine("                              |");
  Console.WriteLine("Welcome to Tomhardware!       |");
  Thread.Sleep(100);
  Console.WriteLine("                              |");
  Thread.Sleep(100);
  Console.WriteLine($"Balance: {m}$");
  Thread.Sleep(100);
  Console.WriteLine("                              |");
  Console.WriteLine("-------------------------------");
  Console.WriteLine("Store options:                |");
  Thread.Sleep(100);
  Console.WriteLine("1. Toilet [11$]               |");
  Thread.Sleep(100);
  Console.WriteLine("2. Table [22$]                |");
  Thread.Sleep(100);
  Console.WriteLine("3. Soda [3$]                  |");
  Console.WriteLine("-------------------------------");
  Thread.Sleep(100);
  Console.WriteLine("What would you like to purchase?");
  string n = Console.ReadLine();
if (n == "")
{
    Console.WriteLine("You must enter a choice!");
    Thread.Sleep(1000);
    continue;
}

bool success = int.TryParse(n, out int choice);
Thread.Sleep(100);
Console.WriteLine("How many would you like?");
string amountInput = Console.ReadLine();

if (amountInput == "")
{
    Console.WriteLine("You must enter an amount!");
    Thread.Sleep(1000);
    continue;
}

bool amountSuccess = int.TryParse(amountInput, out int amount);
// if the choice you choose is invalid by false or 0 it trigger not a valid amount and continues
if(success == false || choice <=0)
  { 
    Console.WriteLine("Not a valid amount!");
    Console.ReadLine();
    continue;
  } 
// if amount is false or 0 it triggers a messege which says that is invalid amount and continues.
if (amountSuccess == false || amount <=0)
    {
      Console.WriteLine("Invalid amount!");
      Console.ReadLine();
      continue;
    }

// prices of the items when u choose the number between 1-3
if (choice == 1)
{
    price = 11;
}
else if (choice == 2)
{
    price = 22;
}
else if (choice == 3)
{
    price = 3;
}
else
{
    Console.WriteLine("Not a valid choice!");
    Console.ReadLine();
    continue;
}
// triggers if u dont have enough money to purchesed the specific amount
if (price * amount > m)
{
    Console.WriteLine("Not enough money!");
    Console.ReadLine();
    continue;
}

// what happeneds when u type in the numbers from 1-3
if (choice == 1)
    {

    Console.WriteLine($"Successfully purchesed {amount}x [Toilet]");

    }
  
  else if (choice == 2)
  {
    Console.WriteLine($"Successfully purchesed {amount}x [Table]");

  }

  else if (choice == 3)
  {
    
    Console.WriteLine($"Successfully purchesed {amount}x [Soda]");
  }

m -= price * amount;

  Console.WriteLine($"Balance: {m}$");
  Console.ReadLine();
}
  
