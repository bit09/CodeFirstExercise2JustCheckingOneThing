using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CodeFirstExercise2JustCheckingOneThing.Models;

namespace CodeFirstExercise2JustCheckingOneThing.EntityConfigurations
{
    class LecturersConfiguration : EntityTypeConfiguration<Lecturer>
    {
        public LecturersConfiguration()
        {
            ToTable("tbl_Lecturers");
        }
    }
}
