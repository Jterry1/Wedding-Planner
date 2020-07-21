using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
namespace WeddingPlanner.Models
{
    public class Guest
    {
        [Key]
        public int GuestId { get; set; }
        public int PlannerId { get; set; }
        public int WeddingId { get; set; }
        public Planner Guests { get; set; }
        public Wedding Event { get; set; }
    }
}