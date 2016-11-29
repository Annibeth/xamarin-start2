using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimplestMVVM.ViewModels;
using Xamarin.Forms;

namespace SimplestMVVM.Pages
{
    public partial class SimplePage : ContentPage
    {
        private SimpleViewModel simpleViewModel;

        public SimplePage(SimpleViewModel simpleViewModel)
        {
            this.simpleViewModel = simpleViewModel;

            //The binding context refers to the object we are binding against.
            //This can also be set from XAML
            BindingContext = this.simpleViewModel;

            //Create XAML objects
            InitializeComponent();

            //Binding method #1: Set bindings using unsafe Text
            okButton.SetBinding(Button.IsEnabledProperty, "FornavnOk", BindingMode.OneWay);

            //Binding method #2 Set binding using lambda and typesafety
            fornavnEntry.SetBinding<SimpleViewModel>(Entry.TextProperty, vm => vm.Fornavn, BindingMode.OneWayToSource);

            //Binding method #3 - see the XAML file ;)
        }
    }
}
