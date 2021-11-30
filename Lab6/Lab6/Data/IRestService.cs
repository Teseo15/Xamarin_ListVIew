using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Lab6.Model;

namespace Lab6.Data
{
    public interface IRestService
    {
        Task<List<Book>> RefresDataAsync();
        Task SaveBookItemAsync(Book item, bool isNewItem);
        Task DeleteBookAsync(string id);

    }
}
