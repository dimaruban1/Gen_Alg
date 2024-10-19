using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        private static int _id;
        public Group(string name)
        {
            Name = name;
            Id = _id++;
        }
        public Group()
        {
            Name = "";
        }
    }
}
