using System.Collections.Generic;
using System.Net.Http;

namespace oauth
{
    public interface IOAuthClient : IHttpClientFactory
    {
        HttpClient CreateClient(string name, OauthEndpoint serverConfig);
        void Refresh();

    }

    public struct OauthEndpoint
    {
        public string ClientId;
        public string ClientSecret;
        public string TokenUrl;
        public List<string> Scopes;
        public Dictionary<string, string> EndpointParameters;
    }
}
