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
using System.Threading;

namespace kursach_wpf
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Threading.Timer timerglobal;
        private void SetUpTimer(TimeSpan alertTime)
        {
            DateTime current = DateTime.Now;
            TimeSpan timeToGo = alertTime - current.TimeOfDay;
            if (timeToGo < TimeSpan.Zero)
            {
                return;//time already passed
            }
            this.timerglobal = new System.Threading.Timer(x =>
            {

            }, null, timeToGo, Timeout.InfiniteTimeSpan);
        }

        public void ShowQuestion()
        {
            Question questionwin = new Question();
            questionwin.Show();
        }
        private void StartTimerToTheNearest()
        {

        }
        private DateTime GetTimeFromDBID(int id)
        {
            //
            return DateTime.Now.AddMinutes(10);
        }
        private DateTime GetTimeFromDBNearest()
        {
            return DateTime.Now.AddMinutes(1);
        }
        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer LiveTime = new DispatcherTimer();
            LiveTime.Interval = TimeSpan.FromSeconds(1);
            LiveTime.Tick += timer_Tick;



        }
        public void InitializeDB()
        {
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
        }
        void timer_Tick(object sender, EventArgs e)
        {
            LiveTimeLabel.Content = DateTime.Now.ToString("HH:mm:ss");
        }
        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            AddTaskWindow win2 = new AddTaskWindow();
            win2.Show();
        }
    }
}
