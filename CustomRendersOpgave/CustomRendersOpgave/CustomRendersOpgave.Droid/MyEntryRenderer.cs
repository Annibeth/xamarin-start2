using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using CustomRendersOpgave;

using CustomRendersOpgave.Droid; //skal importeres fordi assembly ikke kan se den endnu ....

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))] //binder xamarinforms og xamarinandroid sammen


namespace CustomRendersOpgave.Droid
{
    class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
            }
        }
    }
}