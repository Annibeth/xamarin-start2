using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CustomRendersOpgave
{
    public class App : Application
    {
        public StackLayout Content { get; private set; }

        public App()
        {
            // The root page of your application
            MainPage = new CustomRendersOpgave.CoustomRendererPage();

            //    new ContentPage
            //{
            //    Content = new StackLayout
            //    {
            //        Children =  {
            //                     new Label { Text = "Hello, Custom Renderer !", },
            //                    new MyEntry {Text = "In Shared Code", }
            //                    },

            //        VerticalOptions = LayoutOptions.CenterAndExpand,
            //        HorizontalOptions = LayoutOptions.CenterAndExpand,
            //    }
            //};











    }

        protected override void OnStart()
        {
            // Handle when your app starts
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
