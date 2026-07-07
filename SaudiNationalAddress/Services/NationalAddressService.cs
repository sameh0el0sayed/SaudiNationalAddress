namespace SaudiNationalAddress.Services
{
    public class NationalAddressService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public NationalAddressService(HttpClient httpClient,
                                      IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<string> SearchAddress(string address)
        {
            var apiKey = _configuration["NationalAddress:ApiKey"];
            var baseUrl = _configuration["NationalAddress:BaseUrl"];

            var request = $"{baseUrl}Address?address={Uri.EscapeDataString(address)}";

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, request);

            httpRequest.Headers.Add("apikey", apiKey);

            var response = await _httpClient.SendAsync(httpRequest);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}
