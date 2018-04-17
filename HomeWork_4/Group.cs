using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universite
{
    class Group
    {
        public int nameNumber { get; set; }
        int quantity;

        List<Student> _students;
        List<Subject> _listOfSubject;

        public Group()
        {
            _students = new List<Student>(40);
        }

        public Group(int nameNumber)
            : this()
        {
            this.nameNumber = nameNumber;
        }

        public Group(int nameNumber, params Student[] students)
            : this(nameNumber)
        {
            AddStadents(students);
        }

        public void AddStadents(params Student[] students)
        {
            if (_students.Count + students.Length < 40)
            {
                _students.AddRange(students);

                quantity += students.Length;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
        {
            return $"Group namenumber is: \"{nameNumber}\", number of students in the group is:({quantity}).";
        }
    }
}
