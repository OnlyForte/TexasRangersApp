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
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            InitializeComponent();
        }

        private async void foodButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodMenuDetailPage());
        }

        private async void drinksButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DrinksMenuDetailPage());
        }
    }
}