using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Money:");

        decimal money = decimal.Parse(Console.ReadLine());

<<<<<<< HEAD
        if (money >= 50)
        {
            Console.WriteLine("I'll give it to IZdislav");
            return;
=======
            if (money>=50)
            {
                if (money % 4 == 0)
                {
                    Console.WriteLine("Vzimame parite za nas");
                }
                else
                {
                    Console.WriteLine("I'll give it to IZdislav");
                    return;
                }
            } 
            
            
            Console.WriteLine("I don't have enough money. Sorry! :( ;d");

            Console.WriteLine("Izdislav was here");

            bool isHappy = true;
            
>>>>>>> 099f44b57694500a21a04bb07d16ede76f15915b
        }


        Console.WriteLine("I don't have enough money. Sorry! :( ;d");

    }
}

