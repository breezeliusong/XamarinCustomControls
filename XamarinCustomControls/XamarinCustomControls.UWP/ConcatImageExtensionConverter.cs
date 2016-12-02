using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace XamarinCustomControls.UWP
{
    public class ConcatImageExtensionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var fileName = value as string;
            if (fileName == null) return null;

            string ss = string.Concat(fileName, ".png");
            return string.Concat(fileName, ".png");
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
