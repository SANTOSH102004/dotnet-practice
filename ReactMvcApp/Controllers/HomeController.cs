using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ReactMvcApp.Models;

namespace ReactMvcApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult React()
    {
        return View();
    }

    private static List<Product> _products = new List<Product>
    {
        new Product { Id = 1, Name = "Laptop", Price = 999.99m, Category = "Electronics" },
        new Product { Id = 2, Name = "Smartphone", Price = 499.99m, Category = "Electronics" },
        new Product { Id = 3, Name = "Headphones", Price = 89.99m, Category = "Electronics" },
        new Product { Id = 4, Name = "Coffee Mug", Price = 12.99m, Category = "Kitchen" },
        new Product { Id = 5, Name = "Desk Lamp", Price = 29.99m, Category = "Home" }
    };

    [HttpGet]
    [Route("api/products")]
    public IActionResult GetProducts()
    {
        return Ok(_products);
    }

    [HttpPost]
    [Route("api/products")]
    public IActionResult CreateProduct([FromBody] Product product)
    {
        if (product == null)
            return BadRequest("Product data is required");

        if (string.IsNullOrWhiteSpace(product.Name))
            return BadRequest("Product name is required");

        if (product.Price <= 0)
            return BadRequest("Product price must be greater than 0");

        if (string.IsNullOrWhiteSpace(product.Category))
            return BadRequest("Product category is required");

        // Generate new ID
        var maxId = _products.Any() ? _products.Max(p => p.Id) : 0;
        product.Id = maxId + 1;

        _products.Add(product);
        return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
    }

    [HttpGet]
    [Route("api/products/{id}")]
    public IActionResult GetProduct(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null)
            return NotFound($"Product with ID {id} not found");

        return Ok(product);
    }

    [HttpPut]
    [Route("api/products/{id}")]
    public IActionResult UpdateProduct(int id, [FromBody] Product product)
    {
        if (product == null)
            return BadRequest("Product data is required");

        var existingProduct = _products.FirstOrDefault(p => p.Id == id);
        if (existingProduct == null)
            return NotFound($"Product with ID {id} not found");

        if (string.IsNullOrWhiteSpace(product.Name))
            return BadRequest("Product name is required");

        if (product.Price <= 0)
            return BadRequest("Product price must be greater than 0");

        if (string.IsNullOrWhiteSpace(product.Category))
            return BadRequest("Product category is required");

        existingProduct.Name = product.Name;
        existingProduct.Price = product.Price;
        existingProduct.Category = product.Category;

        return Ok(existingProduct);
    }

    [HttpDelete]
    [Route("api/products/{id}")]
    public IActionResult DeleteProduct(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null)
            return NotFound($"Product with ID {id} not found");

        _products.Remove(product);
        return NoContent();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Category { get; set; } = string.Empty;
}
