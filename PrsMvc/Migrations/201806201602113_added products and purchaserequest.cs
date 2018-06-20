namespace PrsMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedproductsandpurchaserequest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VendorId = c.Int(nullable: false),
                        Name = c.String(),
                        PartNumber = c.String(),
                        Description = c.String(),
                        Unit = c.String(),
                        PhotoPath = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PurchaseRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Justification = c.String(),
                        Description = c.String(),
                        DeliveryMode = c.String(),
                        Status = c.String(),
                        Active = c.Boolean(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ReasonForRejection = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PurchaseRequests");
            DropTable("dbo.Products");
        }
    }
}
