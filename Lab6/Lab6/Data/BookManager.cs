using Lab6.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Data
{
    public class BookManager
    {
		IRestService restService;

		public BookManager(IRestService service)
		{
			restService = service;
		}

		public Task<List<Book>> GetTasksAsync()
		{
			return restService.RefresDataAsync();
		}

		public Task SaveTaskAsync(Book item, bool isNewItem = false)
		{
			return restService.SaveBookItemAsync(item, isNewItem);
		}

		public Task DeleteTaskAsync(Book item)
		{
			return restService.DeleteBookAsync(item._id);
		}
	}
}
