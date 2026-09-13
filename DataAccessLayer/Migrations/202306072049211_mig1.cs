namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        //migration dedigimiz bir sinif olusturmus olundu burda.Ve denilen su
        
        //Eger sen degisiklikleri kaydedersen bu kisim calisacak
        public override void Up()
        {
            AddColumn("dbo.Contents", "WriterID", c => c.Int());
            CreateIndex("dbo.Contents", "WriterID");
            AddForeignKey("dbo.Contents", "WriterID", "dbo.Writers", "WriterID");
        }

        //Eger sen degisiklikleri kaydetmezrsen bu kisim calisacak
        public override void Down()
        {
            DropForeignKey("dbo.Contents", "WriterID", "dbo.Writers");
            DropIndex("dbo.Contents", new[] { "WriterID" });
            DropColumn("dbo.Contents", "WriterID");
        }
    }
}
