namespace WebApplication1
{
    public class ClubCard
    {
        public int NumCard { get; set; }
        public Customer Customer { get; set; }
        public int NumPoint { get; set; }
        public DateTime DateOfJoin { get; set; }

        public ClubCard()
        {
            
        }

        public ClubCard(int numCard, Customer customer, int numPoint, DateTime dateOfJoin)
        {
            NumCard = numCard;
            Customer = customer;
            NumPoint = numPoint;
            DateOfJoin = dateOfJoin;
        }
    }
}
