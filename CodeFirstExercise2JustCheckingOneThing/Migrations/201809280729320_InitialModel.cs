namespace CodeFirstExercise2JustCheckingOneThing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lecturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Lecturer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lecturers", t => t.Lecturer_Id)
                .Index(t => t.Lecturer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "Lecturer_Id", "dbo.Lecturers");
            DropIndex("dbo.Subjects", new[] { "Lecturer_Id" });
            DropTable("dbo.Subjects");
            DropTable("dbo.Lecturers");
        }
    }
}
