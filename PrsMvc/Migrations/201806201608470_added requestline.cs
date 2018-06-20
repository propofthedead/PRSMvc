namespace PrsMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedrequestline : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PurchaseRequestLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PurchaseRequestId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quanity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PurchaseRequestLines");
        }
    }
}
