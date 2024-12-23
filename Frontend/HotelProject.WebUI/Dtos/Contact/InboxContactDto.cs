﻿namespace HotelProject.WebUI.Dtos.Contact
{
	public class InboxContactDto
	{
		public int ContactId { get; set; }
		public string Name { get; set; }
		public string Mail { get; set; }
		public string Subject { get; set; }
		public string Message { get; set; }
		public DateTime Date { get; set; }
	}
}