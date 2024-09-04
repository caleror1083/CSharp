using System;
using System.Collections.Generic;

namespace DentalOfficeSchedulingApp.Models
{
    public partial class User
    {
        public User()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public byte Active { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; } = null!;

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
