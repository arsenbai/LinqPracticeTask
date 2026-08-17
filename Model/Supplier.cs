namespace LinqPracticeTask.Model
{
    public class Supplier
    {
        public string Address { get; set; }
        public string Industry { get; set; }
        public static List<Product> ProductsAvailable { get; set; } = new();
    }
}
