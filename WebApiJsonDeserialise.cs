using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace Call_Web_API_1
{
    class WebApiJsonDeserialise
    {
        // Add nuget package Newtonsoft.json
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            Console.WriteLine("Calling WEBAPI ....");
                       
            var responseTask = client.GetAsync("https://api.chucknorris.io/jokes/random");   // Random Chuck Norris joke

            responseTask.Wait();

            if (responseTask.IsCompleted)
            {
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var jsonData = result.Content.ReadAsStringAsync();
                    jsonData.Wait();
                    var strJsonData = jsonData.Result.ToString();

                    // Now we need to deserialise this JSON string
                    var jsonChuckNorris = JsonConvert.DeserializeObject<jsonJoke>(strJsonData);    // dynamic means it is resolved at runtime. Will use own class soon

                    Console.WriteLine("This is our JSON object : " + jsonChuckNorris.ToString());

                    Console.WriteLine("");
                    Console.WriteLine("icon_url : " + jsonChuckNorris.icon_url);
                    Console.WriteLine("url : " + jsonChuckNorris.url);
                    Console.WriteLine("value : " + jsonChuckNorris.value);
                    Console.WriteLine("updated at : " + jsonChuckNorris.updated_at);
                }
            }            
            
            // Thanks to: https://www.youtube.com/watch?v=CjoAYslTKX0&ab_channel=LesJackson
           
        }       
    }
}
