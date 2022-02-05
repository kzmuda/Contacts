using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            return Ok();
        }
    }
}
