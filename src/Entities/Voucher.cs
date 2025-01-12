using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atahualpa_ferresys.Entities
{
    public class Voucher
    {
        public int Id { get; set; }
        public double Subtotal { get; set; }
        public double Total { get; set; }
        public double Igv { get; set; }
        public bool Paid { get; set; }
        [JsonProperty("voucher_type")]
        public int VoucherType { get; set; }
        [JsonProperty("customer_id")]
        public int CustomerId { get; set; }
    }
}
