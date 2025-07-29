using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesBillingSystem.Data;
using SalesBillingSystem.Models;
using System.Linq;

namespace SalesBillingSystem.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly ApplicationDbContext _context;
        public InvoiceController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var invoices = _context.Invoices.Include(i => i.Customer).ToList();
            return View(invoices);
        }

        public IActionResult Details(int id)
        {
            var invoice = _context.Invoices.Include(i => i.Customer)
                                           .Include(i => i.Items)
                                           .ThenInclude(ii => ii.Product)
                                           .FirstOrDefault(i => i.Id == id);
            if (invoice == null) return NotFound();
            return View(invoice);
        }

        public IActionResult Create()
        {
            ViewBag.Customers = _context.Customers.ToList();
            ViewBag.Products = _context.Products.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Invoice invoice, int[] productIds, int[] quantities)
        {
            if (ModelState.IsValid && productIds.Length == quantities.Length)
            {
                invoice.Date = System.DateTime.Now;
                invoice.Items = new List<InvoiceItem>();
                decimal total = 0;
                for (int i = 0; i < productIds.Length; i++)
                {
                    var product = _context.Products.Find(productIds[i]);
                    if (product != null)
                    {
                        var item = new InvoiceItem
                        {
                            ProductId = product.Id,
                            Quantity = quantities[i],
                            Subtotal = product.Price * quantities[i]
                        };
                        total += item.Subtotal;
                        invoice.Items.Add(item);
                    }
                }
                invoice.Total = total;
                _context.Invoices.Add(invoice);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Customers = _context.Customers.ToList();
            ViewBag.Products = _context.Products.ToList();
            return View(invoice);
        }

        public IActionResult Delete(int id)
        {
            var invoice = _context.Invoices.Include(i => i.Customer).FirstOrDefault(i => i.Id == id);
            if (invoice == null) return NotFound();
            return View(invoice);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var invoice = _context.Invoices.Include(i => i.Items).FirstOrDefault(i => i.Id == id);
            if (invoice != null)
            {
                _context.InvoiceItems.RemoveRange(invoice.Items);
                _context.Invoices.Remove(invoice);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
