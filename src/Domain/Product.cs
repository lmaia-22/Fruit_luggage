namespace Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ProductFamily ProductFamily { get; set; }
    }
}
