namespace CodeFirstExercise2JustCheckingOneThing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Lecturers", "Subject_Id", "dbo.Subjects");
            DropIndex("dbo.Lecturers", new[] { "Subject_Id" });
            AddColumn("dbo.Subjects", "Lecturer_Id", c => c.Int());
            CreateIndex("dbo.Subjects", "Lecturer_Id");
            AddForeignKey("dbo.Subjects", "Lecturer_Id", "dbo.Lecturers", "Id");
            DropColumn("dbo.Lecturers", "Subject_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Lecturers", "Subject_Id", c => c.Int());
            DropForeignKey("dbo.Subjects", "Lecturer_Id", "dbo.Lecturers");
            DropIndex("dbo.Subjects", new[] { "Lecturer_Id" });
            DropColumn("dbo.Subjects", "Lecturer_Id");
            CreateIndex("dbo.Lecturers", "Subject_Id");
            AddForeignKey("dbo.Lecturers", "Subject_Id", "dbo.Subjects", "Id");
        }
    }
}
