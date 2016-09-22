using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class TrickList : TabbedPage
    {
        public TrickList()
        {

            InitializeComponent();
            Children.Add(new EasyTricks());
            Children.Add(new MediumTricks());
            Children.Add(new HardTricks());

            
           }
    }
}
