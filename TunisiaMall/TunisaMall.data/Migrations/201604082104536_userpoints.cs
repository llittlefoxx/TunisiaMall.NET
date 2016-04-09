namespace TunisaMall.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userpoints : DbMigration
    {
        public override void Up()
        {
            AddColumn("user", "points", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("user", "points");
        }
    }
}
