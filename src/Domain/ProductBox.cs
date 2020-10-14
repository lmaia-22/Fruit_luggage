namespace Domain
{
    public class ProductBox
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public double ProductQuantity { get; set; }
        public BoxType BoxType { get; set; }
        public double BoxQuantity { get; set; }
    }
}
