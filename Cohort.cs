using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_10_03
{
    internal class Cohort : Student
    {
        private string cohortname;
        private List<Student> students;
        private List<Mentor> mentors;

        public Cohort(string Cohortname)
        {
           this.Cohortname = "awesomelol";
        }


        internal List<Student> Students { get => students; set => students = value; }
        internal List<Mentor> Mentors { get => mentors; set => mentors = value; }
        public string Cohortname { get => cohortname; set => cohortname = value; }

        public void addStudent(string name, int age, string gender, string previousOrganization)
        {
            Students.Add(new Student(name, age, gender, previousOrganization));
        }
        public void addMentor(string name, int age, string gender, string level)
        {
            Mentors.Add(new Mentor(name, age, gender, level));
        }
        public void info()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine(ToStrings(Students));
            }
        }
        public string ToStrings(List<Student> students)
        {
            return $"{students.}, {this.Age}, {this.Gender}, {this.PreviousOrganization}";
        }
    }
}
