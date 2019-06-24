namespace Keszobranie.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;
    using System;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public partial class Initial : DbMigration
    {
        public override void Up()
        {

            CreateTable(
                "dbo.Keszs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        description = c.String(),
                        hint = c.String(),
                        locationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.locationId, cascadeDelete: true)
                .Index(t => t.locationId);
             
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        latitude = c.Double(nullable: false),
                        longitude = c.String(),
                        difficulty = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Founds",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        keszId = c.Int(nullable: false),
                        userId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Keszs", t => t.keszId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.userId, cascadeDelete: true)
                .Index(t => t.keszId)
                .Index(t => t.userId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        surname = c.String(),
                        regDate = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Reputations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        keszId = c.Int(nullable: false),
                        userId = c.Int(nullable: false),
                        locationId = c.Int(nullable: false),
                        data = c.String(),
                        opinion = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Keszs", t => t.keszId, cascadeDelete: true)
                .ForeignKey("dbo.Locations", t => t.locationId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.userId, cascadeDelete: true)
                .Index(t => t.keszId)
                .Index(t => t.userId)
                .Index(t => t.locationId);

            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reputations", "userId", "dbo.Users");
            DropForeignKey("dbo.Reputations", "locationId", "dbo.Locations");
            DropForeignKey("dbo.Reputations", "keszId", "dbo.Keszs");
            DropForeignKey("dbo.Founds", "userId", "dbo.Users");
            DropForeignKey("dbo.Founds", "keszId", "dbo.Keszs");
            DropForeignKey("dbo.Keszs", "locationId", "dbo.Locations");
            DropIndex("dbo.Reputations", new[] { "locationId" });
            DropIndex("dbo.Reputations", new[] { "userId" });
            DropIndex("dbo.Reputations", new[] { "keszId" });
            DropIndex("dbo.Founds", new[] { "userId" });
            DropIndex("dbo.Founds", new[] { "keszId" });
            DropIndex("dbo.Keszs", new[] { "locationId" });
            DropTable("dbo.Reputations");
            DropTable("dbo.Users");
            DropTable("dbo.Founds");
            DropTable("dbo.Locations");
            DropTable("dbo.Keszs");
        }
    }
}
