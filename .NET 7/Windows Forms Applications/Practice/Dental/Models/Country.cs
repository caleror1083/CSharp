using System;
using System.Collections.Generic;

namespace Dental.Models
{
    public partial class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();
        }

        public int CountryId { get; set; }
        public string Country1 { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public byte[] LastUpdate { get; set; } = null!;
        public string LastUpdateBy { get; set; } = null!;

        public virtual ICollection<City> Cities { get; set; }
    }
}
