using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ValueConverterForm
{
    public partial class ValueConverterPage : ContentPage
    {
        private SimpleViewModel simpleViewModel;

        public ValueConverterPage(SimpleViewModel simpleViewModel)
        {

            this.simpleViewModel = simpleViewModel;
            InitializeComponent();
            BindingContext = simpleViewModel;
            //slider1.SetBinding<SimpleViewModel>(Slider.ValueProperty, vm => vm.MyValue, BindingMode.OneWayToSource);
            slider2.SetBinding<SimpleViewModel>(Slider.ValueProperty, vm => vm.MyValue, BindingMode.TwoWay);
        }
    }
    }
