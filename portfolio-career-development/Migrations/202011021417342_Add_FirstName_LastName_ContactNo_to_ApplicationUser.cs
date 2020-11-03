namespace portfolio_career_development.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_FirstName_LastName_ContactNo_to_ApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "firstName", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.AspNetUsers", "lastName", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.AspNetUsers", "contactNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "contactNumber");
            DropColumn("dbo.AspNetUsers", "lastName");
            DropColumn("dbo.AspNetUsers", "firstName");
        }
    }
}
