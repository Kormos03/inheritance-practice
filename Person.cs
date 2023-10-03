using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_10_03
{
    internal class Person
    {
        private string name;
        private int age;
        private string gender;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }

        public Person(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Person()
        {
            this.Name = "Jane Doe";
            this.Age = 30;
            this.Gender = "Female";
        }

     
        public virtual void getGoal()
        {
            Console.WriteLine("My goal is: Live fo the moment!");
        }
        public virtual void introduce()
        {
            Console.WriteLine($"Hi, I'm, {Name}, a {Age} year old {Gender}.")
        }
    }
}
