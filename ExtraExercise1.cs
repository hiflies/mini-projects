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
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("1. Search and learn C# Random");
                Console.WriteLine("2. Random numbers and sum");
                Console.WriteLine("3. Classify Numbers");
                Console.WriteLine("4. Random_Numbers");
                Console.WriteLine("5. Two_Dice (in progress)");
                Console.WriteLine();
                Console.ResetColor();
                Console.Write("Exercise: ");

                string data = Console.ReadLine().Trim();

                if (data.ToUpper() == "EXIT")
                {
                    break;
                }

                if (data == "1")
                {
                    Console.WriteLine("Search and learn C# Random\n https://www.tutorialsteacher.com/articles/generate-random-numbers-in-csharp");
                    continue;
                }

                if (data == "2")
                {
                    int[] numbers = new int[5];
                    int sum = 0; //long is better
                    Console.Write("5 random numbers: ");

                    Random rnd = new Random();

                    for (int i = 0; i < 5; i++)
                    {
                        numbers[i] = rnd.Next(1, 100);
                        Console.Write("{0} ", numbers[i]);
                        sum += numbers[i];
                    }

                    //Console.WriteLine(String.Join(',', numbers)); 
                    Console.WriteLine();
                    Console.Write("The sum is ");
                    Console.WriteLine(sum);
                    Console.WriteLine();


                    Console.WriteLine("-------------------------------");
                    continue;
                }

                if (data == "3")
                {
                    Random rnd = new Random();
                    int num = rnd.Next(-10, 11);

                    Console.WriteLine("The generated number is {0}", num);
                    if (num % 2 == 0)
                    {
                        Console.Write($"'{num}' is even and ");
                    }
                    else
                    {
                        Console.Write($"'{num}' is odd and ");
                    }

                    if (num < 0)
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

                if (data == "4")
                {
                    Console.Write("Enter number of integers to be generated: ");


                    int count;
                    if (!int.TryParse(Console.ReadLine(), out count))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You need to write a number");
                        Console.ResetColor();
                        continue;
                    }


                    if (count < 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter a positive number");
                        Console.ResetColor();
                        continue;
                    }

                    int[] numbers = new int[count];
                    int sum = 0;

                    Console.Write("Generated values: ");

                    Random rnd = new Random();

                    for (int i = 0; i < count; i++)
                    {
                        numbers[i] = rnd.Next(1, 101);
                        Console.Write("{0} ", numbers[i]);
                        sum += numbers[i];
                    }

                    double avg = sum / count;
                    Array.Sort(numbers);

                    Console.WriteLine();
                    Console.Write("Average, min, max are ");
                    Console.WriteLine($"{avg}, {numbers[0]}, {numbers[count - 1]}");
                    Console.WriteLine();



                    Console.WriteLine("-------------------------------");
                    continue;
                }

                if (data == "5")
                {
                    int rollingtimes = 10;
                    int[] sum = new int[10];
                    int count = 0;

                    Random rnd = new Random();

                    Console.Write("Frequency table (sum, count) for rolling two dices 10000 times: ");

                    for (int i = 0; i < rollingtimes; i++)
                    {
                        sum[i] = rnd.Next(1, 7);

                    }
                    for (int i = 0; i < rollingtimes; i++)
                    {
                        sum[i] += rnd.Next(1, 7);

                    }
                    Array.Sort(sum);


                    for (int i = 0; i < rollingtimes; i++)
                    {
                        for (int j = 0; j < 11; j++)
                        {
                            if (sum[i] == j + 2)
                            {
                                count++;
                            }
                            else
                            {
                                Console.WriteLine($"{sum[i]} - {count}");
                                count = 0;
                                break;
                            }
                        }

                        //Console.Write("{0} ", sum[i]);
                        //Console.WriteLine(count);

                    }
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------");
                    continue;
                }

                else
                {
                    Console.WriteLine("-------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You need to write a number from the list.");
                    Console.ResetColor();
                }
            }

        }

    }
}

