using JPSHolidayTrackerSystem.Shared.Entitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace JPSHolidayTrackerSystem.Web.Services
{
    public class DepartmentDataService : IDepartmentDataService
    {
        private readonly HttpClient _httpClient;

        public DepartmentDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Department>> GetAllDepartments()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Department>>
                (await _httpClient.GetStreamAsync($"api/department"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Department> GetDepartmentById(int id)
        {
            return await JsonSerializer.DeserializeAsync<Department>
                (await _httpClient.GetStreamAsync($"api/department/{id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
