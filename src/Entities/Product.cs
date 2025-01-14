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
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("buy_price")]
        public double BuyPrice { get; set; }
        [JsonProperty("sell_price")]
        public double SellPrice { get; set; }
        [JsonProperty("stock")]
        public int Stock {  get; set; }
        [JsonProperty("visible")]
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
        [JsonProperty("unit_type_id")]
        public int UnitTypeId { get; set; }

        public string ToJSON()
        {
            string createdAtFormatted = CreatedAt.ToString("yyyy-MM-ddTHH:mm:ss");
            string updatedAtFormatted = UpdatedAt.ToString("yyyy-MM-ddTHH:mm:ss");
            return "{" +
                $"\"id\": {Id}, " +
                $"\"name\": \"{Name}\", " +
                $"\"description\": \"{Description}\", " +
                $"\"buy_price\": {BuyPrice:F2}, " + 
                $"\"sell_price\": {SellPrice:F2}, " + 
                $"\"stock\": {Stock}, " +
                $"\"visible\": {Visible.ToString().ToLower()}, " + 
                $"\"supplier_id\": {SupplierId}, " +
                $"\"created_at\": \"{createdAtFormatted}\", " +
                $"\"updated_at\": \"{updatedAtFormatted}\", " +
                $"\"unit_type_id\": {UnitTypeId} " +
                "}";
        }

        public Product(string name, string description, double buyPrice, double sellPrice, int stock, bool visible, int supplierId, int unitTypeId)
        {
            Name = name;
            Description = description;
            BuyPrice = buyPrice;
            SellPrice = sellPrice;
            Stock = stock;
            Visible = visible;
            SupplierId = supplierId;
            UnitTypeId = unitTypeId;
        }

        public Product() { }
    }
}
