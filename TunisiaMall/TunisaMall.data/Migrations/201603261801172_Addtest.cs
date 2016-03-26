namespace TunisaMall.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addtest : DbMigration
    {
        public override void Up()
        {
            AddColumn("promotion", "test", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("promotion", "test");
        }
    }
}
