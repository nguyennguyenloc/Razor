using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorEnvironment.Model
{
    public class Student
    {
        public Student()
        {
            this.Name = "default";
        }
        public String Name { get; set; }
        public int Age { get; set; }
    }
}
