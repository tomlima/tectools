using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Tectools.Infrastructure.Services;


public abstract class ApiFetcher
{
    public static async Task<JObject> FetchAsync(string apiUrl)
    {
        using (HttpClient httpClient = new HttpClient())
        {
            httpClient.DefaultRequestHeaders.Add("User-Agent", "YourAppName/1.0 (your-email@example.com)");

            try
            {
                var response = await httpClient.GetStringAsync(apiUrl);
                JObject jsonObject = JObject.Parse(response);
                return jsonObject;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
       
    }
}