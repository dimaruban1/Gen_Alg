using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
        
        private static int _id = 0;
        public Course(string name, IEnumerable<Teacher> teachers)
        {
            Id = _id++;
            Name = name;
            Teachers = teachers.ToList();
        }
        public Course()
        {
            Id = _id++;
            Name = "";
            Teachers = new List<Teacher>();
        }
    }
}
