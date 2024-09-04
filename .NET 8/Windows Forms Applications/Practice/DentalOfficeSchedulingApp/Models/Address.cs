using System;
using System.Collections.Generic;

namespace DentalOfficeSchedulingApp.Models
{
    public partial class Address
    {
        public Address()
        {
            Customers = new HashSet<Customer>();
        }

        public int AddressId { get; set; }
        public string Address1 { get; set; } = null!;
        public string? Address2 { get; set; }
        public int CityId { get; set; }
        public string PostalCode { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public byte[] LastUpdate { get; set; } = null!;
        public string LastUpdateBy { get; set; } = null!;

        public virtual City City { get; set; } = null!;
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
