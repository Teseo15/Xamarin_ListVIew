using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Lab6.Interfaces;
using Lab6.Model;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Lab6.Data
{
    public class RestService : IRestService
    {
        HttpClient client;

        public List<Book> Books { get; set; }
        public RestService()
        {
            #if DEBUG
            client = new HttpClient(DependencyService.Get<IHttpClientHandlerService>().GetInsecureHandler());
            #else
            client = new HttpClient();
            #endif
        }
        public async Task DeleteBookAsync(string id)
        {
            var uri = new Uri(string.Format(Constants.RestUrl, id));

            try
            {
                var response = await client.DeleteAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"\tBook successfully deleted.");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
        }

        public async Task<List<Book>> RefresDataAsync()
        {
            Books = new List<Book>();
            string action = "GET";
            var uri = new Uri(string.Format(Constants.RestUrl, action));
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Books= JsonConvert.DeserializeObject<List<Book>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Books;
        }

        public async Task SaveBookItemAsync(Book item, bool isNewItem)
        {
            try
            {
                //Response es un objeto.
                //Serializar
                var json = JsonConvert.SerializeObject(item);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                if (isNewItem)
                {
                    var uri = new Uri(string.Format(Constants.RestUrl, "Create"));
                    response = await client.PostAsync(uri, content);
                }
                else
                {
                    var uri = new Uri(string.Format(Constants.RestUrl, "Edit"));
                    response = await client.PutAsync(uri, content);
                }

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"\Book successfully saved.");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
        }

    }
}
