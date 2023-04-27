using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction
{
    internal class student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Getstudentdetail()
        {
            return $"student name : ${Name} and age :{Age} ";
        }
    }
    
}
