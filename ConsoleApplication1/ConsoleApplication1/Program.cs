﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());

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
            
        }
    }
}
