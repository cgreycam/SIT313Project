using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class MediumTricks : ContentPage
    {
        public MediumTricks()
        {
            InitializeComponent();
            MediumListView.ItemsSource = new List<string>
            {
                "360",
                "Turndown",
                "Barspin"
            };
        }
    }
}
