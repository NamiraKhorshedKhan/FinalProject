namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablesAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Username = c.String(nullable: false, maxLength: 200),
                        Email = c.String(nullable: false, maxLength: 320),
                        Password = c.String(nullable: false),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Username, unique: true)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CusId = c.String(maxLength: 128),
                        ResId = c.String(maxLength: 128),
                        Number = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CusId)
                .ForeignKey("dbo.Restaurants", t => t.ResId)
                .Index(t => t.CusId)
                .Index(t => t.ResId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Username = c.String(nullable: false, maxLength: 200),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false, maxLength: 320),
                        Password = c.String(nullable: false),
                        Contact = c.Int(nullable: false),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Username, unique: true)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        BookingId = c.String(maxLength: 128),
                        Amount = c.Single(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        Status = c.String(nullable: false),
                        CusId = c.String(maxLength: 128),
                        ResId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bookings", t => t.BookingId)
                .ForeignKey("dbo.Customers", t => t.CusId)
                .ForeignKey("dbo.Restaurants", t => t.ResId)
                .Index(t => t.BookingId)
                .Index(t => t.CusId)
                .Index(t => t.ResId);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Username = c.String(nullable: false, maxLength: 200),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false, maxLength: 320),
                        Password = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Contact = c.Int(nullable: false),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Username, unique: true)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ResId = c.String(maxLength: 128),
                        Name = c.String(nullable: false),
                        Type = c.String(nullable: false),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Restaurants", t => t.ResId)
                .Index(t => t.ResId);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CusId = c.String(maxLength: 128),
                        ResId = c.String(maxLength: 128),
                        Rate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CusId)
                .ForeignKey("dbo.Restaurants", t => t.ResId)
                .Index(t => t.CusId)
                .Index(t => t.ResId);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CusId = c.String(maxLength: 128),
                        ResId = c.String(maxLength: 128),
                        Comment = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CusId)
                .ForeignKey("dbo.Restaurants", t => t.ResId)
                .Index(t => t.CusId)
                .Index(t => t.ResId);
            
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(maxLength: 128),
                        Comment = c.String(nullable: false),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Logins", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Username = c.String(nullable: false, maxLength: 200),
                        Email = c.String(nullable: false, maxLength: 320),
                        Password = c.String(nullable: false),
                        Type = c.String(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Username, unique: true)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Tkey = c.String(nullable: false),
                        Creation = c.DateTime(nullable: false),
                        Expiration = c.DateTime(nullable: false),
                        LoginId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Logins", t => t.LoginId)
                .Index(t => t.LoginId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Feedbacks", "UserId", "dbo.Logins");
            DropForeignKey("dbo.Tokens", "LoginId", "dbo.Logins");
            DropForeignKey("dbo.Bookings", "ResId", "dbo.Restaurants");
            DropForeignKey("dbo.Bookings", "CusId", "dbo.Customers");
            DropForeignKey("dbo.Payments", "ResId", "dbo.Restaurants");
            DropForeignKey("dbo.Reviews", "ResId", "dbo.Restaurants");
            DropForeignKey("dbo.Reviews", "CusId", "dbo.Customers");
            DropForeignKey("dbo.Ratings", "ResId", "dbo.Restaurants");
            DropForeignKey("dbo.Ratings", "CusId", "dbo.Customers");
            DropForeignKey("dbo.Menus", "ResId", "dbo.Restaurants");
            DropForeignKey("dbo.Payments", "CusId", "dbo.Customers");
            DropForeignKey("dbo.Payments", "BookingId", "dbo.Bookings");
            DropIndex("dbo.Tokens", new[] { "LoginId" });
            DropIndex("dbo.Logins", new[] { "Email" });
            DropIndex("dbo.Logins", new[] { "Username" });
            DropIndex("dbo.Feedbacks", new[] { "UserId" });
            DropIndex("dbo.Reviews", new[] { "ResId" });
            DropIndex("dbo.Reviews", new[] { "CusId" });
            DropIndex("dbo.Ratings", new[] { "ResId" });
            DropIndex("dbo.Ratings", new[] { "CusId" });
            DropIndex("dbo.Menus", new[] { "ResId" });
            DropIndex("dbo.Restaurants", new[] { "Email" });
            DropIndex("dbo.Restaurants", new[] { "Username" });
            DropIndex("dbo.Payments", new[] { "ResId" });
            DropIndex("dbo.Payments", new[] { "CusId" });
            DropIndex("dbo.Payments", new[] { "BookingId" });
            DropIndex("dbo.Customers", new[] { "Email" });
            DropIndex("dbo.Customers", new[] { "Username" });
            DropIndex("dbo.Bookings", new[] { "ResId" });
            DropIndex("dbo.Bookings", new[] { "CusId" });
            DropIndex("dbo.Admins", new[] { "Email" });
            DropIndex("dbo.Admins", new[] { "Username" });
            DropTable("dbo.Tokens");
            DropTable("dbo.Logins");
            DropTable("dbo.Feedbacks");
            DropTable("dbo.Reviews");
            DropTable("dbo.Ratings");
            DropTable("dbo.Menus");
            DropTable("dbo.Restaurants");
            DropTable("dbo.Payments");
            DropTable("dbo.Customers");
            DropTable("dbo.Bookings");
            DropTable("dbo.Admins");
        }
    }
}
