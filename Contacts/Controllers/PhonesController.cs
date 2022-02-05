using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contacts.Infrastructure;

namespace Contacts.Controllers
{
    [Route("api/contacts/{contactId}/phones")]
    [ApiController]
    public class PhonesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPhones(int contactId)
        {
            var contact = DataService.Current.Contacts.FirstOrDefault(x => x.Id == contactId);

            if (contact == null)
            {
                return NotFound();
            }

            return Ok(contact.Phones);
        }
    }
}
