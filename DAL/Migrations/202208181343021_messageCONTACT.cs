namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class messageCONTACT : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "ContactDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "ContactDate");
        }
    }
}
