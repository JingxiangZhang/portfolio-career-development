namespace portfolio_career_development.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedRoles : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5d0a8be9-fc1d-4625-baf9-213062a27e15', N'canManageALL')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
