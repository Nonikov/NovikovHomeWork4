using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universite
{
    class Teacher : ITeacher
    {
        string firstName;
        string lastName;
        Subject subject;
        int age;

        public Teacher(string firstName, string lastName, Subject subject, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.subject = subject;
            this.age = age;
        }
        public void Examine()
        {
          
        }

        public void GoToWork()
        {
            Console.WriteLine("GoToWork");
        }

        public void Teaching()
        {
            Console.WriteLine("Teaching");
        }
    }
}
