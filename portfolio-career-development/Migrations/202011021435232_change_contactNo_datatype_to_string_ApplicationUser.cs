namespace portfolio_career_development.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_contactNo_datatype_to_string_ApplicationUser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "contactNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "contactNumber", c => c.Int(nullable: false));
        }
    }
}
