namespace CodeFirstExercise2JustCheckingOneThing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Subjects", "Lecturer_Id", "dbo.Lecturers");
            DropIndex("dbo.Subjects", new[] { "Lecturer_Id" });
            AddColumn("dbo.Lecturers", "Subject_Id", c => c.Int());
            AddColumn("dbo.Subjects", "Subject_Id", c => c.Int());
            CreateIndex("dbo.Lecturers", "Subject_Id");
            CreateIndex("dbo.Subjects", "Subject_Id");
            AddForeignKey("dbo.Subjects", "Subject_Id", "dbo.Subjects", "Id");
            AddForeignKey("dbo.Lecturers", "Subject_Id", "dbo.Subjects", "Id");
            DropColumn("dbo.Subjects", "Lecturer_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Subjects", "Lecturer_Id", c => c.Int());
            DropForeignKey("dbo.Lecturers", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.Subjects", "Subject_Id", "dbo.Subjects");
            DropIndex("dbo.Subjects", new[] { "Subject_Id" });
            DropIndex("dbo.Lecturers", new[] { "Subject_Id" });
            DropColumn("dbo.Subjects", "Subject_Id");
            DropColumn("dbo.Lecturers", "Subject_Id");
            CreateIndex("dbo.Subjects", "Lecturer_Id");
            AddForeignKey("dbo.Subjects", "Lecturer_Id", "dbo.Lecturers", "Id");
        }
    }
}
