using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PageLayoyt
{
    public partial class App : Application
    {
        private TabbedPage tabbedPage = new TabbedPage(); // TabbedPage Object (trylleri) fra xamerin forms

        private NavigationPage navigationPage1 = new NavigationPage(); // 
        private NavigationPage navigationPageA = new NavigationPage();

        public App()
        {
            InitializeComponent();

            // MainPage = new PageLayoyt.MainPage();
            MainPage = tabbedPage;
            navigationPage1.Title = "min titel på tab number";
            navigationPageA.Title = "min titel på tab bogstav";

            tabbedPage.Children.Add(navigationPageA);
            tabbedPage.Children.Add(navigationPage1);

            //constructors cannot be async, hence we do first push pages to the
            //navigationstack in the OnStart method that can be modified to be async
        }


        protected override async void OnStart()
        {
            // Handle when your app starts
            var page1 = new Page1();
            var pageA = new PageA();

            await navigationPage1.PushAsync(page1);
            await navigationPageA.PushAsync(pageA);

            tabbedPage.Children.Add(navigationPageA);
            tabbedPage.Children.Add(navigationPage1);

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
