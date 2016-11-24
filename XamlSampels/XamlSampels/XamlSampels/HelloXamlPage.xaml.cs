using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamlSampels
{
    public partial class HelloXamlPage : ContentPage
    {
        public HelloXamlPage()
        {
            InitializeComponent();
            
            
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            //valueLabel.Text = args.NewValue.ToString("F3");
            valueLabel.Text = ((Slider)sender).Value.ToString("F3");

        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            await DisplayAlert("Clicked!",
                "The button labeled '" + button.Text + "' has been clicked",
                "OK");
        }

    }
}