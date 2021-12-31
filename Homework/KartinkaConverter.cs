using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Homework
{
    class KartinkaConverter:IValueConverter
    {
       
        public object Convert (object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (((string)value) == "food")
            {
                return "Images/f.jpg";
            }
            return "Images/a.jpg";
        }

        public object ConvertBack (object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue; ;
        }
    }
}
