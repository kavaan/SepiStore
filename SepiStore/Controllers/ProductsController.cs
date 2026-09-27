using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SepiStore.DTOs;
using SepiStore.Models;
using SepiStore.Services;

namespace SepiStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private ProductService _productService = new ProductService();

        [HttpPost]
        public IActionResult Add([FromBody] CreateProductDto productDto)
        {
            Product product = new Product();
            product.Price = productDto.Price;
            product.Name = productDto.Name;
            _productService.AddProduct(product);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productService.GetProducts());    
        }
    }
}
