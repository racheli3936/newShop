using Microsoft.AspNetCore.Mvc;
using WebApplication1.data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyingController : ControllerBase
    {
        // GET: api/<BuyingController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BuyingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
           
           return RealData.order1.ToString();
        
        }

        // POST api/<BuyingController>
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            RealData.order1.AllProducts.Add(product);
        }

        // PUT api/<BuyingController>/5
        [HttpPut("{id}")]
        public void Put([FromBody]int productId)
        {
            double d =RealData.order1.AllProducts.Find(item => item.Id == productId).Price;
            RealData.order1.SumBuying += d;
        }

        // DELETE api/<BuyingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)  
        {
            RealData.order1.AllProducts.Remove(RealData.order1.AllProducts.Find(item => item.Id == id));
        }
    }
}
