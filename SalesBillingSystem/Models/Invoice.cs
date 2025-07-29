using System;
using System.Collections.Generic;

namespace SalesBillingSystem.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public List<InvoiceItem> Items { get; set; }

        public Invoice()
        {
            Items = new List<InvoiceItem>();
        }
    }
}
