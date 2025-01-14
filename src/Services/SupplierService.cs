using atahualpa_ferresys.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace atahualpa_ferresys.Services
{
    public class SupplierService
    {
        private readonly HttpClient _httpClient;

        public SupplierService(string baseURL, string token)
        {
            _httpClient = new HttpClient();
            {
                _httpClient.BaseAddress = new Uri(baseURL);
            };
            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<List<Supplier>> GetSuppliers()
        {
            var response = await _httpClient.GetAsync("supplier");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Supplier>>(json);
        }
    }
}
