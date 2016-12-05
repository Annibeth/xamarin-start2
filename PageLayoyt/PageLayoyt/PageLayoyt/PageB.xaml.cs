using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PageLayoyt
{
    public partial class PageB : ContentPage
    {
        public PageB()
        {
            InitializeComponent();
        }
        private async void OnClicked(object sender, EventArgs e)
        { 
            await Navigation.PopAsync(); 
        }


}
}
