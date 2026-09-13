namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class content_table_contentValueto20000 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contents", "ContentValue", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contents", "ContentValue", c => c.String(maxLength: 1000));
        }
    }
}
