using System;
using System.Net.Http;
using Lab6.Droid;
using Lab6.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(HttpClientHandlerService))]
namespace Lab6.Droid
{

    public class HttpClientHandlerService : IHttpClientHandlerService
    {


        public HttpClientHandler GetInsecureHandler()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback =
                (message, cert, chain, errors) =>
                {
                    if (cert.Issuer.Equals("CN=localhost"))
                        return true;
                    return errors == System.Net.Security.SslPolicyErrors.None;
                };
            return handler;
        }
    }
}