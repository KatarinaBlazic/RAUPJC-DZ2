using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad4;

namespace Zad5
{
    public class University
    {
        public string Name { get; set; }
        public Student[] Students { get; set; }

        public University(String name, params Student[] students)
        {
            Name = name;
            Students = students;
        }
    }
}
