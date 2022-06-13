using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement el in MainRoot.Children)
            {
                if(el is Button)
                {
                    ((Button) el).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;

            if (str == "Clear")
                textLabel.Text = "";
            else if(str == "=")
            {
                string answer = new DataTable().Compute(textLabel.Text, null).ToString();
                textLabel.Text = answer;
            }
            else 
                textLabel.Text += str;
        }
    }
}
