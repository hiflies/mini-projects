using System;
namespace Mini_Projects
{
    public class ExtraExercise1
    {

        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("Type the number or 'exit' to quit");
                Console.WriteLine("1. Random numbers and sum");
                Console.WriteLine("2. Classify Numbers (in progress)");

                string data = Console.ReadLine().Trim();

                if (data.ToUpper() == "EXIT")
                {
                    break;
                }

                if (data == "1")
                {
                    int[] numbers = new int[5];
                    int sum = 0;
                    Console.Write("5 random numbers: ");

                    Random rnd = new Random();

                    for (int i = 0; i < 5; i++)
                    {
                        numbers[i] = rnd.Next(1, 100);
                        Console.Write(numbers[i]);
                        Console.Write(" ");
                        sum += numbers[i];
                    }

                    //Console.WriteLine(String.Join(',', numbers)); 
                    Console.WriteLine("");
                    Console.Write("The sum is ");
                    Console.WriteLine(sum);
                    Console.WriteLine();


                    Console.WriteLine("-------------------------------");
                    continue;
                }

                if (data == "2")
                {
                    Random rnd = new Random();
                    int num = rnd.Next(1, 11);

                    Console.WriteLine("The generated number is {0}", num);
                    if ( num % 2 == 0)
                    {
                        Console.Write($"'{num}' is even and ");
                    }
                    else
                    {
                        Console.Write($"'{num}' is odd and ");
                    }

                    if (num< 0)
                    {
                        Console.WriteLine("negative");
                    }
                    else
                    {
                        Console.WriteLine("positive");
                    }

                    Console.WriteLine("-------------------------------");
                    continue;
                }

                else
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("You need to write a number from the list.");
                }
            }

        }

    }
}

