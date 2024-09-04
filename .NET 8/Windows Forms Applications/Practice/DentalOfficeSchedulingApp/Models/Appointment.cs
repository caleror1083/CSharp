﻿using System;
using System.Collections.Generic;

namespace DentalOfficeSchedulingApp.Models
{
    public partial class Appointment
    {
        public int AppointmentId { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string Url { get; set; } = null!;
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public byte[] LastUpdate { get; set; } = null!;
        public string LastUpdateBy { get; set; } = null!;

        public virtual Customer Customer { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
