﻿namespace HotelProject.EntityLayer.Concrete
{
    public class MessageCategory
    {
        public int MessageCategoryId { get; set; }
        public string MessageCategoryName { get; set; }
        public virtual List<Contact> Contacts { get; set; }
    }
}