using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Diagnostics;

namespace WAZE_DATA_FEED.Services
{
    public class WazeDataFeed
    {
        HttpClient client = new HttpClient(); 
        Results results = new Results();
        public async Task getWazeFeed()
        {
            string wazeUrl = "https://www.waze.com/partnerhub-api/waze-feed-access-token/e4d80438-9dc1-4588-8e3a-93cddf1bb913?format=1";
            string jsonResponse = await client.GetStringAsync(wazeUrl);
            Debug.WriteLine(jsonResponse);

            results = JsonSerializer.Deserialize<Results>(jsonResponse);

            
        }

        public void getCities()
        {
            for(int i = 0; i < results?.alerts?.Count; ++i)
            {
                Debug.WriteLine(results.alerts[i].city);
            }
        }

    }
}
