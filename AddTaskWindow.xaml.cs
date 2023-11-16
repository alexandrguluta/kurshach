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
using Microsoft.Data.Sqlite;

namespace kursach_wpf
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class AddTaskWindow : Window
    {
        /// <summary>
        /// 
        ///// </summary>
        //public AddTaskWindow()
        //{
        //    InitializeComponent();
        //}

        public Task Task { get; private set; }
        public AddTaskWindow()
        {
            InitializeComponent();
            //Task = task;
            //DataContext = Task;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Name_TB.Text != "Имя" & Desc_TB.Text != "Описание")
            {
                string connectionString = "Data Source=usersdata.db";
                using var connection = new SqliteConnection(connectionString);
    connection.Open();
                var command = connection.CreateCommand();
    command.CommandText = "INSERT INTO tasks (user, name, description, start_time, end_time, time_overdue) " +
                                          "VALUES (@user, @name, @description, @start_time, @end_time, @time_overdue)";

                    // Добавляем параметры к команде
                    command.Parameters.AddWithValue("@user", "defaultuser");
                    command.Parameters.AddWithValue("@name", Name_TB.Text);
                    command.Parameters.AddWithValue("@description", Desc_TB.Text);
                    command.Parameters.AddWithValue("@start_time", Start_Time.Text); // Пример времени в формате текста
                    command.Parameters.AddWithValue("@end_time", End_Time.Text); // Пример времени в формате текста
                    command.Parameters.AddWithValue("@time_overdue", 0);
                command.ExecuteNonQuery();
                connection.Close();
                this.Close();
    }
            else
            {
                MessageBox.Show("Нужно заполнить все поля!");

            }
            //MessageBox.Show(Start_Time.Text);
        }

        private void Name_TB_GotFocus(object sender, EventArgs e)
        {
            Name_TB.Text = "";
        }
        private void Desc_TB_GotFocus(object sender, EventArgs e)
        {
            Desc_TB.Text = "";
        }
    }
    }




