using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

           
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            
        }

        private async void NewGameButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GamePage());
        }

        private async void TrickButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrickList());
        }
    }
}
