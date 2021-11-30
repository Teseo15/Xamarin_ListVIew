using Lab6.Data;
using Lab6.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab6
{
    public partial class App : Application
    {
        public static BookManager bookManager { get; private set; }

        public App()
        {
            InitializeComponent();
            bookManager = new BookManager(new RestService());

            MainPage = new NavigationPage(new View.ListViewGroup());
            //MainPage = new NavigationPage(new BookListPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
