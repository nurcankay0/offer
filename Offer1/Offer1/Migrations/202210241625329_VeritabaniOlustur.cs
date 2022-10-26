namespace Offer1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VeritabaniOlustur : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Company = c.String(),
                        Mode = c.String(),
                        MovementType = c.String(),
                        Incoterm = c.String(),
                        Countries = c.String(),
                        Cities = c.String(),
                        PackageType = c.String(),
                        Unit1 = c.String(),
                        
                        Unit2 = c.String(),
                     
                    Currency = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
