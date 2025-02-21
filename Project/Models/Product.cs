namespace Project.Models
{
    public record class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string[] Sizes { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
