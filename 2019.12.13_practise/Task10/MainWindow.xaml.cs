using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //bool IsButtonEnabled;

        public MainWindow()
        {

            InitializeComponent();
            CommandBinding bind = new CommandBinding(CustomCommands.CalcButtonCommand);
            bind.Executed += Bind_Executed;
            this.CommandBindings.Add(bind);

        //        < StackPanel >
        //< Button Margin = "50" Content = "Open" Command = "ApplicationCommands.Open" ></ Button >
     
        //     < CheckBox x: Name = "CheckStatusBox" Margin = "50" Content = "Turn on to enable button" Command = "local:MyCommands.ChangeButtonStatus" ></ CheckBox >
             
        //         </ StackPanel >

        //                 var bind = new CommandBinding(ApplicationCommands.Open);

        //    bind.Executed += Bind_Executed;
        //    bind.CanExecute += Bind_CanExecute;

        //    this.CommandBindings.Add(bind);

        //    var bind2 = new CommandBinding(MyCommands.ChangeButtonStatus);

        //    bind2.Executed += Bind2_Executed;
        //    //bind2.CanExecute += Bind_CanExecute;

        //    this.CommandBindings.Add(bind2);
        }

        private void Bind_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Button button = e.Source as Button;
        switch (button.Name)
            {
                case "One":
                    this.InputBox.Text += "1";
                    break;
                case "Two":
                    this.InputBox.Text += "2";
                    break;
                case "Three":
                    this.InputBox.Text += "3";
                    break;
                case "Four":
                    this.InputBox.Text += "4";
                    break;
                case "Five":
                    this.InputBox.Text += "5";
                    break;
                case "Six":
                    this.InputBox.Text += "6";
                    break;
                case "Seven":
                    this.InputBox.Text += "7";
                    break;
                case "Eight":
                    this.InputBox.Text += "8";
                    break;
                case "Nine":
                    this.InputBox.Text += "9";
                    break;
                case "Zero":
                    this.InputBox.Text += "0";
                    break;
                case "Del":
                    this.InputBox.Text = DeleteLastChar(this.InputBox.Text);
                    break;
                case "Ce":
                    this.InputBox.Text = string.Empty;
                    this.InputBox.Text += "0";
                    break;
            }
        }

        private string DeleteLastChar(string str)
        {
            if (str.Length>0)
            {
                char[] tempArr = str.ToArray();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < tempArr.Length - 1; i++)
                {
                    sb.Append(tempArr[i]);
                }
                return sb.ToString();
            }
            return str;
        }

        //private void Grid_Click(object sender, RoutedEventArgs e)
        //{
        //}

        //    private void Bind2_Executed(object sender, ExecutedRoutedEventArgs e)
        //    {
        //        //throw new NotImplementedException();
        //        this.IsButtonEnabled = !this.IsButtonEnabled;
        //    }

        //    private void Bind_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        //    {
        //        //e.CanExecute = DateTime.Now.Second % 2 == 0;
        //        //e.CanExecute = this.CheckStatusBox.IsChecked.Value;
        //        e.CanExecute = this.IsButtonEnabled;
        //    }

        //    private void Bind_Executed(object sender, ExecutedRoutedEventArgs e)
        //    {
        //        new MainWindow().ShowDialog();
        //    }

        //    private void Buttons_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        //    {

    }

    //}
    //public static class MyCommands
    //{
    //    public static RoutedCommand ChangeButtonStatus { get; set; }
    //    static MyCommands()
    //    {
    //        ChangeButtonStatus = new RoutedCommand(nameof(ChangeButtonStatus), typeof(MainWindow));
    //    }
    //}
    public static class CustomCommands
    {
        public static RoutedCommand CalcButtonCommand { get; set; }
        static CustomCommands()
        {
            CustomCommands.CalcButtonCommand = new RoutedCommand(nameof(CalcButtonCommand), typeof(Window));
        }
    }
}

