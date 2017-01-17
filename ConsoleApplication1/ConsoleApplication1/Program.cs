using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Money:");

        decimal money = decimal.Parse(Console.ReadLine());

        if (money >= 50)
        {
            Console.WriteLine("I'll give it to IZdislav");
            return;
        }


        Console.WriteLine("I don't have enough money. Sorry! :( ;d");

    }
}

