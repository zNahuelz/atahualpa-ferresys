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
    public class CustomerService
    {
        private readonly HttpClient _httpClient;

        public CustomerService(string baseURL, string token)
        {
            _httpClient = new HttpClient();
            {
                _httpClient.BaseAddress = new Uri(baseURL);
            };
            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<List<Customer>> GetCustomers()
        {
            var response = await _httpClient.GetAsync("customer");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Customer>>(json);
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            var response = await _httpClient.GetAsync($"customer/{id}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Customer>(json);
        }

        public async Task<Customer> GetCustomerByDni(string dni)
        {
            var response = await _httpClient.GetAsync($"customer/by_dni/{dni}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Customer>(json);
        }

        public async Task<HttpResponseMessage> CreateCustomer(Customer customer)
        {
            string jsonCustomer = customer.ToJSON();
            var body = new StringContent(jsonCustomer, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("customer", body);
            return response;
        }

        public async Task<HttpResponseMessage> UpdateCustomer(Customer customer, int id)
        {
            string jsonCustomer = customer.ToJSON();
            var body = new StringContent(jsonCustomer, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"customer/{id}", body);
            return response;
        }

        public async Task<HttpResponseMessage> DeleteCustomer(int id)
        {
            var response = await _httpClient.DeleteAsync($"customer/{id}");
            response.EnsureSuccessStatusCode();
            return response;
        }
    }
}
