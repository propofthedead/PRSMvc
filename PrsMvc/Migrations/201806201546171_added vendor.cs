namespace PrsMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedvendor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Address = c.String(),
                        State = c.String(),
                        City = c.String(),
                        Zip = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        IsPreApproved = c.Boolean(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vendors");
        }
    }
}
