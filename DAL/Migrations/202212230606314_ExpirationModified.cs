namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExpirationModified : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tokens", "Expiration", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tokens", "Expiration", c => c.DateTime(nullable: false));
        }
    }
}
