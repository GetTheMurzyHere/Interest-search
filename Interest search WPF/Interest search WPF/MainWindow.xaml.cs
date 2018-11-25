using Interest_Search_WPF;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Interest_Search_WPF
{

    public partial class MainWindow : Window
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable MessageTable;
        public MainWindow()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Interest_Search_WPF.Properties.Settings.isPrimConnectionString"].ConnectionString;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
                UpdateDB();
        }
        private void AddMessageButton_Click(object sender, RoutedEventArgs e)
        {
                MessageAddWindow MessageWindow = new MessageAddWindow();
                MessageWindow.ShowDialog();
        }


        private void RefreshChatButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateDB();
        }
        private void UpdateDB()
        {
            string sql = "SELECT * FROM dbo.ChatMessages";
            MessageTable = new DataTable();
            SqlConnection connection = null;
            connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            adapter = new SqlDataAdapter(command);
            connection.Open();
            adapter.Fill(MessageTable);
            chatMessagesDataGrid.ItemsSource = MessageTable.DefaultView;
        }
    }
}
