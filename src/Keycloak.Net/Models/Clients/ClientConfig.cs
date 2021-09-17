using Newtonsoft.Json;

namespace Keycloak.Net.Models.Clients
{
    public class ClientConfig
    {
        [JsonProperty("userinfotokenclaim")]
        public string UserInfoTokenClaim { get; set; }
        [JsonProperty("userattribute")]
        public string UserAttribute { get; set; }
        [JsonProperty("id.token.claim")]
        public string IdTokenClaim { get; set; }
        [JsonProperty("access.token.claim")]
        public string AccessTokenClaim { get; set; }
        [JsonProperty("claim.name")]
        public string ClaimName { get; set; }
        [JsonProperty("jsonType.label")]
        public string JsonTypelabel { get; set; }
        [JsonProperty("user.session.note")]
        public string UserSessionNote { get; set; }
    }
}