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
            return RealData.Products;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            //RealData.products.Add(new Product(1, "milk", 10, 10, "fresh"));
            return RealData.Products.Find(item => item.Id == id);
        }

        // POST api/<ProductsController>
        [HttpPost("/{id}/{numNews}")]
        public void Post([FromBody] int id,int numNews)
        {
            RealData.Products.Find(item => item.Id == id).Amount += numNews;
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{product}")]
        public void Put(Product p1)
        {
            RealData.Products.Add(p1);
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
