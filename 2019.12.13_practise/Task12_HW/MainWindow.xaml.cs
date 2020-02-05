using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Task12_HW
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CommandBinding bind = new CommandBinding(CustomCommands.CalcButtonCommand);
            bind.Executed += Bind_Executed;
            this.CommandBindings.Add(bind);
        }

        private void Bind_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            bool AddDigit = true;
            string tempString = "0";

            Button button = e.Source as Button;
            switch (button.Name)
            {
                case "One":
                    tempString = "1";
                    break;
                case "Two":
                    tempString = "2";
                    break;
                case "Three":
                    tempString = "3";
                    break;
                case "Four":
                    tempString = "4";
                    break;
                case "Five":
                    tempString = "5";
                    break;
                case "Six":
                    tempString = "6";
                    break;
                case "Seven":
                    tempString = "7";
                    break;
                case "Eight":
                    tempString = "8";
                    break;
                case "Nine":
                    tempString = "9";
                    break;
                case "Zero":
                    {
                        tempString = "0";
                    }
                    break;
                case "Del":
                    string tempString2 = DeleteLastChar(this.InputBox.Text);
                    if (tempString2.Equals("0"))
                    {
                        tempString = "0";
                    }
                    else
                        tempString = tempString2;
                    AddDigit = false;
                    break;
                case "Ce":
                    tempString = "0";
                    AddDigit = false;
                    break;
                case "C":
                    tempString = "0";
                    AddDigit = false;
                    break;
            }

            if (this.InputBox.Text.Length == 1 && this.InputBox.Text == "0" && AddDigit)
            {
                this.InputBox.Text = tempString;
            }
            else if (AddDigit)
            {
                this.InputBox.Text += tempString;
            }
            else
            {
                this.InputBox.Text = tempString;
            }
        }

        private string DeleteLastChar(string str)
        {
            if (str.Equals("0"))
            {
                return "0";
            }
            else if (str.Length > 1)
            {
                char[] tempArr = str.ToArray();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < tempArr.Length - 1; i++)
                {
                    sb.Append(tempArr[i]);
                }
                return sb.ToString();
            }
            else
            {
                return "0";
            }
        }
    }

    public static class CustomCommands
    {
        public static RoutedCommand CalcButtonCommand { get; set; }
        static CustomCommands()
        {
            CustomCommands.CalcButtonCommand = new RoutedCommand(nameof(CalcButtonCommand), typeof(Window));
        }
    }
}


