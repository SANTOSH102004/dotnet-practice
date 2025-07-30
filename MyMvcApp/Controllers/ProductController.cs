using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class ProductController : Controller
{
    public IActionResult Index()
    {
        var list = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop" },
            new Product { Id = 2, Name = "Mouse" }
        };
        return View(list);
    }
}