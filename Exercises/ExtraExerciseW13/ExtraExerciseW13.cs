using System;
using Mini_Projects.Exercises.Exercise2;
using Mini_Projects.Exercises.Part2;
using Mini_Projects.Utils;

namespace Mini_Projects.Exercises
{
    public class ExtraExerciseW13
    {
        public static void Run()
        {
            while (true)
            {
                Console.Clear();
                ConsoleHelper.WriteInfo("Choose an exercise or 'q' to quit: ");
                //Console.WriteLine("Choose a version or 'q' to quit: ");
                //Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Exercise 1");
                Console.WriteLine("Exercise 2");
                Console.WriteLine("");

                Console.ResetColor();
                Console.Write("Exercise: ");

                string data = Console.ReadLine().Trim();

                if (data.ToLower() == "q")
                {
                    break;
                }

                if (data == "1")
                {
                    W13E1.Run();
                    continue;
                }
                else if (data == "2")
                {
                    Console.ResetColor();
                    W13E2.Run();
                    continue;
                }
                else
                {
                    ConsoleHelper.WriteError("You need to write a number from the list.", true);
                    //Console.ForegroundColor = ConsoleColor.DarkRed;
                    //Console.WriteLine("-------------------------------");
                    //Console.WriteLine("You need to write a number from the list.");
                    //Console.ResetColor();

                }
            }

        }
    }
}