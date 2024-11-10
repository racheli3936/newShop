using Microsoft.AspNetCore.Mvc;
using WebApplication1.data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return RealData.products;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return RealData.products.Find(item => item.Id == id);
        }

        // POST api/<ProductsController>
        [HttpPost("/{id}/{numNews}")]
        public void Post([FromBody] int id,int numNews)
        {
            RealData.products.Find(item => item.Id == id).Amount += numNews;
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{product}")]
        public void Put(  Product p1)
        {
            RealData.products.Add(p1);
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
