using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Microsoft.WindowsAzure.MobileServices
{
    public interface IAuthenticatedClientOptions
    {
        string MobileAppUri { get; }

        string AlternateAuthenticationUri { get; }

        string LoginUriPrefix { get; }

        IEnumerable<HttpMessageHandler> GetDefaultMessageHandlers(IMobileServiceClient client);
    }
}