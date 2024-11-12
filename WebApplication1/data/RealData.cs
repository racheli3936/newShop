namespace WebApplication1.data
{
    static public class RealData
    {
        public static List<ClubCard> ClubCards { get; set; } = new List<ClubCard>();
        public static List<Product> Products { get; set; } = new List<Product>();
        public static List<Order> Ordres { get; set; } = new List<Order>();
        //public static Order order1 { get; set; }
        //  public static List<Employer> employers { get; set; } = new List<Employer>();
        public static int numClubCards { get; set; } = 0;
    }
}
