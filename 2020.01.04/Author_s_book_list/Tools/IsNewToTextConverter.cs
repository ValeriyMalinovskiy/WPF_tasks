using Author_s_book_list.Class;
using System;
using System.Globalization;
using System.Windows.Data;

namespace Author_s_book_list.Tools
{
    internal class IsNewToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((value as EntityBase).IsNew)
            {
                {
                    return $"New {value.GetType().Name}";
                }
            }
            return $"Edit {value.GetType().Name}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}