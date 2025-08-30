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

    [HttpGet]
    [Route("api/products")]
    public IActionResult GetProducts()
    {
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 999.99m, Category = "Electronics" },
            new Product { Id = 2, Name = "Smartphone", Price = 499.99m, Category = "Electronics" },
            new Product { Id = 3, Name = "Headphones", Price = 89.99m, Category = "Electronics" },
            new Product { Id = 4, Name = "Coffee Mug", Price = 12.99m, Category = "Kitchen" },
            new Product { Id = 5, Name = "Desk Lamp", Price = 29.99m, Category = "Home" }
        };

        return Ok(products);
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
