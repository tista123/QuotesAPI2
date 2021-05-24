namespace QuotesAPI2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetimadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Quotes", "createdAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Quotes", "createdAt");
        }
    }
}
