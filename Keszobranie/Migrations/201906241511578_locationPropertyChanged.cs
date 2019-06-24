namespace Keszobranie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class locationPropertyChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Locations", "longitude", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Locations", "longitude", c => c.String());
        }
    }
}
