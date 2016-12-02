using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ValueConverterForm
{
     public class SimpleViewModel : INotifyPropertyChanged 
    { 
         //fields 
         private double myValue;
         public event PropertyChangedEventHandler PropertyChanged;


        public double MyValue
        {
            get
            {
                return myValue;
            }

            set
            {
                if (myValue != value)
                {
                    myValue = value;
                    OnPropertyChanged();
                }
            }
        }

       private void OnPropertyChanged([CallerMemberName] string propertyName = "")
         { 
             var ev = PropertyChanged; 
             if (ev != null) 
             { 
                 ev(this, new PropertyChangedEventArgs(propertyName)); 
             } 
         } 

    }
}
