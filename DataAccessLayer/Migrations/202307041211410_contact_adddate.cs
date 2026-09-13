namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contact_adddate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "ContactDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Messages", "MessageDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Messages", "MessageDatet");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "MessageDatet", c => c.DateTime(nullable: false));
            DropColumn("dbo.Messages", "MessageDate");
            DropColumn("dbo.Contacts", "ContactDate");
        }
    }
}
