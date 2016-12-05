using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PageLayoyt
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }
       
        private async void OnClicked(object sender, EventArgs e)
        {
             await Navigation.PopAsync();
        }
        //private async void PushTabbed(object sender, EventArgs e)
        //{
        //    var tabbedPage = new TabbedPage();
        //    var pageA = new PageA();
        //    var pageB = new PageB();

        //    tabbedPage.Children.Add(pageA);
        //    tabbedPage.Children.Add(pageA);

        //    await Navigation.PopAsync(tabbedPage);
        //}
    }
}
