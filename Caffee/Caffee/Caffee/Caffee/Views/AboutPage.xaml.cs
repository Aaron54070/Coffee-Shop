using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Caffee.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void Button_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewItemPage());
        }

        private async void Button_clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        private async void Button_clicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new hotdrinks());
        }

        private async void Button_clicked3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ColdDrinks());
        }


    }
}