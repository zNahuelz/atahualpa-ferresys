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
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(string baseURL, string token)
        {
            _httpClient = new HttpClient();
            {
                _httpClient.BaseAddress = new Uri(baseURL);
            };
            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<List<Product>> GetProducts()
        {
            var response = await _httpClient.GetAsync("product");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Product>>(json);
        }

        public async Task<List<Product>> GetProductsByName(string name)
        {
            var response = await _httpClient.GetAsync($"product/by_name/{name}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Product>>(json);
        }

        public async Task<List<Product>> GetProductsByDescription(string description)
        {
            var response = await _httpClient.GetAsync($"product/by_desc/{description}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Product>>(json);
        }

        public async Task<Product> GetProductById(int id)
        {
            var response = await _httpClient.GetAsync($"product/{id}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Product>(json);
        }

    }
}
