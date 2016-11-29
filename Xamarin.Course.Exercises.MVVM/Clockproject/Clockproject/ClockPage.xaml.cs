using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clockproject.XamlSamples;
using Xamarin.Forms;

namespace Clockproject
{
    public partial class ClockPage : ContentPage
    {
        public ClockPage()
        {
            ClockViewModel cm = new ClockViewModel();
            BindingContext = cm;
            InitializeComponent();
        }
    }
}
