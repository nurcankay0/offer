namespace Offer1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTeklifColumnInUsersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Teklif", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Teklif");
        }
    }
}
