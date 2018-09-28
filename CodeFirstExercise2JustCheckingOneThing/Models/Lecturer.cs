using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExercise2JustCheckingOneThing.Models
{
    public class Lecturer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Subject> Subjects { get; set; }
    }
}
