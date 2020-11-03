namespace portfolio_career_development.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userDB_back_to_default : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "firstName");
            DropColumn("dbo.AspNetUsers", "lastName");
            DropColumn("dbo.AspNetUsers", "contactNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "contactNumber", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "lastName", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.AspNetUsers", "firstName", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
