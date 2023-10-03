using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_10_03
{
    internal class Mentor : Person
    {
        private string level;

        public Mentor(string name, int age, string gender, string level) : base(name,age,gender)
        {
            this.Name = "Jane Doe";
            this.Age = 30;
            this.Gender = "female";
            this.Level = "intermidate";
        }

        public string Level { get => level; set => level = value; }

        public override void getGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }
        public override void introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} {Level} mentor");
        }

    }
}
