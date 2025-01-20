using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atahualpa_ferresys.Entities
{
    public class UnitType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        public UnitType() { }

        public UnitType(string name)
        {
            Name = name;
        }

        public string ToJSON()
        {
            return $"{{" +
                   $"\"id\": {Id}, " +
                   $"\"name\": \"{Name}\", " +
                   $"\"created_at\": \"{CreatedAt:yyyy-MM-ddTHH:mm:ss}\", " +
                   $"\"updated_at\": \"{UpdatedAt:yyyy-MM-ddTHH:mm:ss}\"" +
                   $"}}";
        }
    }
}
