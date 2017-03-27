namespace UUJ.GuidersHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventUpdate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Event", "Description", c => c.String());
            AlterColumn("dbo.Event", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Event", "Location", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Event", "Location", c => c.String());
            AlterColumn("dbo.Event", "Name", c => c.String());
            DropColumn("dbo.Event", "Description");
        }
    }
}
