using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }

        private static int _id = 0;
        public Teacher(string name)
        {
            Id = _id++;
            Name = name;
        }
        public Teacher()
        {
            Id = _id++;
            Name = "";
        }
    }
}
