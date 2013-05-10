namespace MvcApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adam : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.News", "Author", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.News", "Title", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.News", "Content", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.News", "Content", c => c.String());
            AlterColumn("dbo.News", "Title", c => c.String());
            AlterColumn("dbo.News", "Author", c => c.String());
        }
    }
}
