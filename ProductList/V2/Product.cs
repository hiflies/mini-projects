namespace Mini_Projects.ProductList.V2
{
    public class Product
    {
        public string Category { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }

        public Product(string category, string name, int price)
        {
            Category = category;
            ProductName = name;
            Price = price;
        }
    }

}

