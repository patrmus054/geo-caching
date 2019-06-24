namespace Keszobranie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userEmailAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "email");
        }
    }
}
