namespace StockeManagement.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PartyTableChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parties", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Parties", "DeletedBy", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parties", "DeletedBy");
            DropColumn("dbo.Parties", "IsDeleted");
        }
    }
}
