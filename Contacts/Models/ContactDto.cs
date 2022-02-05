using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Contacts.Models
{
    public class ContactDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Name => $"{FirstName} {LastName}";

        public List<PhoneDto> Phones { get; set; }
    }
}
