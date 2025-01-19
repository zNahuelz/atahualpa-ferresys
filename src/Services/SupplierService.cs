using atahualpa_ferresys.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

        public async Task<Supplier> GetSupplierById(int id)
        {
            var response = await _httpClient.GetAsync($"supplier/{id}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Supplier>(json);
        }

        public async Task<Supplier> GetSupplierByRuc(string ruc)
        {
            var response = await _httpClient.GetAsync($"supplier/by_ruc/{ruc}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Supplier>(json);
        }
        public async Task<List<Supplier>> GetSuppliersByName(string name)
        {
            var response = await _httpClient.GetAsync($"supplier/by_name/{name}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Supplier>>(json);
        }

        public async Task<Supplier> GetSupplierByEmail(string email)
        {
            var response = await _httpClient.GetAsync($"supplier/by_email/{email}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Supplier>(json);
        }

        public async Task<HttpResponseMessage> CreateSupplier(Supplier supplier)
        {
            string jsonProduct = supplier.ToJSON();
            var body = new StringContent(jsonProduct, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("supplier", body);
            return response;
        }

        public async Task<HttpResponseMessage> UpdateSupplier(Supplier supplier, int id)
        {
            string jsonProduct = supplier.ToJSON();
            var body = new StringContent(jsonProduct, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"supplier/{id}", body);
            return response;
        }

        public async Task<HttpResponseMessage> DeleteSupplier(int id)
        {
            var response = await _httpClient.DeleteAsync($"supplier/{id}");
            response.EnsureSuccessStatusCode();
            return response;
        }

    }
}
