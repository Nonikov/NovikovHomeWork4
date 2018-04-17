using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universite
{
    class Lesson
    {
        Subject _subject { get; set; }
        public Score score { get; set; }

        public Lesson(Subject  subject)
        {
            _subject = subject;
        }
    }
}
