//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace kursach_wpf
//{
//    class TaskModel
//    {
//        public class TaskModel : INotifyPropertyChanged
//        {
//            private string name;
//            private string description;
//            private string date;
//            private int id;
//            private bool check;
//            private TaskCategoryModel category;

//            public int Id
//            {
//                get { return id; }
//                set
//                {
//                    id = value;
//                    OnPropertyChanged();
//                }
//            }
//            public string Name
//            {
//                get { return name; }
//                set
//                {
//                    name = value;
//                    OnPropertyChanged();
//                }
//            }

//            public string Description
//            {
//                get { return description; }
//                set
//                {
//                    description = value;
//                    OnPropertyChanged();
//                }
//            }

//            public bool Check
//            {
//                get { return check; }
//                set
//                {
//                    check = value;
//                    OnPropertyChanged();
//                }
//            }

//            public string Date
//            {
//                get { return date; }
//                set
//                {
//                    date = value;
//                    OnPropertyChanged();
//                }
//            }
//        }
