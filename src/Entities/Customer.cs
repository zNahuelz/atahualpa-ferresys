using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atahualpa_ferresys.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("surname")]
        public string Surname { get; set; }
        [JsonProperty("dni")]
        public string Dni { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }

        public Customer() { }
        public Customer(string name, string surname, string dni, string address, string phone, string email)
        {
            Name = name;
            Surname = surname;
            Dni = dni;
            Address = address;
            Phone = phone;
            Email = email;
        }

        public string ToJSON()
        {
            return $"{{" +
                   $"\"id\": {Id}," +
                   $"\"name\": \"{(Name ?? string.Empty)}\"," +
                   $"\"surname\": \"{(Surname ?? string.Empty)}\"," +
                   $"\"dni\": \"{(Dni ?? string.Empty)}\"," +
                   $"\"address\": \"{(Address ?? string.Empty)}\"," +
                   $"\"phone\": \"{(Phone ?? string.Empty)}\"," +
                   $"\"email\": \"{(Email ?? string.Empty)}\"" +
                   $"}}";
        }
    }
}
