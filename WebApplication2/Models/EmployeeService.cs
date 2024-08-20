using Newtonsoft.Json;

namespace WebApplication2.Models
{
    public class EmployeeService
    {
        private static readonly string apiKey = "vO17RnE8vuzXzPJo5eaLLjXjmRW07law99QTD90zat9FfOQJKKUcgQ==";
        private static readonly string apiUrl = $"https://rc-vault-fap-live-1.azurewebsites.net/api/gettimeentries?code={apiKey}";

        public static async Task<List<Employee>> GetEmployeeData()
        {
            using (HttpClient client = new HttpClient())
            {
                string response = await client.GetStringAsync(apiUrl);
                return JsonConvert.DeserializeObject<List<Employee>>(response);
            }
        }
    }
}
