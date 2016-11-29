using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimplestMVVM.ViewModels
{
    public class SimpleViewModel : INotifyPropertyChanged
    {
        //fields
        private string fornavn;
        private bool fornavnOk = false;
        private string status = "Indtast Navn";

        //We need to implement this event in order to fullfill INotifyPropertyChanged event
        //property
        public event PropertyChangedEventHandler PropertyChanged;


        public string Fornavn
        {
            get
            {
                return fornavn;
            }

            set
            {
                //Check that the new value is not equal to the current
                if (Fornavn != value)
                {
                    fornavn = value;
                    OnPropertyChanged("Fornavn"); //propertyname provided manually

                    if (String.IsNullOrEmpty(Fornavn) || String.IsNullOrWhiteSpace(Fornavn))
                    {
                        FornavnOk = false;
                        Status = "Indtast Navn";
                    }
                    else
                    {
                        FornavnOk = true;
                        Status = "Hurra for et flot navn";
                    }
                }
            }
        }

        public bool FornavnOk
        {
            get
            {
                return fornavnOk;
            }

            set
            {
                if (fornavnOk != value)
                {
                    fornavnOk = value;
                    OnPropertyChanged(); //compiler provides the property name;
                }
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                if(Status != value)
                {
                    status = value;
                    OnPropertyChanged();
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

    }
}
