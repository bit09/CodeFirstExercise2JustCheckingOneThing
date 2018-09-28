using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstExercise2JustCheckingOneThing.Models;

namespace CodeFirstExercise2JustCheckingOneThing.EntityConfigurations
{
    class SubjectsConfiguration : EntityTypeConfiguration<Subject>
    {
        public SubjectsConfiguration()
        {
            ToTable("tbl_Subjects");

            HasRequired(c => c.Lecturer)
                .WithMany(a => a.Subjects)
                .HasForeignKey(c => c.LecturerId);
        }
    }
}
