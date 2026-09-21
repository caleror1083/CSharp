using System;
using System.Collections.Generic;

namespace DentalOfficeSchedulingApp.Models
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
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; } = null!;

        public virtual ICollection<City> Cities { get; set; }
    }
}
