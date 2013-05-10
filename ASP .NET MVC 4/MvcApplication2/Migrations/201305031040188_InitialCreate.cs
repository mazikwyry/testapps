namespace MvcApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.News",
                c => new
                    {
                        NewsId = c.Int(nullable: false, identity: true),
                        Author = c.String(),
                        Title = c.String(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.NewsId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        NewsId = c.Int(nullable: false),
                        Author = c.String(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.News", t => t.NewsId, cascadeDelete: true)
                .Index(t => t.NewsId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Comments", new[] { "NewsId" });
            DropForeignKey("dbo.Comments", "NewsId", "dbo.News");
            DropTable("dbo.Comments");
            DropTable("dbo.News");
        }
    }
}
