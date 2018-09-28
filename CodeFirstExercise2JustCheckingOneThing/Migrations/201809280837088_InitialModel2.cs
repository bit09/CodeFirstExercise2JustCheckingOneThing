namespace CodeFirstExercise2JustCheckingOneThing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Subjects", "Subject_Id", "dbo.Subjects");
            DropIndex("dbo.Subjects", new[] { "Subject_Id" });
            DropColumn("dbo.Subjects", "Subject_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Subjects", "Subject_Id", c => c.Int());
            CreateIndex("dbo.Subjects", "Subject_Id");
            AddForeignKey("dbo.Subjects", "Subject_Id", "dbo.Subjects", "Id");
        }
    }
}
