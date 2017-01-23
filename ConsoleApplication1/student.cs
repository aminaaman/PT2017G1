using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class Student
    {
        public string name;
        public string surname;
        public int age;
        public double gpa;

        public Student(string name, string surname, int age, double gpa)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.gpa = gpa;
        }

        public override string ToString()
        {
            return name + " " + surname + " " + age + " " + gpa;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Amina", "Aman", 25, 3.8);
            Console.WriteLine(s.ToString());
        }
    }
}
