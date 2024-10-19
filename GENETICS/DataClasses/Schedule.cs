using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    public class Schedule
    {
        public ICollection<Class> Classes { get; set; }

        public Schedule(ICollection<Class> classes)
        {
            Classes = classes;
        }
        public Schedule()
        {
            Classes = new List<Class>();
        }
    }
}
