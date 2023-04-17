using System;

public class SimCoRestClient {
    private options = new RestClientOptions("https://www.simcompanies.com") {
        MaxTimeout = -1,
    };
    private client = new RestClient(options);
    
    public GetMarketData(string ItemID) {
        var request = new RestRequest($"/api/v3/market/0/{ItemID}/", Method.Get);
        RestResponse response = await client.ExecuteAsync(request);
        
    }
}