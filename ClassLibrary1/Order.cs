using WebApplication1;

namespace WebApplication1
{
    public class Order
    {
        static int orderId;
        public int Id { get; set; }
        public int CustId { get; set; }
        public DateTime DateOrder { get; set; }
        public List<Product> AllProducts { get; set; }
        public double SumBuying { get; set; }
        public int EmployeeId {  get; set; }
        public Order()
        {
            
        }
        public Order(int id, int custId, DateTime dateOrder, double sumBuying)
        {
            Id = id;
            CustId = custId;
            DateOrder = dateOrder;
            AllProducts = new List<Product>();
            SumBuying = sumBuying;
        }
        public override string ToString()
        {
            //  Class.ClubCards.Find(item=>item.Customer.Id == Id);
            // string name = Class.ClubCards.ForEach(card => { if (card.Customer.Id == Id) { } });
            string products = "";
            AllProducts.ForEach(p => products += p.ToString());
           
            return $"id: {Id}\nhello to {CustId}\ndate: {DateOrder}\n{products}\nsum: {SumBuying} ";
        }
    }
}
