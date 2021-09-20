using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            ButtonCode.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ListViewCode());
            };
            ButtonDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ListViewDemo());
            };
            ButtonSource.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ListViewSource());
            };



        }
    }

}