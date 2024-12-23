﻿namespace HotelProject.EntityLayer.Concrete
{
    public class WorkLocation
    {
        public int WorkLocationId { get; set; }
        public string WorkLocationName { get; set; }
        public string WorkLocationCity { get; set; }
        public virtual List<AppUser> AppUsers { get; set; }
    }
}