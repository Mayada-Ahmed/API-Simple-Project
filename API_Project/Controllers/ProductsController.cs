using API_Project.Models;
using API_Project.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;
        #region Injection
        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }
        #endregion
        #region Get all Products
        [HttpGet]
        public IActionResult GetProducts()
        {
            var product = productService.GetAll();
            return Ok(product);
        }
        #endregion
        #region Get Product 
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = productService.GetById(id);

            if (product == null)
                return NotFound();
            return Ok(product);
        }
        #endregion
        #region Add Product
        [HttpPost]
        public IActionResult PostProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                productService.Insert(product);
                return Ok(product);
            }
            else
            {
                return BadRequest(product);
            }
        }
        #endregion
        #region Edit Product
        [HttpPut("{id}")]
        public IActionResult PutProduct(int id, [FromBody] Product product)
        {
            if (productService.GetById(id) == null)
            {
                return NotFound("No Product is found");
            }
            else
            {
                productService.Update(productService.GetById(id));
                return Ok(productService.GetById(id));
            }
        }
        #endregion
    }
}
