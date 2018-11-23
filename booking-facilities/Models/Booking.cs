﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace booking_facilities.Models
{
    public class Booking
    {
        [Required]
        public virtual int BookingId { get; set; }
        [Required]
        public virtual int FacilityId { get; set; }
        public virtual Facility Facility { get; set; }
        [Required]
        public virtual DateTime BookingDateTime { get; set; }
        [Required]
        public virtual int UserId { get; set; }
    }
}