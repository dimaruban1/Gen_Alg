using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    public class Time
    {
        [Key]
        public int Id { get; set; }
        public string TimeStr { get; set; }

        private static int _id = 0;
        public Time(string timeStr)
        {
            TimeStr = timeStr;
            Id = _id++;
        }
        public Time()
        {
            TimeStr = "";
            Id = _id++;
        }
    }
}
