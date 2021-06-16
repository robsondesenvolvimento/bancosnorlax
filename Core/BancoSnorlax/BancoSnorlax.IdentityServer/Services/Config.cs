using IdentityServer4.Models;
using System.Collections.Generic;

namespace BancoSnorlax.IdentityServer.Services
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId()
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("BancoSnorlaxApi", "SnorlaxApi")
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientId = "snorlax",

                    // no interactive user, use the clientid/secret for authentication
                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    // secret for authentication
                    ClientSecrets =
                    {
                        new Secret("snorlax".Sha256())
                    },

                    // scopes that client has access to
                    AllowedScopes = { "BancoSnorlaxApi" }
                }
            };
    }
}
