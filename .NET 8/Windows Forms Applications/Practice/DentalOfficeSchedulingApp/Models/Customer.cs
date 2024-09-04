using System;
using System.Collections.Generic;

namespace DentalOfficeSchedulingApp.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;
        public int AddressId { get; set; }
        public byte Active { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public byte[] LastUpdate { get; set; } = null!;
        public string LastUpdateBy { get; set; } = null!;

        public virtual Address Address { get; set; } = null!;
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
