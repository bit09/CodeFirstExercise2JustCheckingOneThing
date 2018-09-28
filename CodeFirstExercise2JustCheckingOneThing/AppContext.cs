using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CodeFirstExercise2JustCheckingOneThing.Models;

namespace CodeFirstExercise2JustCheckingOneThing
{
    public class AppContext: DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }

        public AppContext()
            :base("DefaultConnection")
        {

        }
    }
}
