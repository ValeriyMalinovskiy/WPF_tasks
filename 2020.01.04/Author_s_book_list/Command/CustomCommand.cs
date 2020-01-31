using System.Windows;
using System.Windows.Input;

namespace Author_s_book_list.Command
{
    public static class CustomCommand
    {
        public static RoutedCommand UniqueCommand { get; set; }

        static CustomCommand()
        {
            CustomCommand.UniqueCommand = new RoutedCommand(nameof(UniqueCommand), typeof(Window));
        }
    }
}
