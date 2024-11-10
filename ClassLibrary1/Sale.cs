namespace WebApplication1
{
    public class Sale
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public double PriceInSale { get; set; }
        public Sale()
        {
            
        }
        public Sale(int id, int idProduct, double priceInSale)
        {
            Id = id;
            IdProduct = idProduct;
            PriceInSale = priceInSale;
        }
    }
}
