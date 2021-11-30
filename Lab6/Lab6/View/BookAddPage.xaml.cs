using Lab6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab6.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookAddPage : ContentPage
    {
		bool isNewItem;
		public BookAddPage(bool isNew = false)
        {
            InitializeComponent();
			isNewItem = isNew;
		}
		async void OnSaveButtonClicked(object sender, EventArgs e)
		{
			var todoItem = (Book)BindingContext;
			await App.bookManager.SaveTaskAsync(todoItem, isNewItem);
			await Navigation.PopAsync();
		}

		async void OnDeleteButtonClicked(object sender, EventArgs e)
		{
			var book = (Book)BindingContext;
			await App.bookManager.DeleteTaskAsync(book);
			await Navigation.PopAsync();
		}

		async void OnCancelButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}
}