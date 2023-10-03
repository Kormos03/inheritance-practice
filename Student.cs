using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_10_03
{
    internal class Student : Person
    {
        private string previousOrganization;
        private int skippedDays;

        public Student(string name, int age, string gender,string previousOrganization) : base(name, age, gender)
        { 
            this.previousOrganization = "The School of Life";
            this.skippedDays = 0;
        }

        public string PreviousOrganization { get => previousOrganization; set => previousOrganization = value; }
        public int SkippedDays { get => skippedDays; set => skippedDays = value; }

        public override void getGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }
        public override void introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} from {PreviousOrganization} who skipped {SkippedDays} days from the course already.");
        }
        public virtual int skipDays(int numberOfDays)
        {
            return SkippedDays += numberOfDays;
        }
    }
}
