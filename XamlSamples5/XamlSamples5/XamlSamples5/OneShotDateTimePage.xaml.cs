using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using Xamarin.Forms;

namespace XamlSamples5
{
    public partial class OneShotDateTimePage
    {
        public OneShotDateTimePage()
        {
            InitializeComponent();
        }
    }



    class ClockViewModel : INotifyPropertyChanged
    {
        DateTime mydateTime;

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
                if (mydateTime != value)
                {
                    mydateTime = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this,
                            new PropertyChangedEventArgs("MyDateTime"));
                    }
                }
            }
            get
            {
                return mydateTime;
            }
        }
    }

}

