﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContactController : ControllerBase
	{
		private readonly IContactService _contactService;
		public ContactController(IContactService contactService)
		{
			_contactService = contactService;
		}

		[HttpGet]
		public IActionResult ContactList()
		{
			var values = _contactService.TGetList();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddContact(Contact contact)
		{
			contact.Date = Convert.ToDateTime(DateTime.Now.ToString());
			_contactService.TInsert(contact);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult GetContact(int id)
		{
			var values = _contactService.TGetById(id);
			return Ok(values);
		}
		[HttpGet("GetContactCount")]
		public IActionResult GetContactCount()
		{
			return Ok(_contactService.TGetContactCount());
		}
	}
}