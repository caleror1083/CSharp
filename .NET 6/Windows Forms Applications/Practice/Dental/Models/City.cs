using System;
using System.Collections.Generic;

namespace Dental.Models
{
    public partial class City
    {
        public City()
        {
            Addresses = new HashSet<Address>();
        }

        public int CityId { get; set; }
        public string City1 { get; set; } = null!;
        public int CountryId { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public byte[] LastUpdate { get; set; } = null!;
        public string LastUpdateBy { get; set; } = null!;

        public virtual Country Country { get; set; } = null!;
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
