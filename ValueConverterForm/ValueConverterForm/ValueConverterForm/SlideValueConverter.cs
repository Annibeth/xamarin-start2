using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ValueConverterForm
{
    class SlideValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var myValue = (double)value;
            return myValue * 100;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var myValue = (double)value;
            if (myValue != 0)
            {
                myValue = myValue / 100;
                
            }
            return myValue;
        }
    }
}
