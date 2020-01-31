using Author_s_book_list.Class;
using Author_s_book_list.Enums;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Author_s_book_list.Tools
{
    class LanguageToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null)
            {
                
                return Colors.White;
            }
            else
            {
                switch (value.ToString())
                {
                    case "English":
                        {
                            return Colors.LightSalmon;
                        }
                    case "German":
                        {
                            return Colors.Yellow;
                        }
                    case "Russian":
                        {
                            return Colors.LightSkyBlue;
                        }
                    case "Ukrainian":
                        {
                            return Colors.Gray;
                        }
                }
            }
            return new object();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
