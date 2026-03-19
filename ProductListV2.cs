using System;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace Mini_Projects
{
    public class ProductListV2
    {
        public static void Run()
        {

            var productList = new List<Product>();

            while (true)
            {
                
                while (true)
                {
                    //Console.WriteLine("\nYeni ürün eklemek ister misiniz? (e/h)");
                    //Console.WriteLine("Pick an option: ");
                    ConsoleHelper.WriteSeparator();
                    ConsoleHelper.WriteInfo("To enter a new product - follow the steps | To quit - enter 'Q'");

                    Console.Write("Enter a Category: ");
                    string category = Console.ReadLine();


                    if (category.ToLower() == "q")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Category".PadRight(15) + "Product Name".PadRight(15) + "Price".PadRight(15));
                        Console.ResetColor();

                        foreach (var item in productList.OrderBy(o => o.Price))
                        {
                            Console.WriteLine(item.Category.PadRight(15) + item.ProductName.PadRight(15) + item.Price.ToString().PadRight(15));
                        }
                        Console.WriteLine("".PadRight(15) + "Total Amount: ".PadRight(15) + productList.Sum(o => o.Price));
                        ConsoleHelper.WriteInfo("To enter a new product - enter: 'P' | To quit - enter: 'Q'");
                        break;
                    }


                    Console.Write("Enter a Product Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter a Price: ");
                    int price = int.Parse(Console.ReadLine());

                    productList.Add(new Product(category, name, price));
                    ConsoleHelper.WriteSuccess("The product was succesfully added!");
                }
                string input = Console.ReadLine();
                if (input.ToLower() == "q")
                {
                    break;
                }
                if(input.ToLower()== "p")
                {
                    continue;
                }
                ConsoleHelper.WriteError("Follow the instruction!");

                //burada bozuluyo
            }
        }
    }
}
