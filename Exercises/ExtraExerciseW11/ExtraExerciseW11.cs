using Mini_Projects.Utils;

namespace Mini_Projects.Exercises
{
    public class ExtraExerciseW11
    {

        public static void Run()
        {
            while (true)
            {
                Console.Clear();
                ConsoleHelper.WriteInfo("Type the number or 'exit' to quit");
                Console.WriteLine("1. Search and learn C# Random");
                Console.WriteLine("2. Random numbers and sum");
                Console.WriteLine("3. Classify Numbers");
                Console.WriteLine("4. Random_Numbers");
                Console.WriteLine("5. Two_Dice");
                Console.WriteLine("6. Short Name (in progress)");
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
                    ConsoleHelper.AskEnterToContinue();
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
                    ConsoleHelper.AskEnterToContinue();
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
                    ConsoleHelper.AskEnterToContinue();
                    continue;
                }

                if (data == "4")
                {
                    Console.Write("Enter number of integers to be generated: ");


                    int count;
                    if (!int.TryParse(Console.ReadLine(), out count))
                    {
                        ConsoleHelper.WriteError("You need to write a number");
                        continue;
                    }


                    if (count < 1)
                    {
                        ConsoleHelper.WriteError("Enter a positive number");
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
                    ConsoleHelper.AskEnterToContinue();
                    continue;
                }

                if (data == "5")
                {
                    int rollingtimes = 10000;

                    Random rnd = new Random();
                    Dictionary<int, int> count = new Dictionary<int, int>();

                    Console.Write("Frequency table (sum, count) for rolling two dices 10000 times: ");

                    for (int i = 0; i < rollingtimes; i++)
                    {
                        int die1 = rnd.Next(1, 7);
                        int die2 = rnd.Next(1, 7);
                        int sum = die1 + die2;

                        if (count.ContainsKey(sum))
                        {
                            count[sum]++;
                        }
                        else
                        {
                            count[sum] = 1;
                        }

                    }

                    //int[] ll = new int[5];
                    //for (int i = 0; i < ll.Length; i++)
                    //{
                    //    int item = ll[i];
                    //    Console.WriteLine(item);
                    //}

                    //foreach (int item in ll)
                    //{
                    //    Console.WriteLine(item);
                    //}

                    foreach (var item in new SortedDictionary<int, int>(count))
                    {
                        Console.WriteLine(item.Key + "-" + item.Value);
                    }
                    ConsoleHelper.AskEnterToContinue();
                    continue;
                }

                if(data == "6")
                {
                    Console.Write("Enter the name and surname: ");
                    Console.ReadLine();
                    
                    // split ile ayir
                    // ilkinin ilk harfi + .
                    // ikincinin ilk dort harfi. dortten az ise tamami

                    continue;
                }
                else
                {
                    ConsoleHelper.WriteSeparator();
                    ConsoleHelper.WriteError("You need to write a number from the list.");
                }
            }

        }

    }
}

