namespace WebApplication1
{
    public class Customer
    {
        static int num_customer;
        public int Id { get; set; }
        public string identity { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public DateTime birthday { get; set; }
        //public int EmployerId { get; set; }
         public Customer()
        {
            num_customer = 0;
        }

        public Customer(string identity, string name, string phone, string city, string address, DateTime birthday/*,int employerId*/)
        {
            this.identity = identity;
            this.name = name;
            this.phone = phone;
            this.city = city;
            this.address = address;
            this.birthday = birthday;
            this.Id=num_customer++;
          //  this.EmployerId = employerId;
        }
    }
}
