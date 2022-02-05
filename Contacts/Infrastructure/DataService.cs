using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contacts.Models;

namespace Contacts.Infrastructure
{
    public class DataService
    {
        public static DataService Current { get; } = new DataService();
        public List<ContactDto> Contacts { get; set; }
        public DataService()
        {
            Contacts = new List<ContactDto>()
            {
                new ContactDto { Id = 1, FirstName = "Jan", LastName = "Kowalski", Email = "jkowalski@gmail.com"},
                new ContactDto { Id = 2, FirstName = "Anna", LastName = "Nowak", Email = "anowak@gmail.com"},
                new ContactDto { Id = 3, FirstName = "Adam", LastName = "Malinowski", Email = "amalinowski@gmail.com"},
            };
        }
    }
}
