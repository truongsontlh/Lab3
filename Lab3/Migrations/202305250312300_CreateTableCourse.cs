namespace Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LectureID = c.String(nullable: false, maxLength: 128),
                        Place = c.String(nullable: false, maxLength: 255),
                        Datetime = c.DateTime(nullable: false),
                        Category = c.Byte(nullable: false),
                        CategoryID = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.LectureID, cascadeDelete: true)
                .Index(t => t.LectureID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "LectureID", "dbo.AspNetUsers");
            DropIndex("dbo.Courses", new[] { "LectureID" });
            DropTable("dbo.Courses");
            DropTable("dbo.Categories");
        }
    }
}
