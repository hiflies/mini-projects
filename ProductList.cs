namespace Mini_Projects
{
    public static class ProductList
    {
        public static void Run()
        {

            List<string> productList = new();

            Console.WriteLine("Skriv in produkter. Avsluta med att skriva 'exit'");


            while (true)
            {
                Console.Write("Ange produkt: ");
                string data = Console.ReadLine().Trim();
                if (data.ToUpper() == "EXIT")
                {
                    break;
                }

                if (data == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du får inte ange ett tomt värde");
                    Console.ResetColor();
                    continue;
                }

                string[] parts = data.Split('-');
                if (parts.Length != 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Felaktig format på produktnumret");
                    Console.ResetColor();
                    continue;
                }

                string text = parts[0];
                if (text.Length == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Felaktig format på vänstra delen av produktnumret");
                    Console.ResetColor();
                    continue;
                }

                bool isLetter = true;
                for (int i = 0; i < text.Length; i++)
                {
                    if (!char.IsLetter(text[i]))
                    {
                        isLetter = false;
                        break;
                    }
                }

                if (!isLetter)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Felaktig format på vänstra delen av produktnumret");
                    Console.ResetColor();
                    continue;
                }

                if (parts[1].StartsWith("+"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Felaktig format på högra delen av produktnumret");
                    Console.ResetColor();
                    continue;
                }

                int number;
                if (!int.TryParse(parts[1], out number))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Felaktig format på högra delen av produktnumret");
                    Console.ResetColor();
                    continue;
                }

                if (number < 200 || number > 500)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Den numeriska delen måste vara mellan 200 och 500");
                    Console.ResetColor();
                    continue;
                }

                productList.Add(data);

            }

            productList.Sort();

            Console.WriteLine("Du angav följande produkter: ");
            for (int i = 0; i < productList.Count; i++)
            {
                Console.WriteLine(productList[i]);

            }
        }
    }
}

