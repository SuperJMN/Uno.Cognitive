using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace Uno.Cognitive
{
    public class IconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return new SymbolIcon(Symbol.Accept);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}