using SimplestMVVM.ViewModels;
using Xamarin.Forms;


namespace SimplestMVVM.Pages
{
    public partial class LoginPage : ContentPage
    {
        private LoginViewModel _loginViewModel;

      
        public LoginPage(LoginViewModel loginViewModel)
        {
            this._loginViewModel = loginViewModel;
            
            //The binding context refers to the object we are binding against.
            //This can also be set from XAML
            BindingContext = this._loginViewModel;

            //Create XAML objects
            InitializeComponent();
            
            //Binding method #2 Set binding using lambda and typesafety

            loginEntery.SetBinding<LoginViewModel>(Entry.TextProperty, vm => vm.LoginEntery , BindingMode.OneWayToSource);
            loginButton.SetBinding<LoginViewModel>(Button.IsEnabledProperty, vm => vm.LoginButton, BindingMode.OneWay);
            //statusLabel.SetBinding<LoginViewModel>(Label.IsEnabledProperty, vm => vm.StatusLabel, BindingMode.OneWay);


       } 

    }
}
