﻿namespace MicrosoftLearnTraining.Module_3
{
    class Module3_Exercise4
    {
        public void Execute()
        {
            Console.WriteLine("Module 3 - Exercise 4:");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i} - FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} - Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} - Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
