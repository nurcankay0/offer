namespace Offer1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSizeColumnInUsersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Size", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Size");
        }
    }
}
