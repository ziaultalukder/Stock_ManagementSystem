namespace StockeManagement.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class totalAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "IsDeleted");
        }
    }
}
