using HandphoneShopSharedLibrary.Contracts;
using HandphoneShopSharedLibrary.Models;
using HandphoneShopSharedLibrary.Responses;
using Microsoft.AspNetCore.Mvc;

namespace HandphoneShopServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IProduct productServices) : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts(bool featured)
        {
            var products = await productServices.GetAllProducts(featured); return Ok(products);
        }
        [HttpPost]
        public async Task   <ActionResult<ServiceResponse>> AddProduct(Product model)
        {
            if (model is null) return BadRequest("Model is null");
            var response= await productServices.AddProduct(model);
            return Ok(response);    
        }
    }
}
