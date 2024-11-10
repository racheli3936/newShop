namespace WebApplication1
{
    public class Employer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int NumCustomerEnter { get; set; }
        public double Salary {  get; set; }

        public Employer()
        {
            NumCustomerEnter = 0;
        }
        public Employer(int id, string name, string phone):this() 
        {
            Id = id;
            Name = name;
            Phone = phone;
        }
    }
}
