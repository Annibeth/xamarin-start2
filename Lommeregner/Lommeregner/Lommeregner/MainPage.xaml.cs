using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lommeregner
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
                        
        }
        private void ButtonClickec(Object sender, EventArgs e)
        {
            var senderButton = sender as Button;
            topLabel.Text = senderButton.Text;
                
        }

    }
}
