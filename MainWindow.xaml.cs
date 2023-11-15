using Microsoft.Data.Sqlite;
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
using System.Windows.Threading;
using System.Windows.Controls;
namespace kursach_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string connectionString = "Data Source=usersdata.db";
            var connection = new SqliteConnection(connectionString);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = @"SELECT * FROM tasks;";
            var Data = command.ExecuteReader();
            Console.WriteLine(Data.();)
            DispatcherTimer LiveTime = new DispatcherTimer();
            LiveTime.Interval = TimeSpan.FromSeconds(1);
            LiveTime.Tick += timer_Tick;
            LiveTime.Start();
            //string connectionString = "Data Source=usersdata.db";
            //using var connection = new SqliteConnection(connectionString);
            //connection.Open();
            //var command = connection.CreateCommand();
            //command.CommandText =
            //@"
            //    SELECT MIN(end_time) AS lowest_end_time
            //    FROM tasks;
            //    ";
            //object objvalid = command.ExecuteScalar();
            //if (null != objvalid)
            //{ string timer_time_string = objvalid.ToString();
            //    DateTime timer_time = DateTime.ParseExact(timer_time_string, "H:mm", null, System.Globalization.DateTimeStyles.None);

            //    AlarmClock clock = new AlarmClock(timer_time);
            //    clock.Alarm += (sender, e) => {
            //        Question timerwin = new Question();
            //        timerwin.Show();
            //    //};
            //}
            //connection.Close();

        }
        void timer_Tick(object sender, EventArgs e)
        {
            LiveTimeLabel.Content = DateTime.Now.ToString("HH:mm:ss");
        }
        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            AddTaskWindow win2 = new AddTaskWindow();
            win2.Show();
            string connectionString = "Data Source=usersdata.db";
            using var connection = new SqliteConnection(connectionString);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText =
            @"
                CREATE TABLE IF NOT EXISTS tasks (
                id INT AUTO_INCREMENT PRIMARY KEY,
                user TEXT NOT NULL,
                name TEXT NOT NULL,
                description TEXT NOT NULL,
                start_time TEXT NOT NULL,
                end_time TEXT NOT NULL,
                time_overdue TEXT NOT NULL
                );
                ";
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
