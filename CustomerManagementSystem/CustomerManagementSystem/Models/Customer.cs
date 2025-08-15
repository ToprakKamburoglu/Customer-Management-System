using System.ComponentModel;

namespace CustomerManagementSystem.Models
{
    public class Customer
    {
        public int Id { get; set; }

   
        public required string Name { get; set; }

        
        public required string Email { get; set; }

        [DisplayName("Adress")]
        public string Address { get; set; } = string.Empty;

        
        public string City { get; set; } = string.Empty;

       
        public string Region { get; set; } = string.Empty;

        [DisplayName("Postal Code")]
        public string PostalCode { get; set; } = string.Empty;

       
        public string Country { get; set; } = string.Empty;

        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; } = string.Empty;

        
        public string Fax { get; set; } = string.Empty;

        [DisplayName("VAT Number")]
        public string VATNumber { get; set; } = string.Empty;

    }
}
