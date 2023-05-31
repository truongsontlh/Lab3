namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourse121 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Courses", new[] { "LectureID" });
            CreateIndex("dbo.Courses", "LectureId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Courses", new[] { "LectureId" });
            CreateIndex("dbo.Courses", "LectureID");
        }
    }
}
