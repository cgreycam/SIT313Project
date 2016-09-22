using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class EasyTricks : ContentPage
    {
        public EasyTricks()
        {
            InitializeComponent();

            EasyListView.ItemsSource = new List<string>
            {
                "180",
                "Manual",
                "Fakie",
            };
        }
    }
}
