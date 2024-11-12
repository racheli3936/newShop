using Microsoft.AspNetCore.Mvc;
using WebApplication1.data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyingController : ControllerBase
    {
        Order currentOrder=new Order();
        
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
           
           return currentOrder.ToString();
        
        }

        // POST api/<BuyingController>
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            currentOrder.AllProducts.Add(product);
        }

        // PUT api/<BuyingController>/5
        [HttpPut("{id}")]
        public void Put([FromBody]int productId)
        {
            double d =currentOrder.AllProducts.Find(item => item.Id == productId).Price;
            currentOrder.SumBuying += d;
        }

        // DELETE api/<BuyingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)  
        {
            currentOrder.AllProducts.Remove(currentOrder.AllProducts.Find(item => item.Id == id));
        }
    }
}
