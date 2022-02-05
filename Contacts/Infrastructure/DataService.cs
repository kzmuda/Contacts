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

        public static int NextId => Current.Contacts.Count + 1;
        public List<ContactDto> Contacts { get; set; }
        public DataService()
        {
            Contacts = new List<ContactDto>()
            {
                new ContactDto
                {
                    Id = 1, FirstName = "Jan", LastName = "Kowalski", Email = "jkowalski@gmail.com",
                    Phones = new List<PhoneDto>()
                    {
                        new PhoneDto() { Id = 1, Number = "00000", Description = "Komórka"},
                        new PhoneDto() { Id = 2, Number = "11111", Description = "Domowy"}
                    }
                },
                new ContactDto { Id = 2, FirstName = "Anna", LastName = "Nowak", Email = "anowak@gmail.com"},
                new ContactDto { Id = 3, FirstName = "Adam", LastName = "Malinowski", Email = "amalinowski@gmail.com"},
            };
        }
    }
}
