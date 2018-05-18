namespace StockeManagement.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Qty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.StockInDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StockInId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Qty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.StockIns", t => t.StockInId, cascadeDelete: true)
                .Index(t => t.StockInId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.StockIns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        StocInDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StockOutDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StockOutId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Qty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.StockOuts", t => t.StockOutId, cascadeDelete: true)
                .Index(t => t.StockOutId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.StockOuts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        StockOutDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockOutDetails", "StockOutId", "dbo.StockOuts");
            DropForeignKey("dbo.StockOutDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.StockInDetails", "StockInId", "dbo.StockIns");
            DropForeignKey("dbo.StockInDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Inventories", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.StockOutDetails", new[] { "ProductId" });
            DropIndex("dbo.StockOutDetails", new[] { "StockOutId" });
            DropIndex("dbo.StockInDetails", new[] { "ProductId" });
            DropIndex("dbo.StockInDetails", new[] { "StockInId" });
            DropIndex("dbo.Inventories", new[] { "ProductId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.StockOuts");
            DropTable("dbo.StockOutDetails");
            DropTable("dbo.StockIns");
            DropTable("dbo.StockInDetails");
            DropTable("dbo.Inventories");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
