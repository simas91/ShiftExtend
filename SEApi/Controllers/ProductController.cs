using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SEDataManager.Library.DataAccess;
using SEDataManager.Library.Models;

namespace SEApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProductData _productData;

        public ProductController(IProductData productData)
        {
            _productData = productData;
        }

        [HttpGet]
        public List<ProductModel> Get()
        {
            return _productData.GetProducts();
        }
    }
}
