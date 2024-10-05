using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQList
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"Ім'я: {Name}, Вік: {Age}, Середній бал: {Grade}";
        }
    }
}
