using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atahualpa_ferresys.Entities
{
    public class Supplier
    {
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("ruc")]
        public string Ruc {  get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("visible")]
        public bool Visible { get; set; }

        public Supplier() { }

        public Supplier(string name, string ruc, string address, string phone, string email, string description, bool visible)
        {
            Name = name;
            Ruc = ruc;
            Address = address;
            Phone = phone;
            Email = email;
            Description = description;
            Visible = visible;
        }

        public string ToJSON()
        {
            var sb = new StringBuilder();
            sb.Append("{");
            sb.AppendFormat("\"id\": {0}, ", Id);
            sb.AppendFormat("\"name\": \"{0}\", ", Name ?? string.Empty);
            sb.AppendFormat("\"ruc\": \"{0}\", ", Ruc ?? string.Empty);
            sb.AppendFormat("\"address\": \"{0}\", ", Address ?? string.Empty);
            sb.AppendFormat("\"phone\": \"{0}\", ", Phone ?? string.Empty);
            sb.AppendFormat("\"email\": \"{0}\", ", Email ?? string.Empty);
            sb.AppendFormat("\"description\": \"{0}\", ", Description ?? string.Empty);
            sb.AppendFormat("\"visible\": {0}", Visible.ToString().ToLower());
            sb.Append("}");
            return sb.ToString();
        }
    }
}
