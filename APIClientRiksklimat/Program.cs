using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace APIClientRiksklimat {
    class APIClientRiksklimat {
        private const string URL = "https://data.riksdagen.se/dokumentlista/?sok=Natur&utformat=json";
        private static readonly HttpClient client = new HttpClient();

        private static async Task MakeRequest(){
            try {
                string responseBody = await client.GetStringAsync(URL);
                Console.WriteLine(responseBody);
            }
            catch(HttpRequestException error) {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0}", error.Message);
            }

        }

        static async Task Main(string[] args) {
            await MakeRequest();
        }
    }
}