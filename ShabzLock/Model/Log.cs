using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShabzLock.Model
{
    public class Log
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        private static int NextId = 1;

        public Log()
        {
            
        }

        public Log(string name, DateTime date, string status)
        {
            Id = NextId++;
            Name = name;
            Date = date;
            Status = status;
        }
    }
}
