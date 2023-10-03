using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_10_03
{
    internal class Sponsor : Person
    {
        private string company;
        private int hiredStudents;

        public override void introduce()
        {
            Console.WriteLine($"Hi, Im {Name}, a {Age} year old {Gender} who represents {company} and hied {hiredStudents} students so far.");
        }
        public virtual void hire()
        {
            hiredStudents++;
        }
        public override void getGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }
    }
}
