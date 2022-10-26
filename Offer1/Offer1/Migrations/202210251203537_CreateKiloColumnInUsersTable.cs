namespace Offer1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateKiloColumnInUsersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Kilo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Kilo");
        }
    }
}
