using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Course
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public PracticalGrade practicalGrade { get; set; }
        public bool Passed()
        {
            return this.Grade >= 55 && this.practicalGrade >= PracticalGrade.Sufficient;
        }
        public bool CumLaude()
        {
            return this.Grade >= 80 && this.practicalGrade == PracticalGrade.Good;

        }
    }
}
