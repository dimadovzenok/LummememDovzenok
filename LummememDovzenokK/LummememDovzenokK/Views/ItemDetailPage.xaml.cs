using System.ComponentModel;
using Xamarin.Forms;
using LummememDovzenokK.ViewModels;

namespace LummememDovzenokK.Views
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