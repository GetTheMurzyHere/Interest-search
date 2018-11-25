using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Interest_Search_WPF
{
    public partial class MessageAddWindow : Window
    {
        bool NameInputcheck = true;
        bool PlaceInputcheck = true;
        bool MessageInputcheck = true;
        string connectionString;
        public MessageAddWindow()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Interest_Search_WPF.Properties.Settings.isPrimConnectionString"].ConnectionString;    
        }
        private void NameInputBoxClick(object sender, MouseEventArgs e)
        {
            if (NameInputcheck)
            {
                NameInputBox.Text = "";
            };
            NameInputcheck = false;
            NameInputBox.Foreground = Brushes.Black;
        }

        private void PlaceInputBoxClick(object sender, MouseEventArgs e)
        {
            if (PlaceInputcheck)
            {
                PlaceInputBox.Text = "";
            };
            PlaceInputcheck = false;
            PlaceInputBox.Foreground = Brushes.Black;
        }

        private void MessageInputBoxClick(object sender, MouseEventArgs e)
        {
            if (MessageInputcheck)
            {
                MessageInputBox.Text = "";
            };
            MessageInputcheck = false;
            MessageInputBox.Foreground = Brushes.Black;
        }

        private void SendMessageButtonClick(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "INSERT INTO dbo.ChatMessages(MessageAuthor, ObjectSelesctID, dateGTime,MessageText) VALUES ('Ersan', 1,13-09-2000,'asd')";
                command.Connection = connection;
            }
            this.Close();
        }

        private void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DateInputBoxClick(object sender, MouseEventArgs e)
        {
            if (DatePick.Text == "")
            {
                System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                DatePick.SelectedDate = DateTime.UtcNow;
            };
            DatePick.Foreground = Brushes.Black;
        }

        private void DatePick_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void DatePick_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Char.IsNumber(Convert.ToChar(e.Text)) || e.Text == ".")
            {
                e.Handled = false;
            } else
            {
                e.Handled = true;
            }
            base.OnPreviewTextInput(e);
        }
    }
}
