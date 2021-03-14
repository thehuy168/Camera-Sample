using Camera.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Camera.Views
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