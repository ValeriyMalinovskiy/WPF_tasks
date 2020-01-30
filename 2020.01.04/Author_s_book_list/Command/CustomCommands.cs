using System.Windows;
using System.Windows.Input;

namespace Author_s_book_list.Command
{
    public static class CustomCommands
    {
        public static RoutedCommand Change { get; set; }

        public static RoutedCommand Ok { get; set; }

        public static RoutedCommand Cancel { get; set; }

        static CustomCommands()
        {
            CustomCommands.Change = new RoutedCommand(nameof(Change), typeof(Window));
            CustomCommands.Ok = new RoutedCommand(nameof(Ok), typeof(Window));
            CustomCommands.Cancel = new RoutedCommand(nameof(Cancel), typeof(Window));
        }
    }
}
