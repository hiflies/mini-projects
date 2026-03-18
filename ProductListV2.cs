using System;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace Mini_Projects
{
    public class ProductListV2
    {
        public static void Run()
        {
            //Console.WriteLine("Pick an option: ");
            var productList = new List<Product>();


            while (true)
            {

                Console.Write("1. Category ");
                string category = Console.ReadLine();
                if (category.ToLower() == "q")
                {
                    break;
                }
                Console.Write("2. Product Name ");
                string name = Console.ReadLine();
                Console.Write("3. Price ");
                int price = int.Parse(Console.ReadLine());
                //decimal price = Console.ReadLine();

                productList.Add(new Product(category, name, price));
                Console.WriteLine(string.Join(" - ", productList));
            }
        }
            //foreach (Product product in productList)
            //{
            //    Console.WriteLine($"{product.category} {product.name} {product.price} ");
            //}

    class Product
        {
            public Product(string category, string name, int price)
            {
                Category = category;
                ProductName = name;
                Price = price;

            }

            public string Category { get; set; }
            public string ProductName { get; set; }
            public int Price { get; set; }

            public override string ToString()
            {
                return $"Category: {Category}, Product Name: {ProductName}, Price: {Price}";
            }

        }


    }
    }
