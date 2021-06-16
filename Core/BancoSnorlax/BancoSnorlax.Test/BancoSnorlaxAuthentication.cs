using FluentAssertions;
using IdentityModel.Client;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace BancoSnorlax.Test
{
    public class BancoSnorlaxAuthentication
    {
        [Fact]
        public async Task BancoSnorlaxAuthenticationAuthAsync()
        {
            var client = new HttpClient();
            var disco = await client.GetDiscoveryDocumentAsync("https://localhost:44342");
            disco.IsError.Should().Be(false);

            var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = disco.TokenEndpoint,

                ClientId = "snorlax",
                ClientSecret = "snorlax",
                Scope = "BancoSnorlaxApi"
            });

            tokenResponse.IsError.Should().Be(false);

            var apiClient = new HttpClient();
            apiClient.SetBearerToken(tokenResponse.AccessToken);

            var response = await apiClient.GetAsync("https://localhost:44305/identity");
            response.IsSuccessStatusCode.Should().Be(true);


        }
    }
}
