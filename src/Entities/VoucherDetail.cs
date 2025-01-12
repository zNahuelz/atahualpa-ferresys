using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atahualpa_ferresys.Entities
{
    public class VoucherDetail
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }
        public double Subtotal { get; set; }
        [JsonProperty("voucher_id")]
        public int VoucherId { get; set; }
        [JsonProperty("product_id")]
        public int ProductId {  get; set; }

    }
}
