using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App2.Shared
{
    public static class Workarounds
    {
        public static readonly DependencyProperty UpdateSourceOnLostFocusProperty = DependencyProperty.RegisterAttached(
            "LostFocusOnBlur",
            typeof(bool),
            typeof(Workarounds),
            new PropertyMetadata(default(bool), LUpdateSourceOnLostFocusChanged));

        static void LUpdateSourceOnLostFocusChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is TextBox textBox && (bool)e.NewValue)
            {
                textBox.LostFocus += TextBoxOnLostFocus;
            }
        }

        static void TextBoxOnLostFocus(object sender, RoutedEventArgs e)
        {
            var binding = (sender as TextBox).GetBindingExpression(TextBox.TextProperty);
            binding?.UpdateSource();
        }


        public static void SetUpdateSourceOnLostFocus(DependencyObject element, bool value)
        {
            element.SetValue(UpdateSourceOnLostFocusProperty, value);
        }

        public static bool GetUpdateSourceOnLostFocus(DependencyObject element)
        {
            return (bool)element.GetValue(UpdateSourceOnLostFocusProperty);
        }
    }
}