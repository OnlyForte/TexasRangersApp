using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TexasRangersApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrinksMenuDetailPage : ContentPage
    {
        public DrinksMenuDetailPage()
        {
            InitializeComponent();
        }

        private async void backButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}