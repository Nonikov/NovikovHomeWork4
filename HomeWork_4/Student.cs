using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universite
{
    class Student : IStudent
    {
        string firstName;
        string lastName;
        int age;

        Dictionary<Subject, Score> marks;
        
        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public void DoHomeWork()
        {
            Console.WriteLine("DoHomeWork");
        }

        public void GoToUniversite()
        {
            Console.WriteLine("GoToUniversite");
        }

        public void Schooling()
        {
            Console.WriteLine("Schooling");
        }
    }
}
