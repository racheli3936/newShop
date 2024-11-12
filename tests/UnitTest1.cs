using WebApplication1;
using WebApplication1.Controllers;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void Get_ReturnsOk()
        {
            //Arrange
            var id = 1;

            //Act
            var controller = new ProductsController();
            var result = controller.Get(id);

            //Assert
            Assert.IsType<Product>(result);
        }

    }
}