

using Interest_Search_WPF;
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

namespace Interest_Search_WPF
    {

    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
        }

        private void AddMessageButton_Click(object sender, RoutedEventArgs e)
        {
            MessageAddWindow MessageWindow = new MessageAddWindow();
            MessageWindow.Show();
        }

    }
