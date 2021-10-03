using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProduts()
        {
            return "this will be the list of Products";
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "single product";
        }
    }
}