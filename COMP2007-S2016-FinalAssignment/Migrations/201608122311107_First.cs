namespace COMP2007_S2016_FinalAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        RecordId = c.Int(nullable: false, identity: true),
                        CartId = c.String(),
                        Count = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RecordId)
                .ForeignKey("dbo.ProductModels", t => t.ID, cascadeDelete: true)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        Province = c.String(),
                        PostalCode = c.String(),
                        Country = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OrderDetailId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderId = c.Int(nullable: false),
                        ProductModels_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.ProductModels", t => t.ProductModels_ID)
                .Index(t => t.OrderId)
                .Index(t => t.ProductModels_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "ProductModels_ID", "dbo.ProductModels");
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Carts", "ID", "dbo.ProductModels");
            DropIndex("dbo.OrderDetails", new[] { "ProductModels_ID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropIndex("dbo.Carts", new[] { "ID" });
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Orders");
            DropTable("dbo.Carts");
        }
    }
}
