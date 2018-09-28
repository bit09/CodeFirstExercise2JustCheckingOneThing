namespace CodeFirstExercise2JustCheckingOneThing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Subjects", "Lecturer_Id", "dbo.Lecturers");
            DropIndex("dbo.Subjects", new[] { "Lecturer_Id" });
            RenameColumn(table: "dbo.Subjects", name: "Lecturer_Id", newName: "LecturerId");
            AlterColumn("dbo.Subjects", "LecturerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Subjects", "LecturerId");
            AddForeignKey("dbo.Subjects", "LecturerId", "dbo.Lecturers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "LecturerId", "dbo.Lecturers");
            DropIndex("dbo.Subjects", new[] { "LecturerId" });
            AlterColumn("dbo.Subjects", "LecturerId", c => c.Int());
            RenameColumn(table: "dbo.Subjects", name: "LecturerId", newName: "Lecturer_Id");
            CreateIndex("dbo.Subjects", "Lecturer_Id");
            AddForeignKey("dbo.Subjects", "Lecturer_Id", "dbo.Lecturers", "Id");
        }
    }
}
