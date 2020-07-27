using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CroquisApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListSettingPage : ContentPage
    {
        public ListSettingPage()
        {
            InitializeComponent();
        }

        private async void Create_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListCreatePage(), true);
        }

        private async void Edit_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new CroquiStart(), true);
            await DisplayAlert("test", "メッセージ", "OK");
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new CroquiStart(), true);
            await DisplayAlert("test", "メッセージ", "OK");
        }
    }
}