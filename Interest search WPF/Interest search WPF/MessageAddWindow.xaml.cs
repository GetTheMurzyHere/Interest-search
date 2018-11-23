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
using System.Windows.Shapes;

namespace Interest_Search_WPF
{
    public partial class MessageAddWindow : Window
    {
        public MessageAddWindow()
        {
            InitializeComponent();
        }

        private void NameInputBoxClick(object sender, MouseEventArgs e)
        {
            NameInputBox.Text = "";
        }

        private void PlaceInputBoxClick(object sender, MouseEventArgs e)
        {
            PlaceInputBox.Text = "";
        }

        private void TimeInputBoxClick(object sender, MouseEventArgs e)
        {
            TimeInputBox.Text = "";
        }

        private void MessageInputBoxClick(object sender, MouseEventArgs e)
        {
            MessageInputBox.Text = "";
        }

        private void SendMessageButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
