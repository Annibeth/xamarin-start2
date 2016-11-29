using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

 

namespace SimplestMVVM.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged //interface implementeret
    {
        private string versionTekst ="1.2.4";
        private string loginEntery ;
        private bool loginButton;
        private string statusLabel = "Status Indtast mobilnummer";

        public event PropertyChangedEventHandler PropertyChanged;


        public string LoginEntery
        {
            get
            {
                return loginEntery;
            }

            set      
            {

                //Check that the new value is not equal to the current
                if (loginEntery != value)
                {
                    loginEntery = value;
                    OnPropertyChanged(); //propertyname provided manually


                    if (!String.IsNullOrEmpty(value) || !String.IsNullOrWhiteSpace(value))
                    {
                        //test loginEntery længde
                        if (LoginEntery.Length != null &&LoginEntery.Length == 8)
                        {

                            LoginButton = true;
                            StatusLabel = "Klar til at logge ind med: " +  value;
                            
                        }
                        else
                        {
                            LoginButton = false;
                            StatusLabel = "Indtast telefonnummer";
                        }
                    }

                }
            }
        }
        //Simple function that we call whenever we want to tell bindings that
        //some property has changed.
        //Note: CallerMemberName is just compiler-sugar that puts in the name of
        //the calling property if no value is provided.        
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var ev = PropertyChanged;
            if (ev != null)
            {
                ev(this, new PropertyChangedEventArgs(propertyName));
            }
        }




        public bool LoginButton
        {
            get
            {
                return loginButton;
            }

            set
            {
               
                loginButton = value;
                OnPropertyChanged(); //propertyname provided manually

            }
        }

        public string StatusLabel
        {
            get
            {
                return statusLabel;
            }

            set
            {
                statusLabel = value;
                OnPropertyChanged(); //propertyname provided manually

            }
        }

        public string VersionTekst
        {
            get
            {
                return versionTekst;
            }

            set
            {
                versionTekst = value;
                OnPropertyChanged(); //propertyname provided manually
            }
        }
    }
}
