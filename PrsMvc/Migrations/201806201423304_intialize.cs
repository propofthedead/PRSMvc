namespace PrsMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        IsReviewer = c.Boolean(nullable: true),
                        IsAdmin = c.Boolean(nullable: true),
                        Active = c.Boolean(nullable: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
