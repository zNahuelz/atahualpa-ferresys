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
    public class UnitTypeService
    {
        private readonly HttpClient _httpClient;

        public UnitTypeService(string baseURL, string token)
        {
            _httpClient = new HttpClient();
            {
                _httpClient.BaseAddress = new Uri(baseURL);
            };
            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<List<UnitType>> GetUnitTypes()
        {
            var response = await _httpClient.GetAsync("unit_type");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<UnitType>>(json);
        }

        public async Task<List<UnitType>> GetUnitTypesByName(string name)
        {
            var response = await _httpClient.GetAsync($"unit_type/by_name/{name}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<UnitType>>(json);
        }

        public async Task<UnitType> GetUnitTypeById(int id)
        {
            var response = await _httpClient.GetAsync($"unit_type/{id}");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<UnitType>(json);
        }

        public async Task<HttpResponseMessage> CreateUnitType(UnitType unitType)
        {
            string jsonUnitType = unitType.ToJSON();
            var body = new StringContent(jsonUnitType, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("unit_type", body);
            return response;
        }

        public async Task<HttpResponseMessage> UpdateUnitType(UnitType unitType, int id)
        {
            string jsonUnitType = unitType.ToJSON();
            var body = new StringContent(jsonUnitType, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"unit_type/{id}", body);
            return response;
        }

    }
}
