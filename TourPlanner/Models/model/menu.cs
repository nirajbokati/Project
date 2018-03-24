using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TourPlanner.Models.model
{
    public class menu
    {
        public int NavbarID { get; set; }
        public string MenuName { get; set; }
        public Nullable<bool> MenuIsActive { get; set; }
        public string Menuhref { get; set; }
    }
}