using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Lab6.Interfaces
{
    public interface IHttpClientHandlerService
    {
        HttpClientHandler GetInsecureHandler();
    }
}
