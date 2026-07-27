using Assignment14_27july.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment14_27july.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        static List<Product> products = new List<Product>()
        {
             new Product(){ ProductId = 1 , ProductName="Cement", Price=350, Quantity=100 , Category="constructions"},
             new Product(){ ProductId = 2 , ProductName="pipes", Price=100, Quantity=20 , Category="constructions"},
             new Product(){ ProductId = 3 , ProductName="iron", Price=200, Quantity=25, Category = "constructions"},
             new Product(){ ProductId = 4 , ProductName="Cup", Price=300, Quantity=26, Category = "Grocery"},
             new Product(){ ProductId = 5 , ProductName="Tshirt", Price=400, Quantity=200, Category = "Clothes"},
             new Product(){ ProductId = 6 , ProductName="Tie", Price=500, Quantity=100, Category = "Clothes"},
             new Product(){ ProductId = 7 , ProductName="vegetables", Price=600, Quantity=2, Category = "Grocery"},
        };
        [HttpGet]
        public IActionResult getProduct()
        {
            return Ok(products);
        }


        [HttpGet("{id}")]
        public IActionResult getProductById(int id)
        {
            var product = products.FirstOrDefault(x => x.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);

        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            products.Add(product);

            return Ok(product);
        }

        [HttpPut("{id}")]

        public IActionResult UpdateProduct(int id, Product product)
        {
            var product1 = products.FirstOrDefault(x => x.ProductId == id);
            if (product1 == null)
            {
                return NotFound();
            }
            product1.Price = product.Price;
            return Ok(product1);
        }


        [HttpGet("Category/{category}")]

        public IActionResult GetProductByCategory(string category)
        {
            var result = products.Where(s => s.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!result.Any())
            {
                return NotFound("No Product found under this Category ");
            }
            return Ok(result);
        }


    }
}
