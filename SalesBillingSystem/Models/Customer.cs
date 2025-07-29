namespace SalesBillingSystem.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }

        public Customer()
        {
            Name = string.Empty;
            Email = string.Empty;
            ContactNumber = string.Empty;
        }

        // Additional properties can be added as needed
    }
}