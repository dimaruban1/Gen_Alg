using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    public class Class
    {
        public int Id { get; set; }
        public Time Time { get; set; }
        public Group Group { get; set; }
        public Teacher Teacher { get; set; }
        public Course Course { get; set; }

        private static int _id = 0;
        public Class(Time time, Group group, Teacher teacher, Course course)
        {
            Id = _id++;
            Time = time;
            Group = group;
            Teacher = teacher;
            Course = course;
        }
        public Class()
        {
            Id = _id++;
            Time = new Time();
            Group = new Group();
            Teacher = new Teacher();
            Course = new Course();
        }
    }
}
