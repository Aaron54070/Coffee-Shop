using Caffee.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Caffee.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}