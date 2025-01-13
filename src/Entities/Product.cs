using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atahualpa_ferresys.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [JsonProperty("buy_price")]
        public double BuyPrice { get; set; }
        [JsonProperty("sell_price")]
        public double SellPrice { get; set; }
        public int Stock {  get; set; }
        public bool Visible { get; set; }
        [JsonProperty("supplier_id")]
        public int SupplierId { get; set; }
        [JsonProperty("unit_type")]
        public UnitType UnitType { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }


        public string UnitTypeName { get; set; }

    }
}
