using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class HardTricks : ContentPage
    {
        public HardTricks()
        {
            InitializeComponent();
            HardListView.ItemsSource = new List<string>
            {
                "Tailwhip",
                "720",
                "Flair"
            }; 
        }
    }
}
