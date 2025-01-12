using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atahualpa_ferresys.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        [JsonProperty("paternal_surname")]
        public string PaternalSurname { get; set; }
        [JsonProperty("maternal_surname")]
        public string MaternalSurname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        [JsonProperty("role_id")]
        public int RoleId { get; set; }
        
    }
}
