namespace portfolio_career_development.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class webinarModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Webinars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Topic = c.String(nullable: false, maxLength: 60),
                        About = c.String(nullable: false),
                        DateWebinar = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Webinars");
        }
    }
}
