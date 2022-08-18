namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contactdaterepair : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "ContactDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Messages", "ContactDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "ContactDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Contacts", "ContactDate");
        }
    }
}
