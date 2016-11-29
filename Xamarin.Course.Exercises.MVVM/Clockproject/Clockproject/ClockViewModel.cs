using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clockproject
{
    using System;
    using System.ComponentModel;
    using Xamarin.Forms;

    namespace XamlSamples
    {
        class ClockViewModel : INotifyPropertyChanged
        {
            DateTime myDateTime;

            public event PropertyChangedEventHandler PropertyChanged;

            public ClockViewModel()
            {
                this.MyDateTime = DateTime.Now;

                Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    this.MyDateTime = DateTime.Now;
                    return true;
                });
            }

            public DateTime MyDateTime
            {
                set
                {
                    if (myDateTime != value)
                    {
                        myDateTime = value;

                        if (PropertyChanged != null)
                        {
                            PropertyChanged(this,
                                new PropertyChangedEventArgs("MyDateTime"));
                        }
                    }
                }
                get
                {
                    return myDateTime;
                }
            }
        }
    }
}
