namespace WebApplication1
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public Product()
        {
            Description = "no special information";
        }
        public Product(int id, string name, int amount ,double price, string description = "no special information")
        {
            Id = id;
            Name = name;
            Description = description;
            Amount = amount;
            Price = price;
        }
        public override string ToString()
        {
            return Name + " " + Price+" "+Description;
        }
    }
}
