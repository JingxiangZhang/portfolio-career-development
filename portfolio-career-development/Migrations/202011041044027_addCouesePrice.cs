namespace portfolio_career_development.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCouesePrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Webinars", "CoursePrice", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Webinars", "CoursePrice");
        }
    }
}
