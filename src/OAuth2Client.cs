using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OAuth2
{
    class OAuth2Client : IOAuth2Client
    {
        public OAuth2Endpoint _oAuth2Endpoint;
        public HttpClient CreateClient(string name, OAuth2Endpoint oAuth2Endpoint)
        {
            _oAuth2Endpoint = oAuth2Endpoint;
            throw new NotImplementedException();
        }

        public HttpClient CreateClient(string name)
        {
            throw new NotImplementedException();
        }

        public OAuth2Endpoint GetConfig()
        {
            return _oAuth2Endpoint;
        }

        public Task Refresh()
        {
            throw new NotImplementedException();
        }
    }
}
