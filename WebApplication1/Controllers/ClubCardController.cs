using Microsoft.AspNetCore.Mvc;
using WebApplication1.data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ClubCardController : ControllerBase
    {
        int managerPassward = 123;
        AllData a;

        public ClubCardController(AllData a)
        {
            this.a = a;
        }


        // GET: api/<ClubCardController>
        [HttpGet]
        public List<ClubCard> Get()
        {
            return RealData.ClubCards;
        }

        // GET api/<ClubCardController>/5
        [HttpGet("manager/{password}")]
        public List<ClubCard> Get(int password)
        {
            if (password == managerPassward)
                return RealData.ClubCards;
            return new List<ClubCard>();
        }
        [HttpGet("customer/{id}")]
        public ClubCard Get([FromQuery] string id)
        {
            //return 1;
            return RealData.ClubCards.FirstOrDefault(club => club.Customer.identity == id);
            //  return clubCards.Find();
        }
        // POST api/<ClubCardController>
        [HttpPost("/{id}/{name}/{p}")]
        public void Post(string id,string name,string p/*,int idEmployer*/)
        {
           // Customer customer = new Customer(id,name,p,"bb","hh",new DateTime());

            ClubCard c1 = new ClubCard(RealData.numClubCards++, new Customer(id,name,p," "," ",new DateTime()/*,idEmployer*/), 0, new DateTime(2020,12,1));
          //  Class.employers.Find(employer => employer.Id == idEmployer).NumCustomerEnter++;
            RealData.ClubCards.Add(c1);

        }

        // PUT api/<ClubCardController>/5
        [HttpPut("{idd}/{sumPay}")]
        public void Put(int id, [FromBody] string idd, double sumPay)
        {
            RealData.ClubCards.Find(club => club.Customer.identity == idd).NumPoint += (int)sumPay / 50;
        }

        // DELETE api/<ClubCardController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
