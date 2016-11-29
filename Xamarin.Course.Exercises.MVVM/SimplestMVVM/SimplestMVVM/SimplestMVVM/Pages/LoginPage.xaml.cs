using SimplestMVVM.ViewModels;
using Xamarin.Forms;


namespace SimplestMVVM.Pages
{
    public partial class LoginPage : ContentPage
    {
        private LoginViewModel _loginViewModel; //erklæring af variabel så den kan ses i metoden!? er privat fordi den kun bruges her

      
        public LoginPage(LoginViewModel loginViewModel) // med L stortbogstav og l lillebogstav
        {
            this._loginViewModel = loginViewModel;
            
            //The binding context refers to the object we are binding against.
            //This can also be set from XAML
            BindingContext = this._loginViewModel;

            //Create XAML objects
            InitializeComponent();
            
            //Binding method #2 Set binding using lambda and typesafety, ingen binding i xaml filen

            //loginEntery.SetBinding<LoginViewModel>(Entry.TextProperty, vm => vm.LoginEntery , BindingMode.OneWayToSource);
            loginButton.SetBinding<LoginViewModel>(Button.IsEnabledProperty, vm => vm.LoginButton, BindingMode.OneWay);
            //statusLabel.SetBinding<LoginViewModel>(Label.IsEnabledProperty, vm => vm.StatusLabel, BindingMode.OneWay);


            loginButton.Clicked += (s,e) => {loginEntery.Text = ""; };

       } 

    }
}
