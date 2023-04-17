using System;
using RestSharp;
using Newtonsoft.Json;
using Simcompanies_Price_Calculator.Entities;

public class SimCoRestClient {
    private static RestClientOptions options = new RestClientOptions("https://www.simcompanies.com") {
        MaxTimeout = -1,
    };
    private RestClient client = new RestClient(options);
    
    public async Task<List<MarketItem>> GetMarketData(string ItemID) {
        var request = new RestRequest($"/api/v3/market/0/{ItemID}/", Method.Get);
        RestResponse response = await client.ExecuteAsync(request);
        if (response?.Content == null) return new List<MarketItem>();
        return JsonConvert.DeserializeObject<List<MarketItem>>(response.Content) ?? new List<MarketItem>();
    }
}