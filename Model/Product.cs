namespace LinqPracticeTask.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }

        public Product(int id, string name, string category, decimal price, bool inStock)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
            InStock = inStock;
        }
    }

}
