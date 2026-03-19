namespace Mini_Projects
{
    public static class ProductListV1
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
                    ConsoleHelper.WriteError("Du får inte ange ett tomt värde");
                    continue;
                }

                string[] parts = data.Split('-');
                if (parts.Length != 2)
                {
                    ConsoleHelper.WriteError("Felaktig format på produktnumret");
                    continue;
                }

                string text = parts[0];
                if (text.Length == 0)
                {
                    ConsoleHelper.WriteError("Felaktig format på vänstra delen av produktnumret");
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
                    ConsoleHelper.WriteError("Felaktig format på vänstra delen av produktnumret");
                    continue;
                }

                if (parts[1].StartsWith("+"))
                {
                    ConsoleHelper.WriteError("Felaktig format på högra delen av produktnumret");
                    continue;
                }

                int number;
                if (!int.TryParse(parts[1], out number))
                {
                    ConsoleHelper.WriteError("Felaktig format på högra delen av produktnumret");
                    continue;
                }

                if (number < 200 || number > 500)
                {
                    ConsoleHelper.WriteError("Den numeriska delen måste vara mellan 200 och 500");
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

