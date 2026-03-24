namespace Mini_Projects.ProductList.V2
{
    public class Product
    {
        // private string _x32sdfs;
        //
        // public string Color
        // {
        //     get
        //     {
        //         return _x32sdfs + " " + (new Random().Next());
        //     }
        //     set
        //     {
        //         _x32sdfs = value; 
        //     }
        // }
        //
        // // public string Color { get; set; }
        
        public string Category { get; set; }
        public string ProductName { get; set; }
        public int Price { get;  set; }

        public Product(string category, string name, int price)
        {
            Category = category;
            ProductName = name;
            Price = price;
        }
    }

}

