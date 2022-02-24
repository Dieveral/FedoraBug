using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace FedoraBug
{
    public class StringToGridLengthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is string stringValue && int.TryParse(stringValue, out int intValue))
            {
                return new GridLength(intValue);
            }
            else
            {
                return new GridLength(0);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
