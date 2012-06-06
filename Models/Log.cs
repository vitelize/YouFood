using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Log
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
