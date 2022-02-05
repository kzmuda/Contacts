using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contacts.Infrastructure;
using Contacts.Models;

namespace Contacts.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/contacts")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        // GET http://localhost:2324/api/contacts
        [HttpGet]
        public IActionResult GetAllContacts()
        {
            var contacts = DataService.Current.Contacts;

            return Ok(contacts);
        }

        // GET http://localhost:2324/api/contacts/1
        [HttpGet("{id:int}", Name = "ContactGet")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetContact(int id)
        {
            var contact = DataService.Current.Contacts.FirstOrDefault(x => x.Id == id);

            if (contact == null)
            {
                return NotFound();
            }

            return Ok(contact);
        }

        // POST http://localhost:2324/api/contacts
        [HttpPost]
        public IActionResult CreateContact([FromBody]CreateContactDto contact)
        {
            if (!contact.FirstName.ToLower().StartsWith("a"))
            {
                ModelState.AddModelError("FirstName", "nie zaczyna sie na a");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var contactDto = new ContactDto()
            {
                Id = DataService.NextId,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Email = contact.Email
            };

            DataService.Current.Contacts.Add(contactDto);

            return CreatedAtRoute("ContactGet", new { id = contactDto.Id }, contactDto);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var contact = DataService.Current.Contacts.FirstOrDefault(x => x.Id == id);

            if (contact == null)
            {
                return NotFound();
            }

            DataService.Current.Contacts.Remove(contact);

            return NoContent();
        }
    }
}
