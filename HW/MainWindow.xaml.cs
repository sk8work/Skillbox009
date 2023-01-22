using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static System.Net.Mime.MediaTypeNames;

namespace HW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Words> db = new ObservableCollection<Words>();
        public MainWindow()
        {
            InitializeComponent();
            stringToArray.ItemsSource = db;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string[] newStr = innerText.Text.Split(" ");

            Array.Reverse(newStr);

            this.reversedString.Content = string.Join(" ", newStr);
        }

        private void innerText_GotFocus(object sender, RoutedEventArgs e)
        {
            this.innerText.Text = String.Empty;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            db.Clear();
            string[] newStr = innerText.Text.Split(" ");
            foreach (var item in newStr)
            {
                db.Add(new Words()
                {
                    ResultWords = item,
                });
            }
        }
    }
}
