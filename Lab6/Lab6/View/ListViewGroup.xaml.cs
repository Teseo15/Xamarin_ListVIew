using Lab6.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab6.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        public ListViewGroup()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.bookManager.GetTasksAsync();
        }

        async void OnAddItemClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BookAddPage(true)
            {
                BindingContext = new Book
                {
                    _id = Guid.NewGuid().ToString()
                }
            });
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new BookAddPage
            {
                BindingContext = e.SelectedItem as Book
            });
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            string id= mi.CommandParameter.ToString();
            //var book = (Book)BindingContext;
            await App.bookManager.DeleteTaskAsync(id);
            DisplayAlert("Eliminado", "el elemento ha sido eliminado", "OK");
            await Navigation.PopAsync();
        }


    }


}



