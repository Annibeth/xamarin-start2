using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ImageOpgave
{


    public partial class ImagePage : ContentPage
    {
       //kan der være globale var og dependensieINject variabler, dem vi sætter selv
        public ImagePage()
        {
            InitializeComponent();
            var embeddedImage = new Image { Aspect = Aspect.AspectFit };
            // embeddedImage.Source = ImageSource.FromResource("ImageOpgave.myImages.sprogetogdansen.jpg");
            // Content = embeddedImage;

            //var webImage = new Image { Aspect = Aspect.AspectFit };
            //webImage.Source = ImageSource.FromUri(new Uri("http://www.go2faroes.com/wp-content/uploads/2012/11/sproget-og-dansen.jpg"));
            //Content = webImage;

           var tapGestureRecongnizer = new TapGestureRecognizer();
            tapGestureRecongnizer.Tapped += OnMyAwsomeImageWasTapped;
            myImage.GestureRecognizers.Add(tapGestureRecongnizer);
            Content = myImage;
        }

        private void OnMyAwsomeImageWasTapped(object sender, EventArgs e)
        {
            myImage.Source = ImageSource.FromFile("flyver.jpg");
        }
    }
}
