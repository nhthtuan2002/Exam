namespace ConsoleApplication1
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Price}";
        }
    }
}