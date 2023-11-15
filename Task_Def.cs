using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach_wpf

{
    public class Task
        {
        public int Id { get; set; }
        public string User { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string TimeOverdue { get; set; }
    }
    }
