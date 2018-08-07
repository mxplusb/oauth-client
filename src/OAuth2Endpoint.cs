using System.Collections.Generic;

namespace OAuth2
{
    /// <summary>
    /// Target configurations for the client.
    /// </summary>
    public struct OAuth2Endpoint
    {
        /// <summary>
        /// Your Client ID. Sometimes known as an AppID or Application ID.
        /// </summary>
        public string ClientId;
        /// <summary>
        /// Your Client Secret. Sometimes known as an App Password.
        /// </summary>
        public string ClientSecret;
        /// <summary>
        /// The full URL path where the HttpClient can request a Token for authentication.
        /// </summary>
        public string TokenUrl;
        /// <summary>
        /// The full URL path where the HttpClient can request a new Refresh Token.
        /// </summary>
        public string RefreshUrl;
        /// <summary>
        /// Any scopes required for authorization of any resources needed. Check with your OAuth2 provider for details on scopes required.
        /// </summary>
        public List<string> Scopes;
        /// <summary>
        /// Any extra parameters necessary that need to be shipped with requests.
        /// </summary>
        public Dictionary<string, string> EndpointParameters;
    }
}