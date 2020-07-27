using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CroquisApp
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Setting_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListSettingPage(), true);
        }

        private async void CroquiStart_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CroquiStart(), true);
        }
    }
}
