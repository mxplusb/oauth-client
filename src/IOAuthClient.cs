using System.Net.Http;
using System.Threading.Tasks;

namespace OAuth2
{
    /// <summary>
    /// Base interface for an OAuth2 Client for 2-legged authentication.
    /// </summary>
    public interface IOAuth2Client : IHttpClientFactory
    {
        /// <summary>
        /// Create a new client.
        /// </summary>
        /// <param name="name">The desired name of the client. This will also be used as the User-Agent header.</param>
        /// <param name="serverConfig">OAuth2 configurations.</param>
        /// <returns>HttpClient</returns>
        HttpClient CreateClient(string name, OAuth2Endpoint oAuth2Endpoint);
        /// <summary>
        /// Request a new Refresh Token.
        /// </summary>
        Task Refresh();
        /// <summary>
        /// Get the current config of the instantiated HttpClient.
        /// </summary>
        /// <returns></returns>
        OAuth2Endpoint GetConfig();
    }
}
